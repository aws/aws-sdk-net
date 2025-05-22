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
    /// Specifies weight and capacity values for a production variant.
    /// </summary>
    public partial class DesiredWeightAndCapacity
    {
        private int? _desiredInstanceCount;
        private float? _desiredWeight;
        private ProductionVariantServerlessUpdateConfig _serverlessUpdateConfig;
        private string _variantName;

        /// <summary>
        /// Gets and sets the property DesiredInstanceCount. 
        /// <para>
        /// The variant's capacity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? DesiredInstanceCount
        {
            get { return this._desiredInstanceCount; }
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
        /// The variant's weight.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public float? DesiredWeight
        {
            get { return this._desiredWeight; }
            set { this._desiredWeight = value; }
        }

        // Check to see if DesiredWeight property is set
        internal bool IsSetDesiredWeight()
        {
            return this._desiredWeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerlessUpdateConfig. 
        /// <para>
        /// Specifies the serverless update concurrency configuration for an endpoint variant.
        /// </para>
        /// </summary>
        public ProductionVariantServerlessUpdateConfig ServerlessUpdateConfig
        {
            get { return this._serverlessUpdateConfig; }
            set { this._serverlessUpdateConfig = value; }
        }

        // Check to see if ServerlessUpdateConfig property is set
        internal bool IsSetServerlessUpdateConfig()
        {
            return this._serverlessUpdateConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VariantName. 
        /// <para>
        /// The name of the variant to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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