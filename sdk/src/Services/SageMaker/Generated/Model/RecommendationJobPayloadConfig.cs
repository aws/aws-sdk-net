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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The configuration for the payload for a recommendation job.
    /// </summary>
    public partial class RecommendationJobPayloadConfig
    {
        private string _samplePayloadUrl;
        private List<string> _supportedContentTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SamplePayloadUrl. 
        /// <para>
        /// The Amazon Simple Storage Service (Amazon S3) path where the sample payload is stored.
        /// This path must point to a single gzip compressed tar archive (.tar.gz suffix).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SamplePayloadUrl
        {
            get { return this._samplePayloadUrl; }
            set { this._samplePayloadUrl = value; }
        }

        // Check to see if SamplePayloadUrl property is set
        internal bool IsSetSamplePayloadUrl()
        {
            return this._samplePayloadUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedContentTypes. 
        /// <para>
        /// The supported MIME types for the input data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedContentTypes
        {
            get { return this._supportedContentTypes; }
            set { this._supportedContentTypes = value; }
        }

        // Check to see if SupportedContentTypes property is set
        internal bool IsSetSupportedContentTypes()
        {
            return this._supportedContentTypes != null && (this._supportedContentTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}