Shader "Draw/Outline"
{
//    SubShader
//    {
//        Tags { "RederType" = "Opaque"}
//        //셰이더 디테일 수준
//        LOD 200
//        //어떤 폴리곤을 로드 할지, 즉 화면에 보이는 부분. 이 경우에는 앞면
//        Cull Front
//        
//        //오브젝트의 렌더링 단위
//        Pass
//        {
//            CGPROGRAM
//            #include "UnityCG.cginc"
//            #pragma vertex vertLine
//            #pragma fragment fragLine
//            #pragma target 3.0
//
//            sampler2D _MainTex;
//            float _OutlineWidth;
//            float4 _OutlineColor;
//
//            struct v2f
//            {
//                float4 vertex : SV_POSITION;
//                float3 normal : NORMAL;
//                float3 vertexColor : COLOR;
//                float3 texcoord : TEXCOORD0;
//            };
//            
//            v2f vertLine (appdata_full v)
//            {
//                v2f o;
//                o.vertexColor = v.color;
//                o.texcoord = v.texcoord;
//                o.normal = v.normal;
//
//                o.vertex = UnityObjectToClipPos(v.vertex + v.normal * _OutlineWidth);
//                return o;
//            }
//            
//            ENDCG
//        }
//        
//        //CGPROGRAM 하고 ENDCG는 한쌍
//        CGPROGRAM
//        ENDCG
//    }
}