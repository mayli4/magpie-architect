using ImGuiNET;
using Raylib_cs;
using rlImGui_cs;
using static Raylib_cs.Raylib;

namespace Architect;

public static unsafe class Program {
    // ReSharper disable once UnusedMember.Local
    static void Main() {
        Raylib.SetTraceLogCallback(&Logging.LogConsole);
        Architect game = new Architect();
        game.Run();
    }
}

public class Architect {
    public void Run() {
        SetConfigFlags(ConfigFlags.ResizableWindow | ConfigFlags.VSyncHint);

        InitWindow(
            800,
            400,
            "magpie"
        );

        SetTargetFPS(60);

        rlImGui.Setup(true, true);

        while(!WindowShouldClose()) {
            Update();
            Draw();
        }

        CloseWindow();
    }

    private protected void Update() {
        
    }

    private protected void Draw() {
        ClearBackground(Color.DarkGray);
        BeginDrawing();
        
        DrawImGui();
        
        EndDrawing();
    }

    private void DrawImGui() {
        rlImGui.Begin();
        
        // ImGui.Begin("##IMGUI");
        ImGui.BeginMainMenuBar();
        
        ImGui.EndMainMenuBar();
        
        rlImGui.End();
    }
}