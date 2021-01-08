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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// The value associated with a feature.
    /// </summary>
    public partial class FeatureValue
    {
        private string _featureName;
        private string _valueAsString;

        /// <summary>
        /// Gets and sets the property FeatureName. 
        /// <para>
        /// The name of a feature that a feature value corresponds to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string FeatureName
        {
            get { return this._featureName; }
            set { this._featureName = value; }
        }

        // Check to see if FeatureName property is set
        internal bool IsSetFeatureName()
        {
            return this._featureName != null;
        }

        /// <summary>
        /// Gets and sets the property ValueAsString. 
        /// <para>
        /// The value associated with a feature, in string format. Note that features types can
        /// be String, Integral, or Fractional. This value represents all three types as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=358400)]
        public string ValueAsString
        {
            get { return this._valueAsString; }
            set { this._valueAsString = value; }
        }

        // Check to see if ValueAsString property is set
        internal bool IsSetValueAsString()
        {
            return this._valueAsString != null;
        }

    }
}