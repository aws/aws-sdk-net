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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
        private List<string> _matchAnyPrefix = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _matchAnySubstring = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _matchAnySuffix = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property MatchAnyPrefix. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// at the start of the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnyPrefix
        {
            get { return this._matchAnyPrefix; }
            set { this._matchAnyPrefix = value; }
        }

        // Check to see if MatchAnyPrefix property is set
        internal bool IsSetMatchAnyPrefix()
        {
            return this._matchAnyPrefix != null && (this._matchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchAnySubstring. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// anywhere within the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySubstring
        {
            get { return this._matchAnySubstring; }
            set { this._matchAnySubstring = value; }
        }

        // Check to see if MatchAnySubstring property is set
        internal bool IsSetMatchAnySubstring()
        {
            return this._matchAnySubstring != null && (this._matchAnySubstring.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MatchAnySuffix. 
        /// <para>
        /// If provided, the generated manifest includes objects where the specified string appears
        /// at the end of the object key string. Each KeyNameConstraint filter accepts an array
        /// of strings with a length of 1 string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySuffix
        {
            get { return this._matchAnySuffix; }
            set { this._matchAnySuffix = value; }
        }

        // Check to see if MatchAnySuffix property is set
        internal bool IsSetMatchAnySuffix()
        {
            return this._matchAnySuffix != null && (this._matchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}