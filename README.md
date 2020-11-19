# .NET Source Map SDK

This is a port of the [source-map](https://github.com/mozilla/source-map) project from Mozilla but for use in .NET applications and tools. The library allows for generating and consuming [source map files](https://docs.google.com/document/d/1U1RGAehQwRypUTovF1KRlpiOFze0b-_2gc6fAH0KY0k/edit).

## Motivation

This project has begun as a port of the source-map project as an aim to provide a native library that can be used by the Fable project. Since the release of Fable 3, previous support for source maps is no longer available due to changes in the fundamental design. The goal here is that providing a .NET library for generating source map files, Fable will be able to leverage this library in order to 

Additionally source map files have always been a very useful detail of web development in my personal career when working with Babe, Typescript, Elm, and others so I'm generally curious to learn more about how they work and at the same time fill a gap that appears to exist in .NET tooling.

## Run Tests

```bash
$ dotnet test
```