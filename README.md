# LGP Video Evidence - C#

C# OpenCV helper extracted from the G-Connect testing session workspace.

## Purpose

This console tool samples a recorded test-session video at fixed timestamps and writes PNG frames for evidence review.

## Current behavior

- Uses `OpenCvSharp` to open the recorded video
- Seeks to fixed timestamps
- Saves each sampled frame as a PNG
- Writes output into the Copilot session workspace

## Notes

- The code is preserved with the original session-specific absolute paths.
- This repository was split out from the session workspace without recreating the implementation.

## Main files

- `Program.cs`
- `video-extractor.csproj`

## Related projects

- [LGP Video Evidence - PowerShell](https://github.com/ErzaScarletTitania/lgp-video-evidence-powershell): an alternative frame-extraction implementation using Windows media playback.
- [LGP QA Orchestration](https://github.com/ErzaScarletTitania/lgp-qa-orchestration): a related architecture reference for evidence-based QA workflows.

These are related projects, not package dependencies. This extractor keeps its own runtime and setup requirements.
