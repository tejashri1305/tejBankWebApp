Write-Host("Release Management Triggered");
c:
cd "C:\Microsoft\Microsoft Visual Studio 12.0\Release Management\bin";
& ReleaseManagementBuild.exe release -rt BankApplicationpipeline_Orig -pl "\\vchniladpsci-06\TFSLogReports";
Write-Host("Release Management End");