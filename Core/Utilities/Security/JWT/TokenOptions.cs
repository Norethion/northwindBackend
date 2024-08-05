﻿namespace Core.Utilities.Security.JWT
{
    public class TokenOptions
    {
        public string Issuer { get; set; }//imzalayan
        public string Audience { get; set; }
        public string SecurityKey { get; set; }
        public int AccessTokenExpiration { get; set; }
    }
}
