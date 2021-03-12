echo "starting batch file"
echo The current directory is %CD%

for /f  %%G in ('dir *.zip /b') do (
    set filename=%%~G
    echo "Inside loop filename %%G"
    echo "file name %%~nG"
)
