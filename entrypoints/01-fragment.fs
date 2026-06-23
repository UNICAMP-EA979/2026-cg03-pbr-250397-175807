#version 330 core

#include "light.glsl"

#define MAX_LIGHT 10
#define PI 3.14159265359

//Realiza o sombreamento considerando dados da luz
//Considere f_brdf = 1

in vec3 worldPosition;
in vec3 worldNormal;

out vec4 FragColor;

uniform Light lights[MAX_LIGHT];

void main()
{
    //Calcule a normal do fragmento
    vec3 worldNormalNormalized =;

    vec3 color = vec3(0);
    for(int i = 0; i < MAX_LIGHT; i++)
    {
        Light light = lights[i];
        if(light.type == LIGHT_UNSET)
        {
            break;
        }

        //Calcule dados da luz (atenuação, cor, direção)
        float attenuation = ;
        vec3 lightColor = ;
        vec3 lightDirection = ;


        //Calcule a contribuição da luz e acumule na color
        vec3 lightContribution = ;
    }

    // Atribua a color para a cor do fragmento
    FragColor = ;
}
