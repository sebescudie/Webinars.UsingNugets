# NODE20.Nuget

_This repo will collect ideas, patches and directions for a workshop about Nuget related stuff @NODE20._

## Repo structure

For now, ideas can be collected and discussed in the Issues or the Projects pages

## Warum the name?

This workshop should address the two differents aspects of working with nugets in VL :

- Importing and using existing C# libraries
- Creating VL plugins around existing C# libraries

## Workshop format

It's not clear yet how this workshop is going to be structured. Should it be split into two different ones? What's the part of "hands-on" stuff versus pure "lecture" stuff? A first approach would be :

### Beginner level : consume C# libraries

No (or few) programming concepts involved, just evoking with high-level terms what is a library (a nuget), where you find one and how you can _instantly_ use one in your project.

- Hands-on : start with a defined need. For instance, "we want to make this project that does this and that, but this specific feature is not available in VVVV". We look at what's available on the internet, install it and solve our problem. Mention (or even figure out a specific case to illustrate) that some libraries are not suited for dataflow, and require some adaptation to work in vvvv.
- Lecture : after this is done and that we've seen that we have solved our issues, just give some background information on the structure of a dll : the fact that it contains functions and types (don't talk about classes), and that those functions and types turn to nodes and categories when they're imported in vvvv.

### Hardcore level : create a VL Package

We assume people are totaly familiar with C# libraries, what a `.dll` is and how libraries can rely on each other. This one would more focus on curating a lib for VL usage, and publish a fully fledged package (available on nuget, with help patches and stuff).

- Lecture : a reminder of vvvv gamma's conventions (avoid as much as possible types like `float64`, `MutableList<T>` and so on). This leads to explain what forwarding is, and how this allows to curate nodes for vvvv (conventions + dataflow paradigm). Also, explain stuff about help flags and the help browser, and how/why patches end up there.
- Hands on : we take a cool nuget and make a fully fledged vvvv package out of it.
