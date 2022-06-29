build: main.cs cspline.cs
	mcs -target:library cspline.cs
	mcs -target:exe -out:main.exe -reference:cspline.dll main.cs

run:build 
	mono main.exe

clean:
	rm *.exe
	rm *.dll
