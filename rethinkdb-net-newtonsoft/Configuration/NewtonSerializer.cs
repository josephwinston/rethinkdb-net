﻿using RethinkDb.DatumConverters;

namespace RethinkDb.Newtonsoft.Configuration
{
    public class NewtonSerializer : AggregateDatumConverterFactory
    {
        public NewtonSerializer() : base(
            PrimitiveDatumConverterFactory.Instance,
            TupleDatumConverterFactory.Instance,
            AnonymousTypeDatumConverterFactory.Instance,
            NewtonsoftDatumConverterFactory.Instance
            )
        {
        }
    }
}