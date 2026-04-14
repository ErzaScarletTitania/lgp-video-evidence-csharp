using OpenCvSharp;

var videoPath = @"C:\Users\Susana\Desktop\Resilient Strategy\v 7.0\Sipass Testing Session 14-04-26.mp4";
var outDir = @"C:\Users\Susana\.copilot\session-state\2c41b785-25a0-4740-8d9a-f9e570470658\files\opencv-frames";
var timestamps = new[] { 0, 30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360, 390, 420, 450, 480, 510, 540 };

Directory.CreateDirectory(outDir);

using var capture = new VideoCapture(videoPath);
if (!capture.IsOpened())
{
    throw new InvalidOperationException($"Could not open video: {videoPath}");
}

var fps = capture.Fps;
if (fps <= 0)
{
    throw new InvalidOperationException("Video FPS could not be determined.");
}

using var frame = new Mat();
foreach (var seconds in timestamps)
{
    capture.PosMsec = (int)(seconds * 1000.0);
    if (!capture.Read(frame) || frame.Empty())
    {
        Console.WriteLine($"SKIP {seconds}");
        continue;
    }

    var outputPath = Path.Combine(outDir, $"frame-{seconds:D4}.png");
    Cv2.ImWrite(outputPath, frame);
    Console.WriteLine(outputPath);
}
