/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// If provided, the generated manifest includes only source bucket objects whose object
    /// keys match the string constraints specified for <c>MatchAnyPrefix</c>, <c>MatchAnySuffix</c>,
    /// and <c>MatchAnySubstring</c>.
    /// </summary>
    public partial class KeyNameConstraint
    {
        /// <summary>
        /// Gets and sets the property MatchAnyPrefix. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// at the start of the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnyPrefix { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnyPrefix property is set.
        /// </summary>
        internal bool IsSetMatchAnyPrefix() => this.MatchAnyPrefix != null && (this.MatchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchAnySubstring. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// anywhere within the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySubstring { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnySubstring property is set.
        /// </summary>
        internal bool IsSetMatchAnySubstring() => this.MatchAnySubstring != null && (this.MatchAnySubstring.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchAnySuffix. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// at the end of the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySuffix { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnySuffix property is set.
        /// </summary>
        internal bool IsSetMatchAnySuffix() => this.MatchAnySuffix != null && (this.MatchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
