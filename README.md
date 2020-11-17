# C# Workshop

[![Binder](https://mybinder.org/badge_logo.svg)](https://mybinder.org/v2/gh/NikiforovAll/csharp_workshop/main)

Let's explore *C#8,9* together.

![catjam](./guide/catjam.gif)

## Getting started

### Binder

Just click "launch binder" and you ready to go.

### Devcontainer

Prerequisites:

* "ms-vscode-remote.vscode-remote-extensionpack" is installed.

1. Open a new instance of vscode and run command palette command: `"Remote Containers: Clone Repository in Container Volume"`
   * ("command": "remote-containers.openRepositoryInVolume")
2. Select GitHub and enter NikiforovAll/csharp_workshop

### Manual

Clone repository and investigate on your own.

## Agenda

* `notebooks\nullable-reference-types.ipynb`
* `samples\scripts\nullable-reference-types.csx`

* `notebooks\functions-misc.ipynb`
* `samples\scripts\null-coalescing-assignment.csx`
* `samples\scripts\static-local-functions.csx`
* `samples\scripts\static-anonymous-functions.csx`
* `samples\scripts\lambda-discards.csx`

* `notebooks\async-streams.ipynb`
* `samples\projects\get-enumerator-foreach`

* `notebooks\ranges-indexes.ipynb`

* `notebooks\using-declarations.ipynb`

* `notebooks\pattern-matching.ipynb`
* `samples\scripts\pattern-matching\pattern-matching-demo1.csx`
* `samples\scripts\pattern-matching\pattern-matching-demo2.csx`

* `notebooks\records.ipynb`
* `samples\scripts\records.csx`
* `samples\scripts\records-demo1.csx`
* `samples\scripts\records-demo2.csx`
* `samples\scripts\target-typed-new-expressions.csx`

* `notebooks\top-level-statements.ipynb`
* `samples\projects\simple-webapi\`

* `notebooks\module-initializers.ipynb`
* `samples\projects\module-init`

* `notebooks\source-generators.ipynb`

## Talk

* Why do we need particular feature?
  * How does it improve your code?

## Plan

<!-- cSpell:disable -->
* ➕ Развитие C# в контексте современных языков программирования
* ➕ Ссылочные типы, допускающие значение null C#8
* ➕ Выражения. C#7,8,9
* ➕ Сопоставление шаблонов C#7,8,9
* ➕ Выражения switch C#8
* ➕ Литеральные выражения default С#7
* ➕ Присваивание объединения со значением NULL C#8
* ➕ Выражения throw C#7
* ➖ Условные выражения ref C#7.2
* ➖ Условное выражение с целевым типом C#9
* ➕ Индексы и диапазоны C#8
* ➕ Асинхронные последовательности/потоки. Асинхронные высвобождаемые типы C#8
* ➖ Деконструкция типов C#7,9
* ➖ Кортежи и пользовательские типы C#7
* ➕ Поддержка расширения GetEnumerator для циклов foreach С#9
* ➕ Локальные функции C#7,8
* ➕ Статические анонимные функции C#9
* ➕ Атрибуты локальных функций C#9
* ➕ Параметры удаления (discards) лямбда-выражения C#9
* ➕ Объявления using C#8
* ➖ Члены доступные только для чтения C#8
* ➖ Методы интерфейса по умолчанию C#8
* ❔ Ковариантные возвращаемые типы C#9
* Методы назначения (setters) только инициализации C#9
* Записи (Record types) C# 9
* ➕ Новые выражения целевого типа C#9
* Генераторы кода C#9
* ➕ Инициализаторы модулей C#9
* ➕ Инструкции верхнего уровня C#9

<!-- cSpell:enable -->
## Reference

* <https://devblogs.microsoft.com/dotnet/net-core-with-juypter-notebooks-is-here-preview-1/>
* <https://devblogs.microsoft.com/dotnet/welcome-to-c-9-0/>
* <https://github.com/dotnet/core/blob/master/release-notes/5.0/preview/5.0.0-rc.1.md>
