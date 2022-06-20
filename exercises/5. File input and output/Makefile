all: Out.txt
	cat $<

Out.txt: main.exe
	mono $< > $@

main.exe : main.cs cmath.dll
	mcs -reference:cmath.dll main.cs

clean:
	rm -rf Out.txt main.exe

cmath.dll : cmath.cs complex.cs
	mcs -target:library -out:./cmath.dll $^ # note "./" in front of cmath.dll
