# epl-cs
Implementação do EPL na linguagem C#.

Pode ser compilado usando o compilador MonoC#, através do comando (Linux):
```
mcs -out:tests src/*.cs src/*/*.cs [-d:features ... ]
```

Ou do compilador VisualC# (Windows) atráves do comando:
```
csc /out:test.exe src\*.cs src\classes\*cs src\interfaces\*.cs src\Tests\*.cs src\eval\*.cs [/d:features ...]
```

Onde features podem ser:
* FEATURE_ADD (inclui a feature ADD)
* FEATURE_SUB (inclui a feature SUB)
* FEATURE_MUL (inclui a feature MUL)
* FEATURE_EVAL (inclui a feature EVAL)
* FEATURE_HEIGHT (inclui a feature HEIGHT)

Exemplo, para compilar e executar os testes de unidade para as features SUB e EVAL:

**(Linux)**
```
$ mcs -out:tests src/*.cs src/*/*.cs -d:FEATURE_SUB -d:FEATURE_EVAL
$ ./tests
```

**(Windows)**
```
> csc /out:tests.exe src\*.cs src\classes\*cs src\interfaces\*.cs src\Tests\*.cs src\eval\*.cs src\height\*.cs /d:FEATURE_SUB /d:FEATURE_EVAL
> tests
```
