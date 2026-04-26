#include "pch.h"
#include "Emulator.h"

float GetVoltage() {
	// Simulate a voltage reading that changes over time
	static float time = 0.0f;
	time += 0.1f; // Increment time
	return 5.0f * std::sin(time) + rand(); // Return a voltage that oscillates between -5V and 5V + some random noise
}