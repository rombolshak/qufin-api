param([Parameter(Mandatory=$true)]$pathToSlnFile,
	  [Parameter(Mandatory=$true)]$pathToOutput,
	  [Parameter(Mandatory=$true)]$pathToResharperTool)
	  
$pathToOutputXml=$pathToOutput + "\ListOfIssues.xml"
$pathToFilteredXml=$pathToOutput + "\FilteredListOfIssues.xml"

$pathToScriptsFolder = Split-Path $MyInvocation.MyCommand.Path

function RunSolutionAnalyze()
{
	if(!(Test-Path -path $pathToOutput))
	{
		New-Item $pathToOutput -Type Directory
	}
	
	& $pathToResharperTool /o:$pathToOutputXml $pathToSlnFile
}

RunSolutionAnalyze

& "$pathToScriptsFolder\OutputAnalyzeFilter.ps1" -pathToOutput $pathToOutput

#Remove-Item $pathToOutputXml