# CsharpCrosplatformSambaClient
A library to access Samba shared from Windows and Unix like systems, distributed by Google

To use it on Ubuntu you'll need to setup it first. Do the following.
Run this script:

```bash
#!/usr/bin/env bash

sudo apt-key adv --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
sudo apt install apt-transport-https ca-certificates
echo 'deb https://download.mono-project.com/repo/ubuntu stable-xenial main' | sudo tee /etc/apt/sources.list.d/mono-official-stable.list

sudo apt update
sudo apt install mono-devel mono-complete
```

Download this Makefile generator:

https://linux.die.net/man/1/prj2make
