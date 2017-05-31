# tsonamu

"tsonamu", short for "The Simplest of Network Availability Monitoring Utilities", was created during a temporary outage of the internet in my street. The - completely obsolete and useless - software was written by me for the purpose of learning.

The software pings any given URL every two seconds to check whether an internet connection is established, and writes the results into a logfile. Since my internet connection is quite unstable now (as I am writing this, the web is once again failing me!), I built this programm to keep track of when connection problems occur.

Of course, this is completely barmy, because every router does the same, but in my defence, I was bored, so I developed this anyway. It was worth the effort, because I coded some interesting stuff for my ever-growing list of self-made methods and classes I might re-use later on.

## usage

`tsonamu.exe [-hostname url] [-nolog]`

-hostname url   this url will be pinged to check the functionality of the internet connection.
-nolog          if this argument exists, no log file will be written

## icon

Yay, I made an icon for an obsolete program. It's actually the most sophisticated thing about the software, so I'll include it. It's a whopping 16 by 16 pixels, which makes impressive 256 pixels².

## future plans

I'm not sure what I'm gonna make of this. I might add a taskbar icon to inform the user (that's me) of sudden increases in ping and failure/return of their internet connection. Who knows. Maybe not. Or maybe. Did I mention I code when I'm bored?
