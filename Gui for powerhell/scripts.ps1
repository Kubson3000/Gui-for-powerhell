$username = Read-Host
$password = Read-Host -AsSecureString
$user_credentials = New-Object System.Management.Automation.PSCredential $username,$password

$exist = $false
try {
    try {
        $exist = [bool] (Get-ADUser temp.temp)
    }
    catch {
        $temp_bool = [bool] (New-ADUser temp.temp -Credential $user_credentials) #returns False if created
        if (!$temp_bool) {
            Remove-ADUser temp.temp -Credential $user_credentials -Confirm:$false
            return $false
        }
    }
    if ($exist) {
        Write-Host "Konto instnieje 'temp.temp' istnieje, nie można sprawdzić danych logowania"
        exit
    }
}
catch {
    return $true
}