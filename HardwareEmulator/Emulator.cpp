#include "pch.h"
#include <cmath>
#include <random>

extern "C" __declspec(dllexport) float GetVoltage() {
    static float time = 0.0f;
    time += 0.1f;

    float noise = ((float)rand() / RAND_MAX);

    return 5.0f * std::sin(time) + noise;
}