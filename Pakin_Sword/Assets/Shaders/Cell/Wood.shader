Shader "Custom/Wood"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _RoughTex ("RoughTex", 2D) = "white" {}
        _Roughness ("Roughness", range(0,1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;
        sampler2D _RoughTex;

        half _Roughness;

        struct Input
        {
            float2 uv_MainTex;
            float2 uv_RoughTex;
        };
        
        fixed4 _Color;
        
        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Albedo comes from a texture tinted by color
            fixed4 MainTex = tex2D (_MainTex, IN.uv_MainTex) * _Color;
            fixed4 RoughTex = tex2D (_RoughTex, IN.uv_RoughTex);
            o.Albedo = lerp(MainTex.rgb, RoughTex.rgb, _Roughness);
            o.Alpha = MainTex.a;
        }
        ENDCG
    }
    FallBack "Diffuse"
}
