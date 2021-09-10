function Credential-check ($username, $password) {
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
            Write-Host "Konto instnieje 'temp.temp' istnieje, nie mo¿na sprawdziæ danych logowania"
            exit
        }
    }
    catch {
        return $true
    }
}