```
 _  __     _   _                _   _ _____ _____ 
| |/ /___ | |_| |__   __ _ _ __| \ | | ____|_   _|
| ' // _ \| __| '_ \ / _` | '__|  \| |  _|   | |  
| . \ (_) | |_| | | | (_| | |_ | |\  | |___  | |  
|_|\_\___/ \__|_| |_|\__,_|_(_)|_| \_|_____| |_|  
  --[ (c) 2016 The Wizard & The Wyrd, LLC ]--
     --[ (c) 2016 Ramon James Long III ]--  
                v. 0.0.1-alpha
```

About
=====

Kothar.NET is an open source MMO RPG server built upon Service Fabric.
A properly scaled Service Fabric cluster should be able to handle
millions of concurrent users.

Why Service Fabric?
===================

Quite frankly, Service Fabric is a solid platform for building distributed
and fault-tolerant micro-services on the .NET platform with future plans to
add JVM and Linux support.  Service Fabric has been in production use behind
the scenes at Azure for quite some time, and has a proven track record of 
supporting millions of clients.

Architecture
============

The bulk of Kothar.NET is contained in several individual libraries.
Each library has an accompanying stand-alone assembly comprising interfaces
used by that assembly; i.e., Kothar.Server relies upon Kohtar.Server.Interfaces.
These interfaces are the contracts between the various system components.  
Wherever possible, methods and properties should expect an interface instead of
a concrete type.  As much as possible, the code base should be SOLID and DRY.

All game events and game state will have its athoritative state held server side.
Game clients will submit data, and that data will be verified server side.
Essentially, all data wil be verified server side to make hacking as difficult as
possible.  We must always assume all client software installations are compromised
and we should never trust information sent from clients until it is verified server
side.

All communications over the wire should be encrypted with SSL at a bar minimum.  As
the platform evolves, so will its security foot print.

Licensing and Contributors
==========================

Kothar.NET is developed and released under the business-friendly MIT License.
We understand the proprietary nature of games development, and we welcome any
contributions back to the project when you can; especially bug fixes to the core
code base.  All contributions must be licensed under the MIT License.

Commercial Support
==================

The Wizard & The Wyrd, LLC offers commercial support and private feature development.
If we think your feature would be great for the community, we will try to negotiate a
lower fee for you so that we can release your enhancements and features to the community
as a whole after a specific exclusive period (long enough for you to keep your competitive
advantage).  If you absolutely can't live with custom commercial feature development being
released to the public, that is OK by us.  As fellow business owners, we respect your choice!

Platform Interop
================

In tandem to the main Kothar.NET project, we will be developing a Java/JVM project consisting
SOLEY of corresponding interfaces with unit tests to ensure JSON serialization and deserialization
between platforms.  Over time, we will pursue a protocol-compatible JVM version.
Of course, we will gladly accept pull requests -- with full test suites -- of other language &
platform interface libraries that are JSON serialization and deserialization compatible.

How to Contribute
=================
1.  Fork
2.  Create a feature branch.
3.  Hack away.
4.  Be sure to include a test suite.
5.  Rebase your branch to a final commit.
6.  Submit a Pull Request.