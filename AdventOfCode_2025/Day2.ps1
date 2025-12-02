



$data = (Get-Content ./Day2_Test.txt) -split (",") | where-object { $_ }
$data = (Get-Content ./Day2_Data.txt) -split (",") | where-object { $_ }

foreach ($line in $data) {
    [int]$start = ($line -split "-")[0]
    [int]$end = ($line -split "-")[1]
    Write-output "$start ---- $end"
    for ($num = $start; $num -le $end; $num++) {
        # Write-Output "i == $i"
        $values = @{}
        for ($patternSize = 1; $patternSize -le $num.length + 1; $patternSize++) {    
            # Write-Output "j == $j"   
            foreach ($split in (($num -split "(?<=\G.{$patternSize})") | where-object { $_ })) {
                Write-Output $split
               
               
                # THIS IS WEIRD
                if ([string]::IsNullOrEmpty($values[$patternSize][$split])) { $values[$patternSize][$split] = 0 }
                $values[$patternSize][$split]++
            }
        }
    }
}

