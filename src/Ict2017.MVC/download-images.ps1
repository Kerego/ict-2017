param(
    [string]$path=''
)

$url = "https://unsplash.it/1000/1000/?random"
$total = 15
$wc = New-Object System.Net.WebClient
for($i = 0; $i -lt $total; $i++){
    $wc.DownloadFile($url, ("{1}\image{0}.jpg" -f $i, $path))
}