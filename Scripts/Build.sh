#!/usr/bin/env bash

set -e

SCRIPT_DIR=$( cd -- "$( dirname -- "${BASH_SOURCE[0]}" )" &> /dev/null && pwd )
PROJECT_ROOT=$(realpath "$SCRIPT_DIR/..")
cd $PROJECT_ROOT

# Simply call the Tempo Build script with the same arguments.
./Plugins/Tempo/Scripts/Build.sh "$@"
