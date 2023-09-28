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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the ListFoundationModels operation.
    /// List of Bedrock foundation models that you can use. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/foundation-models.html">Foundation
    /// models</a> in the Bedrock User Guide.
    /// </summary>
    public partial class ListFoundationModelsRequest : AmazonBedrockRequest
    {
        private ModelCustomization _byCustomizationType;
        private InferenceType _byInferenceType;
        private ModelModality _byOutputModality;
        private string _byProvider;

        /// <summary>
        /// Gets and sets the property ByCustomizationType. 
        /// <para>
        /// List by customization type.
        /// </para>
        /// </summary>
        public ModelCustomization ByCustomizationType
        {
            get { return this._byCustomizationType; }
            set { this._byCustomizationType = value; }
        }

        // Check to see if ByCustomizationType property is set
        internal bool IsSetByCustomizationType()
        {
            return this._byCustomizationType != null;
        }

        /// <summary>
        /// Gets and sets the property ByInferenceType. 
        /// <para>
        /// List by inference type.
        /// </para>
        /// </summary>
        public InferenceType ByInferenceType
        {
            get { return this._byInferenceType; }
            set { this._byInferenceType = value; }
        }

        // Check to see if ByInferenceType property is set
        internal bool IsSetByInferenceType()
        {
            return this._byInferenceType != null;
        }

        /// <summary>
        /// Gets and sets the property ByOutputModality. 
        /// <para>
        /// List by output modality type.
        /// </para>
        /// </summary>
        public ModelModality ByOutputModality
        {
            get { return this._byOutputModality; }
            set { this._byOutputModality = value; }
        }

        // Check to see if ByOutputModality property is set
        internal bool IsSetByOutputModality()
        {
            return this._byOutputModality != null;
        }

        /// <summary>
        /// Gets and sets the property ByProvider. 
        /// <para>
        /// A Bedrock model provider.
        /// </para>
        /// </summary>
        public string ByProvider
        {
            get { return this._byProvider; }
            set { this._byProvider = value; }
        }

        // Check to see if ByProvider property is set
        internal bool IsSetByProvider()
        {
            return this._byProvider != null;
        }

    }
}