param([string]$fpath)
# param([string]$fpath = "C:\tmp\Share\BankTestOutput.html")
# fpath is the path of file where HTML code coverage results file is stored. This could be in HTML or XML format
$fcontent = get-content $fpath | % { $_ -replace "&nbsp", " "}
[xml]$xmldata = $fcontent

foreach($obj in $xmldata.html.body.table.tr[0])
{
    #Write-Host($obj.td);
	<#if($obj.td -contains '*failed*')#>  #Change this parameter if the test is to be executed for some other value matching
    if($obj.td -Match "failed" ) 
	{
		Write-Verbose "Result failed" -verbose;
         Write-Host("Result failed");
		 exit -1
	}
	else
	{
         #Write-Host("Result Successfull");
		 Write-Verbose "Result Passed" -verbose;
		 exit 0
	}
}