
node
{
stage 'CHECKOUT GIT'
    git 'https://github.com/almeidainm/TesteJenkins.git'
stage 'RESTORE'
    bat label: '', script: '"C:/Nuget/nuget.exe" restore "C:/Users/Inmetrics/source/repos/TesteGoogleJenkins/TesteGoogleJenkins.sln"'
stage 'BUILD'
    bat label: '', script: 'TesteGoogleJenkins.sln'
stage 'TESTE ACESSO AO SITE'
    bat label: '', script: '"C:/Program Files (x86)/NUnit.org/nunit-console/nunit3-console.exe" TesteGoogleJenkins/bin/Debug/TesteGoogleJenkins.dll'
stage("GERANDO RELATÓRIO NO TRA"){
     nunit testResultsPattern: 'TestResult.xml'
     }
} 
 
