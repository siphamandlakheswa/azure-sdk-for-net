// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Standard Apache Lucene analyzer; Composed of the standard tokenizer, lowercase filter and stop filter. </summary>
    public partial class LuceneStandardAnalyzer : LexicalAnalyzer
    {
        /// <summary> Initializes a new instance of LuceneStandardAnalyzer. </summary>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public LuceneStandardAnalyzer(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Stopwords = new ChangeTrackingList<string>();
            ODataType = "#Microsoft.Azure.Search.StandardAnalyzer";
        }

        /// <summary> Initializes a new instance of LuceneStandardAnalyzer. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the analyzer. </param>
        /// <param name="name"> The name of the analyzer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="maxTokenLength"> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </param>
        /// <param name="stopwords"> A list of stopwords. </param>
        internal LuceneStandardAnalyzer(string oDataType, string name, int? maxTokenLength, IList<string> stopwords) : base(oDataType, name)
        {
            MaxTokenLength = maxTokenLength;
            Stopwords = stopwords;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.StandardAnalyzer";
        }

        /// <summary> The maximum token length. Default is 255. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </summary>
        public int? MaxTokenLength { get; set; }
    }
}
