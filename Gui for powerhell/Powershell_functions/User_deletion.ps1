$nazwisko = "$input1"
$index = "$input2"
$oued_mng = "OU=O365,OU=Users,OU=MyBusiness,DC=korona,DC=wielun,DC=pl"
$array = Get-ADUser -SearchBase $oued_mng -Filter "(sn -eq '$nazwisko')" -Properties department,DistinguishedName | Where-Object {$_.DistinguishedName -notlike "*OU=Disabled*"} | select Name,department,DistinguishedName
$deleted_san = $array[$index]
