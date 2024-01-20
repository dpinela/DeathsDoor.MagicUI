# MagicUI

A core mod for Death's Door that takes all the fuss of dealing with GameObjects behind the scenes,
allowing mod authors to seamlessly create in-game UIs for their mod with an easy-to-use hierarchical
layout system inspired by WPF.

MagicUI was [originally written for Hollow Knight][hk-mui]; this version is a
direct port, featuring minimal changes to allow it to run within Death's Door
instead of HK. The mod's public API is unchanged and the original documentation
remains applicable.

[hk-mui]: https://github.com/BadMagic100/HollowKnight.MagicUI

## Features

* Layout & component system, with no GameObjects (but you can access them if you really want to)
* Several built-in elements and layouts for general use, such as:
  * Stack layout
  * Images
  * Buttons
  * Text display
  * Text input fields
* API to create custom components and layouts to suit your needs
* Persistent and non-persistent layout types
* Ability to show UI elements only while the game is paused
* Utility to listen for specific hotkeys given modifier keys and an optional condition

## Get started

To use MagicUI, install it like you would any other mod and declare a dependency in your mod project. See
the [MagicUIExamples](/MagicUIExamples) project for samples of what you can do, or view 
[the full docs](https://badmagic100.github.io/HollowKnight.MagicUI).