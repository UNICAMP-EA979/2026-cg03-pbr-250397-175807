#version 330 core

#include "light.glsl"
#include "fresnel.glsl"
#include "diffuse.glsl"

#define MAX_LIGHT 10
#define PI 3.14159265359

// Adicione luz difusa ao modelo de sombreamento

in vec3 worldPosition;
in vec3 worldNormal;

out vec4 FragColor;

uniform Light lights[MAX_LIGHT];

void main()
{
    // Calcule a normal do fragmento
    vec3 worldNormalNormalized = ;

    //Calcula a direção de visualização (saindo do ponto)
    vec3 viewDirection = ;

    vec3 baseColor = vec3(0.5, 0.2, 0.5);
    float metallic = 0;

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

        //Calcule o half-angle
        vec3 halfAngle = ;

        //Calcule as refletância de fresnel e difusa
        vec3 fresnel = ;
        vec3 diffuse = ;

        //Calcule a refletância final
        vec3 reflectance = ;

        //Calcule a contribuição da luz e acumule na color
        vec3 lightContribution = ;
    }

    // Atribua a color para a cor do fragmento
    FragColor = ;
}
