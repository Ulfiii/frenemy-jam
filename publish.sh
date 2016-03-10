#!/bin/sh
pushd Build
cp tlb-jam/tlb-jam.html tlb-jam/index.html

scp -r tlb-jam amrox@amrox.webfactional.com:webapps/amrox_general/games/


