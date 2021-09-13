$imie = $input1
$nazwisko = $input2
$haslo = $input3

$password = ConvertTo-SecureString -String $haslo -asplaintext -Force
$imiel = $imie.ToLower().Normalize("FormD") -replace '\p{M}', ''
$nazwiskol = $nazwisko.ToLower().Normalize("FormD") -replace '\p{M}', ''
$samusername = $imiel + "." + $nazwiskol
$shortsamusername = $imiel.Substring(0,1) + "." + $nazwiskol
$result_nb = 0

if ([bool] (Get-ADUser -Filter { SamAccountName -eq $samusername })) {
	$result_nb = 1 # Istnieje (pełne imie)
}
elseif ([bool] (Get-ADUser -Filter { SamAccountName -eq $shortsamusername })) {
	$result_nb = 2 # Istnieje (iniciał)
}
if ($haslo -notmatch "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$") {
	if ($result_nb -eq 1) {$result_nb = 3} # Istnieje (pełne imie) + błędne hasło
	elseif ($result_nb -eq 2) {$result_nb = 4} # Istnieje (iniciał) + błędne hasło
	else {$result_nb = 5} # Błędne hasło
}
New-Item -Name "result.txt" -Value $result_nb -Force