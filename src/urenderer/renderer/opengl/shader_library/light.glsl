#ifndef LIBRARY_LIGHT

const int LIGHT_UNSET = 0;
const int LIGHT_DIRECTIONAL = 1;
const int LIGHT_POINT = 2;
const float R_MIN = 0.05;

struct Light
{
    int type;
    vec3 color;
    float intensity;
    vec3 direction; //Only directional
    vec3 position; //Only point
    float reference_distance; //Only point
};

// Calcula a atenuação da luz
float computeLightAttenuation(Light light, vec3 position)
{
    if(light.type == LIGHT_DIRECTIONAL)
    {
    }
}

//Calcula a direção da luz
vec3 computeLightDirection(Light light, vec3 position)
{

}

#define LIBRARY_LIGHT
#endif