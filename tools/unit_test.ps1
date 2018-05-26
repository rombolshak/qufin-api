$sciptDirectory = Split-Path $MyInvocation.MyCommand.Path
$tests = gci -Path "$sciptDirectory\..\src" -Filter "*Tests.csproj" -Recurse |% { $_.FullName }
Write-Host These projects contains tests: $tests
$tests |% { dotnet test $_ --no-build -l "trx" }
exit $LastExitCode 