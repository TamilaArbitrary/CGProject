// IDrawingEngine.cs
using System;
using System.Globalization;


public interface IDrawingEngine
{
    void SetColorRGB(float r, float g, float b);
    void SetColorCMY(float c, float m, float y); // ����������, �� ��������� �������� � RGB
    void SetColorHSV(float h, float s, float v); // ����������, �� ��������� �������� � RGB
    void SetColorLAB(float l, float a, float b); // ����������, �� ��������� �������� � RGB

    void StartDraw();
    void DrawTo(PointData newPoint);

    void SetCurrentTransformMatrix(MatrixData matrix);
    PointData ApplyCurrentTransform(PointData point); // ��������� ������� ������� �� �����
}