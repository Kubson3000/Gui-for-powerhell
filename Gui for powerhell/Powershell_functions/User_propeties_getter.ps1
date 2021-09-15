$imie = "$input1"
$nazwisko = "$input2"
$number = Get-Content -Path "number.txt"
$haslo = "$input3"
$pass = ConvertTo-SecureString -String $haslo -asplaintext -Force
$imiel = $imie.ToLower().Normalize("FormD") -replace '\p{M}', ''
$nazwiskol = $nazwisko.ToLower().Normalize("FormD") -replace '\p{M}', ''
$samusername = $imiel + "." + $nazwiskol
$shortsamusername = $imiel.Substring(0,1) + "." + $nazwiskol

$username = "$user_input"
$password = "$pass_input"
$password = ConvertTo-SecureString -String $password -asplaintext -Force
$user_credentials = New-Object System.Management.Automation.PSCredential $username,$password

if ($number -eq 1) {
	$data = Get-ADUser $samusername -Properties proxyAddresses,title,departmentNumber,department -Credential $user_credentials
}
if ($number -eq 2) {
	$data = Get-ADUser $shortsamusername -Properties proxyAddresses,title,departmentNumber,department -Credential $user_credentials
}

$data.userprincipalname -match "(?<=@).{1,}$" > $null
$upn = $Matches[0]

New-Item -Name "title.txt" -Value $data.title -Force
New-Item -Name "dp.txt" -Value $data.gitdepartment -Force
New-Item -Name "dp_number.txt" -Value $data.departmentnumber -Force
New-Item -Name "upn.txt" -Value $upn -Force
