﻿namespace IVU.Common.Tls.HandshakeLayer.Protocol
{
    public enum CipherSuiteId : ushort
    {
        Unknown = 0xdada,
        TLS_EMPTY_RENEGOTIATION_INFO_SCSV = 0x00ff,
        TLS_ECDHE_ECDSA_WITH_AES_256_GCM_SHA384 = 0xc02c,
        TLS_ECDHE_RSA_WITH_AES_256_GCM_SHA384 = 0xc030,
        TLS_DHE_RSA_WITH_AES_256_GCM_SHA384 = 0x009f,
        TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA384 = 0xc024,
        TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA384 = 0xc028,
        TLS_DHE_RSA_WITH_AES_256_CBC_SHA256 = 0x006b,
        TLS_ECDHE_ECDSA_WITH_AES_256_CBC_SHA = 0xc00a,
        TLS_ECDHE_RSA_WITH_AES_256_CBC_SHA = 0xc014,
        TLS_DHE_RSA_WITH_AES_256_CBC_SHA = 0x0039,
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc087,
        TLS_ECDHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc08b,
        TLS_DHE_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc07d,
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xc073,
        TLS_ECDHE_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xc077,
        TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 0x00c4,
        TLS_DHE_RSA_WITH_CAMELLIA_256_CBC_SHA = 0x0088,
        TLS_ECDHE_ECDSA_WITH_AES_128_GCM_SHA256 = 0xc02b,
        TLS_ECDHE_RSA_WITH_AES_128_GCM_SHA256 = 0xc02f,
        TLS_DHE_RSA_WITH_AES_128_GCM_SHA256 = 0x009e,
        TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA256 = 0xc023,
        TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA256 = 0xc027,
        TLS_DHE_RSA_WITH_AES_128_CBC_SHA256 = 0x0067,
        TLS_ECDHE_ECDSA_WITH_AES_128_CBC_SHA = 0xc009,
        TLS_ECDHE_RSA_WITH_AES_128_CBC_SHA = 0xc013,
        TLS_DHE_RSA_WITH_AES_128_CBC_SHA = 0x0033,
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc086,
        TLS_ECDHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc08a,
        TLS_DHE_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc07c,
        TLS_ECDHE_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xc072,
        TLS_ECDHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xc076,
        TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0x00be,
        TLS_DHE_RSA_WITH_CAMELLIA_128_CBC_SHA = 0x0045,
        TLS_ECDHE_ECDSA_WITH_3DES_EDE_CBC_SHA = 0xc008,
        TLS_ECDHE_RSA_WITH_3DES_EDE_CBC_SHA = 0xc012,
        TLS_DHE_RSA_WITH_3DES_EDE_CBC_SHA = 0x0016,
        TLS_DHE_PSK_WITH_AES_256_GCM_SHA384 = 0x00ab,
        TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA384 = 0xc038,
        TLS_DHE_PSK_WITH_AES_256_CBC_SHA384 = 0x00b3,
        TLS_ECDHE_PSK_WITH_AES_256_CBC_SHA = 0xc036,
        TLS_DHE_PSK_WITH_AES_256_CBC_SHA = 0x0091,
        TLS_DHE_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xc091,
        TLS_ECDHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xc09b,
        TLS_DHE_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xc097,
        TLS_DHE_PSK_WITH_AES_128_GCM_SHA256 = 0x00aa,
        TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA256 = 0xc037,
        TLS_DHE_PSK_WITH_AES_128_CBC_SHA256 = 0x00b2,
        TLS_ECDHE_PSK_WITH_AES_128_CBC_SHA = 0xc035,
        TLS_DHE_PSK_WITH_AES_128_CBC_SHA = 0x0090,
        TLS_DHE_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xc090,
        TLS_DHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xc096,
        TLS_ECDHE_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xc09a,
        TLS_ECDHE_PSK_WITH_3DES_EDE_CBC_SHA = 0xc034,
        TLS_DHE_PSK_WITH_3DES_EDE_CBC_SHA = 0x008f,
        TLS_RSA_WITH_AES_256_GCM_SHA384 = 0x009d,
        TLS_RSA_WITH_AES_256_CBC_SHA256 = 0x003d,
        TLS_RSA_WITH_AES_256_CBC_SHA = 0x0035,
        TLS_ECDH_RSA_WITH_AES_256_GCM_SHA384 = 0xc032,
        TLS_ECDH_RSA_WITH_AES_256_CBC_SHA384 = 0xc02a,
        TLS_ECDH_RSA_WITH_AES_256_CBC_SHA = 0xc00f,
        TLS_ECDH_ECDSA_WITH_AES_256_GCM_SHA384 = 0xc02e,
        TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA384 = 0xc026,
        TLS_ECDH_ECDSA_WITH_AES_256_CBC_SHA = 0xc005,
        TLS_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc07b,
        TLS_RSA_WITH_CAMELLIA_256_CBC_SHA256 = 0x00c0,
        TLS_RSA_WITH_CAMELLIA_256_CBC_SHA = 0x0084,
        TLS_ECDH_RSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc08d,
        TLS_ECDH_RSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xc079,
        TLS_ECDH_ECDSA_WITH_CAMELLIA_256_GCM_SHA384 = 0xc089,
        TLS_ECDH_ECDSA_WITH_CAMELLIA_256_CBC_SHA384 = 0xc075,
        TLS_RSA_WITH_AES_128_GCM_SHA256 = 0x009c,
        TLS_RSA_WITH_AES_128_CBC_SHA256 = 0x003c,
        TLS_RSA_WITH_AES_128_CBC_SHA = 0x002f,
        TLS_ECDH_RSA_WITH_AES_128_GCM_SHA256 = 0xc031,
        TLS_ECDH_RSA_WITH_AES_128_CBC_SHA256 = 0xc029,
        TLS_ECDH_RSA_WITH_AES_128_CBC_SHA = 0xc00e,
        TLS_ECDH_ECDSA_WITH_AES_128_GCM_SHA256 = 0xc02d,
        TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA256 = 0xc025,
        TLS_ECDH_ECDSA_WITH_AES_128_CBC_SHA = 0xc004,
        TLS_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc07a,
        TLS_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0x00ba,
        TLS_RSA_WITH_CAMELLIA_128_CBC_SHA = 0x0041,
        TLS_ECDH_RSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc08c,
        TLS_ECDH_RSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xc078,
        TLS_ECDH_ECDSA_WITH_CAMELLIA_128_GCM_SHA256 = 0xc088,
        TLS_ECDH_ECDSA_WITH_CAMELLIA_128_CBC_SHA256 = 0xc074,
        TLS_RSA_WITH_3DES_EDE_CBC_SHA = 0x000a,
        TLS_ECDH_RSA_WITH_3DES_EDE_CBC_SHA = 0xc00d,
        TLS_ECDH_ECDSA_WITH_3DES_EDE_CBC_SHA = 0xc003,
        TLS_RSA_PSK_WITH_AES_256_GCM_SHA384 = 0x00ad,
        TLS_RSA_PSK_WITH_AES_256_CBC_SHA384 = 0x00b7,
        TLS_RSA_PSK_WITH_AES_256_CBC_SHA = 0x0095,
        TLS_RSA_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xc093,
        TLS_RSA_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xc099,
        TLS_RSA_PSK_WITH_AES_128_GCM_SHA256 = 0x00ac,
        TLS_RSA_PSK_WITH_AES_128_CBC_SHA256 = 0x00b6,
        TLS_RSA_PSK_WITH_AES_128_CBC_SHA = 0x0094,
        TLS_RSA_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xc092,
        TLS_RSA_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xc098,
        TLS_RSA_PSK_WITH_3DES_EDE_CBC_SHA = 0x0093,
        TLS_PSK_WITH_AES_256_GCM_SHA384 = 0x00a9,
        TLS_PSK_WITH_AES_256_CBC_SHA384 = 0x00af,
        TLS_PSK_WITH_AES_256_CBC_SHA = 0x008d,
        TLS_PSK_WITH_CAMELLIA_256_GCM_SHA384 = 0xc08f,
        TLS_PSK_WITH_CAMELLIA_256_CBC_SHA384 = 0xc095,
        TLS_PSK_WITH_AES_128_GCM_SHA256 = 0x00a8,
        TLS_PSK_WITH_AES_128_CBC_SHA256 = 0x00ae,
        TLS_PSK_WITH_AES_128_CBC_SHA = 0x008c,
        TLS_PSK_WITH_CAMELLIA_128_GCM_SHA256 = 0xc08e,
        TLS_PSK_WITH_CAMELLIA_128_CBC_SHA256 = 0xc094,
        TLS_PSK_WITH_3DES_EDE_CBC_SHA = 0x008b,
        TLS_ECDHE_ECDSA_WITH_RC4_128_SHA = 0xc007,
        TLS_ECDHE_RSA_WITH_RC4_128_SHA = 0xc011,
        TLS_ECDHE_PSK_WITH_RC4_128_SHA = 0xc033,
        TLS_DHE_PSK_WITH_RC4_128_SHA = 0x008e,
        TLS_RSA_WITH_RC4_128_SHA = 0x0005,
        TLS_RSA_WITH_RC4_128_MD5 = 0x0004,
        TLS_ECDH_RSA_WITH_RC4_128_SHA = 0xc00c,
        TLS_ECDH_ECDSA_WITH_RC4_128_SHA = 0xc002,
        TLS_RSA_PSK_WITH_RC4_128_SHA = 0x0092,
        TLS_PSK_WITH_RC4_128_SHA = 0x008a,
    }
}
