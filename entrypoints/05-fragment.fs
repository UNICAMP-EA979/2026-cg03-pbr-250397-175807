#version 330 core

#include "light.glsl"
#include "fresnel.glsl"
#include "diffuse.glsl"
#include "specular.glsl"

#define MAX_LIGHT 10
#define PI 3.14159265359

// Adicione suporte para texturas com tiling

in vec3 worldPosition;
in vec3 worldNormal;
in vec2 uv;

uniform vec3 ambientColor;
uniform sampler2D baseColorTexture;
uniform sampler2D metallicTexture;
uniform sampler2D roughnessTexture;
uniform float tiling = 1.0;

out vec4 FragColor;

uniform Light lights[MAX_LIGHT];

void main()
{
    // Calcule a normal do fragmento
    vec3 worldNormalNormalized = ;

    // Calcule a direção de visualização (saindo do ponto)
    vec3 viewDirection = ;

    // Calcule a uv com tiling
    vec2 uvTiling = ;

    // Realize sampling das texturas para obter as propriedades da superfície
    vec3 baseColor = ;
    float metallic = ;
    float roughness =;

    vec3 color = vec3(0);

    // Calcule a luz ambiente
    vec3 ambientLightContribution = ;


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

        //Calcule as refletância de fresnel, difusa e especular
        vec3 fresnel = ;
        vec3 diffuse = ;
        vec3 specular = ;

        //Calcule a refletância final
        vec3 reflectance = ;

        //Calcule a contribuição da luz e acumule na color
        vec3 lightContribution = ;
    }

    FragColor = ;
}
