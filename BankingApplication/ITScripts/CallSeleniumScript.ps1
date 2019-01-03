try
{
 #Write-Verbose " Executing Selenium Test cases - Start"; 
  cd C:\tmp\Share;
  cmd.exe /c BankApplicationSeleniumTest.bat

 #Write-Verbose " Executing Selenium Test cases - End"; 
}
catch
{
  $ErrorMessage = $_.Exception.Message;
    #Write-Verbose  $ErrorMessage; 
    $lastexitcode=-1;
}
exit $lastexitcode;