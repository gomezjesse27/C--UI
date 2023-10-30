
echo First remove old binary files
rm *.dll
rm *.exe

echo View the list of source files
ls -l

echo "Compile the file straight-line-functions.cs:"
mcs -target:library -r:System.Windows.Forms -out:straight-functions.dll straight-line-functions.cs

echo "Compile straight-line-travel-user-interface.cs:"
mcs -target:library -r:System.Drawing.dll -r:System.Windows.Forms.dll -r:straight-functions.dll -out:straight-line.dll straight-line-travel-user-interface.cs

echo "Compile and link straight-line-travel-main.cs:"
mcs -r:System -r:System.Windows.Forms -r:straight-line.dll -out:go.exe straight-line-travel-main.cs

echo "Run the program Straight Line Travel"
./go.exe

echo "The bash script has terminated."

