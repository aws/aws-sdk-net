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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Shows which variant is a production variant and which variant is a shadow variant.
    /// For shadow variants, also shows the sampling percentages.
    /// </summary>
    public partial class ShadowModeConfig
    {
        private List<ShadowModelVariantConfig> _shadowModelVariants = new List<ShadowModelVariantConfig>();
        private string _sourceModelVariantName;

        /// <summary>
        /// Gets and sets the property ShadowModelVariants. 
        /// <para>
        /// List of shadow variant configurations.
        /// </para>
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
            return this._shadowModelVariants != null && this._shadowModelVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceModelVariantName. 
        /// <para>
        ///  The name of the production variant. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
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