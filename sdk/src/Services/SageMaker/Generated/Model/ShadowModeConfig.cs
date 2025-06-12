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
    /// The configuration of <c>ShadowMode</c> inference experiment type, which specifies
    /// a production variant to take all the inference requests, and a shadow variant to which
    /// Amazon SageMaker replicates a percentage of the inference requests. For the shadow
    /// variant it also specifies the percentage of requests that Amazon SageMaker replicates.
    /// </summary>
    public partial class ShadowModeConfig
    {
        private List<ShadowModelVariantConfig> _shadowModelVariants = AWSConfigs.InitializeCollections ? new List<ShadowModelVariantConfig>() : null;
        private string _sourceModelVariantName;

        /// <summary>
        /// Gets and sets the property ShadowModelVariants. 
        /// <para>
        /// List of shadow variant configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<ShadowModelVariantConfig> ShadowModelVariants
        {
            get { return this._shadowModelVariants; }
            set { this._shadowModelVariants = value; }
        }

        // Check to see if ShadowModelVariants property is set
        internal bool IsSetShadowModelVariants()
        {
            return this._shadowModelVariants != null && (this._shadowModelVariants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceModelVariantName. 
        /// <para>
        ///  The name of the production variant, which takes all the inference requests. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
        public string SourceModelVariantName
        {
            get { return this._sourceModelVariantName; }
            set { this._sourceModelVariantName = value; }
        }

        // Check to see if SourceModelVariantName property is set
        internal bool IsSetSourceModelVariantName()
        {
            return this._sourceModelVariantName != null;
        }

    }
}