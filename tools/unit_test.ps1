param([switch]$integration)
$sciptDirectory = Split-Path $MyInvocation.MyCommand.Path
$tests = gci -Path "$sciptDirectory\..\src" -Filter "*Tests.csproj" -Recurse |% { $_.FullName } |? { $result = $_.Contains("Integration.Tests"); return -not ($integration -xor $result) }
Write-Host These projects contains tests: $tests
$tests |% { dotnet test $_ --no-build -l "trx" }
exit $LastExitCode 