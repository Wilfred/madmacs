# MadMacs

MadMacs is an irreverent implementation of an Emacs Lisp interpreter
in the browser.

## Does it work?

No.

## What does it do?

Basically nothing yet.

## Will it work?

Probably not. It's overambitious.

## Will it work in node.js?

See above, but in principle it should. There's an excellent
elisp impementation in C already for any other platform though.

## Is it worth it?

For learning about elisp, it's brilliant. If it ever manages to be
useful, I'm sure having a in-browser Emacs will have some interesting
applications.

## Is anyone seriously trying to implement Elisp?

Several folks have made more headway than me:

* Clojure: https://github.com/hraberg/deuce
* Java/Scheme: http://jemacs.sourceforge.net/
* Guile: http://www.emacswiki.org/emacs-pt/GuileEmacs
* LLVM: https://github.com/boostpro/emacs-llvm-jit

# Development

MacMacs uses CoffeeScript:

    $ sudo npm install -g coffee-script
    
Rebuild on every file change:

    $ coffee --watch -c scripts/*.cs

License: GPL v3 or later.
