#!/usr/bin/env bash

for proj in "Standard" "MetaSrcGen" "NativeAOT"
do
	cd $proj
	dotnet publish -c Release -r linux-x64 --no-self-contained
	cd ..
done

rm results-*.txt || true

hyperfine \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard sync dataset.json 1" \
	"MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen sync dataset.json 1" \
	"NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT sync dataset.json 1" \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard async dataset.json 1" \
  "MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen async dataset.json 1" \
  "NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT async dataset.json 1" \
  | tee results-1.txt

hyperfine \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard sync dataset.json 10" \
	"MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen sync dataset.json 10" \
	"NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT sync dataset.json 10" \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard async dataset.json 10" \
  "MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen async dataset.json 10" \
  "NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT async dataset.json 10" \
  | tee results-10.txt

hyperfine \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard sync dataset.json 50" \
	"MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen sync dataset.json 50" \
	"NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT sync dataset.json 50" \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard async dataset.json 50" \
  "MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen async dataset.json 50" \
  "NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT async dataset.json 50" \
  | tee results-50.txt

hyperfine \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard sync dataset.json 100" \
	"MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen sync dataset.json 100" \
	"NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT sync dataset.json 100" \
	"Standard/bin/Release/net7.0/linux-x64/publish/Standard async dataset.json 100" \
  "MetaSrcGen/bin/Release/net7.0/linux-x64/publish/MetaSrcGen async dataset.json 100" \
  "NativeAOT/bin/Release/net7.0/linux-x64/native/NativeAOT async dataset.json 100" \
  | tee results-100.txt