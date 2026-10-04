Shader "Custom/DepthMaskFixed" {
    SubShader {
        Tags { 
            "Queue"="Geometry-10" 
            "RenderType"="Opaque" 
        }

        Pass {
            Cull Off
            ZTest LEqual
            ZWrite On
            Lighting Off
            ColorMask 0
            Blend One Zero

            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 2.0

            #include "UnityCG.cginc"

            struct appdata {
                float4 vertex : POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f {
                float4 pos : SV_POSITION;
                UNITY_VERTEX_OUTPUT_STEREO
            };

            v2f vert(appdata v) {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
                o.pos = UnityObjectToClipPos(v.vertex);
                return o;
            }

            fixed4 frag(v2f i) : SV_Target {
                return fixed4(0, 0, 0, 0);
            }
            ENDCG
        }
    }
    Fallback "Unlit/Color"
}