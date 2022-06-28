build: main.cs cspline.cs
	csc -target:library cspline.cs
	csc -target:exe -out:main.exe -reference:cspline.dll main.cs

run:build 
	mono main.exe

clean:
	rm *.exe
	rm *.dll
