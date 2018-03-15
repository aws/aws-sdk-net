/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Describes weight and capacities for a production variant associated with an endpoint.
    /// If you sent a request to the <code>UpdateEndpointWeightsAndCapacities</code> API and
    /// the endpoint status is <code>Updating</code>, you get different desired and current
    /// values.
    /// </summary>
    public partial class ProductionVariantSummary
    {
        private int? _currentInstanceCount;
        private float? _currentWeight;
        private int? _desiredInstanceCount;
        private float? _desiredWeight;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property CurrentInstanceCount. 
        /// <para>
        /// The number of instances associated with the variant.
        /// </para>
        /// </summary>
        public int CurrentInstanceCount
        {
            get { return this._currentInstanceCount.GetValueOrDefault(); }
            set { this._currentInstanceCount = value; }
        }

        // Check to see if CurrentInstanceCount property is set
        internal bool IsSetCurrentInstanceCount()
        {
            return this._currentInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CurrentWeight. 
        /// <para>
        /// The weight associated with the variant.
        /// </para>
        /// </summary>
        public float CurrentWeight
        {
            get { return this._currentWeight.GetValueOrDefault(); }
            set { this._currentWeight = value; }
        }

        // Check to see if CurrentWeight property is set
        internal bool IsSetCurrentWeight()
        {
            return this._currentWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredInstanceCount. 
        /// <para>
        /// The number of instances requested in the <code>UpdateEndpointWeightsAndCapacities</code>
        /// request. 
        /// </para>
        /// </summary>
        public int DesiredInstanceCount
        {
            get { return this._desiredInstanceCount.GetValueOrDefault(); }
            set { this._desiredInstanceCount = value; }
        }

        // Check to see if DesiredInstanceCount property is set
        internal bool IsSetDesiredInstanceCount()
        {
            return this._desiredInstanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredWeight. 
        /// <para>
        /// The requested weight, as specified in the <code>UpdateEndpointWeightsAndCapacities</code>
        /// request. 
        /// </para>
        /// </summary>
        public float DesiredWeight
        {
            get { return this._desiredWeight.GetValueOrDefault(); }
            set { this._desiredWeight = value; }
        }

        // Check to see if DesiredWeight property is set
        internal bool IsSetDesiredWeight()
        {
            return this._desiredWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant.
        /// </para>
        /// </summary>
        public string VariantName
        {
            get { return this._variantName; }
            set { this._variantName = value; }
        }

        // Check to see if VariantName property is set
        internal bool IsSetVariantName()
        {
            return this._variantName != null;
        }

    }
}