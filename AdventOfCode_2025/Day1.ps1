

$data = Get-Content ./Day1_Test.txt
$data = Get-Content ./Day1_Data.txt

$currentNum = 50
$numOfZeros = 0
$lineNum = 0
foreach ($line in $data) {
    $lineNum++
    Write-Output "------ $lineNum ------"
    $direction = if ($line[0] -eq "R") { "Right" } else { "Left" }   
    [int]$amount = ($line.replace("R", "")).replace("L", "")

    if ($direction -eq "Right") {
        while ( [int] $amount -gt 99) { $amount -= 100; $numOfZeros++; Write-Output "ZERO INCREASED" }

        do {
            write-output "$lineNum --- $currentNum + $amount"
            if ($currentNum + $amount -gt 100) { $numOfZeros++; Write-Output "ZERO INCREASED" }
            $currentNum = ($currentNum + $amount) % 100

        } while ($currentNum -lt 0 -OR $currentNum -gt 99)
    }
    else {
        while ( [int] $amount -gt 99) { $amount -= 100; $numOfZeros++; Write-Output "ZERO INCREASED" }
        do {
            write-output "$lineNum --- $currentNum - $amount"
            $minusedAmount = ($currentNum - $amount)

            if ($currentNum -gt 0 -AND $minusedAmount -lt 0) { $numOfZeros++; Write-Output "ZERO INCREASED" }

            if ($minusedAmount -lt 0) {
                $currentNum = 100 - (-1 * $minusedAmount)
            }
            else {
                $currentNum = $minusedAmount
            }  
        } while ($currentNum -lt 0 -OR $currentNum -gt 99)
    }
    # pause 
    if ($currentNum -eq 0) { $numOfZeros++; Write-Output "LANDED ZERO" }
}

$numOfZeros



line 115
$line = $data[114]
$currentNum = 0


10 - 87

$currentNum = 26
$line = $data[-1]
