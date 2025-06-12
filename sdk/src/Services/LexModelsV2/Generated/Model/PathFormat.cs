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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The object that contains a path format that will be applied when Amazon Lex reads
    /// the transcript file in the bucket you provide. Specify this object if you only want
    /// Lex to read a subset of files in your Amazon S3 bucket.
    /// </summary>
    public partial class PathFormat
    {
        private List<string> _objectPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ObjectPrefixes. 
        /// <para>
        /// A list of Amazon S3 prefixes that points to sub-folders in the Amazon S3 bucket. Specify
        /// this list if you only want Lex to read the files under this set of sub-folders.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<string> ObjectPrefixes
        {
            get { return this._objectPrefixes; }
            set { this._objectPrefixes = value; }
        }

        // Check to see if ObjectPrefixes property is set
        internal bool IsSetObjectPrefixes()
        {
            return this._objectPrefixes != null && (this._objectPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}