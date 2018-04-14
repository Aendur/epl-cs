win:
	csc /out:tests.exe \
	src\*.cs \
	src\interfaces\*.cs \
	src\classes\*cs \
	src\eval\*.cs \
	src\height\*.cs \
	src\Tests\*.cs \
	/d:FEATURE_SUB /d:FEATURE_EVAL

nix:
	mcs -out:tests src/*.cs src/*/*.cs \
	-d:FEATURE_SUB -d:FEATURE_EVAL