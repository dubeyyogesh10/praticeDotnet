echo "starting batch file"

for /f  %%G in ('dir *.zip /b') do (
    set filename=%%~G
    echo "Inside loop filename %%G"
    echo "file name %%~nG"
)