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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Blueprint Recommendation Sample
    /// </summary>
    public partial class BlueprintOptimizationSample
    {
        private S3Object _assets3Object;
        private S3Object _groundTruthS3Object;

        /// <summary>
        /// Gets and sets the property AssetS3Object. 
        /// <para>
        /// S3 Object of the asset
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Object AssetS3Object
        {
            get { return this._assets3Object; }
            set { this._assets3Object = value; }
        }

        // Check to see if AssetS3Object property is set
        internal bool IsSetAssetS3Object()
        {
            return this._assets3Object != null;
        }

        /// <summary>
        /// Gets and sets the property GroundTruthS3Object. 
        /// <para>
        /// Ground truth for the Blueprint and Asset combination
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Object GroundTruthS3Object
        {
            get { return this._groundTruthS3Object; }
            set { this._groundTruthS3Object = value; }
        }

        // Check to see if GroundTruthS3Object property is set
        internal bool IsSetGroundTruthS3Object()
        {
            return this._groundTruthS3Object != null;
        }

    }
}