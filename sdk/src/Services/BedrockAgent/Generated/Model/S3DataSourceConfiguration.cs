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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Configures an S3 data source location.
    /// </summary>
    public partial class S3DataSourceConfiguration
    {
        private string _bucketArn;
        private List<string> _inclusionPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BucketArn.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BucketArn
        {
            get { return this._bucketArn; }
            set { this._bucketArn = value; }
        }

        // Check to see if BucketArn property is set
        internal bool IsSetBucketArn()
        {
            return this._bucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property InclusionPrefixes.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> InclusionPrefixes
        {
            get { return this._inclusionPrefixes; }
            set { this._inclusionPrefixes = value; }
        }

        // Check to see if InclusionPrefixes property is set
        internal bool IsSetInclusionPrefixes()
        {
            return this._inclusionPrefixes != null && (this._inclusionPrefixes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}