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
    /// Specifies a production variant property type for an Endpoint.
    /// 
    ///  
    /// <para>
    /// If you are updating an endpoint with the <a>UpdateEndpointInput$RetainAllVariantProperties</a>
    /// option set to <code>true</code>, the <code>VariantProperty</code> objects listed in
    /// <a>UpdateEndpointInput$ExcludeRetainedVariantProperties</a> override the existing
    /// variant properties of the endpoint.
    /// </para>
    /// </summary>
    public partial class VariantProperty
    {
        private VariantPropertyType _variantPropertyType;

        /// <summary>
        /// Gets and sets the property VariantPropertyType. 
        /// <para>
        /// The type of variant property. The supported values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>DesiredInstanceCount</code>: Overrides the existing variant instance counts
        /// using the <a>ProductionVariant$InitialInstanceCount</a> values in the <a>CreateEndpointConfigInput$ProductionVariants</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DesiredWeight</code>: Overrides the existing variant weights using the <a>ProductionVariant$InitialVariantWeight</a>
        /// values in the <a>CreateEndpointConfigInput$ProductionVariants</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DataCaptureConfig</code>: (Not currently supported.)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public VariantPropertyType VariantPropertyType
        {
            get { return this._variantPropertyType; }
            set { this._variantPropertyType = value; }
        }

        // Check to see if VariantPropertyType property is set
        internal bool IsSetVariantPropertyType()
        {
            return this._variantPropertyType != null;
        }

    }
}