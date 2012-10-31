# TypeScript Compiler

A .NET Wrapper around the [TypeScript](http://www.typescriptlang.org/) compiler, originally written in TypeScript
but available so far only in Javascript.

## Description

TypeScript comes with a command line compiler, but not a callable library that
you may reference on a .NET project. All usages so far of the compiler use the
binary to compile. This library runs the JavaScript compiler directly.


## Usage

Usage is very simple:

    var result = new TypeScript.TypeScriptCompiler().Compile("class Person{}");

## Install via Nuget:

    Install-Package TypeScriptCompiler -Pre

## Also see

* [Nuget Package](https://nuget.org/packages/TypeScriptCompiler/0.8.0-alpha)
* [TypeScript webite](http://www.typescriptlang.org/)
* [TypeScript source code](http://typescript.codeplex.com/)
