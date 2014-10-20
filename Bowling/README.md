Bowling Kata in scriptcs
========================

Fun with [Uncle Bob's Bowling Kata](http://butunclebob.com/files/downloads/Bowling%20Game%20Kata.ppt) in ScriptCs.

If you don't have ScriptCs, follow the install instructions on http://scriptcs.net/

Then, create a new directory somewhere for your script (d:\katas).

Switch to that directory and run

```
scriptcs -install ScriptCs.Fixie
scriptcs -install Shouldly
```

Create a new file, bowling.csx, and add the following

```
using Shouldly;

var fixie = Require<FixieRunner>();
fixie.RunAllTests(); 
```

You can then run the script (note, you need to run in debug)

```
> scriptcs bowling.csx -debug
```

All steps in the kata, as I go through them, are commits on the bow.csx. So, start from the first commit if you want to see how I'm going through red/green/refactor with Uncle Bob's kata.

Not claiming this is the right or best impl or approach, but I'm branching out a little by doing this in the open.
