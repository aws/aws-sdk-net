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
    /// The summary of an in-progress deployment when an endpoint is creating or updating
    /// with a new endpoint configuration.
    /// </summary>
    public partial class PendingDeploymentSummary
    {
        private string _endpointConfigName;
        private List<PendingProductionVariantSummary> _productionVariants = new List<PendingProductionVariantSummary>();
        private List<PendingProductionVariantSummary> _shadowProductionVariants = new List<PendingProductionVariantSummary>();
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property EndpointConfigName. 
        /// <para>
        /// The name of the endpoint configuration used in the deployment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=63)]
        public string EndpointConfigName
        {
            get { return this._endpointConfigName; }
            set { this._endpointConfigName = value; }
        }

        // Check to see if EndpointConfigName property is set
        internal bool IsSetEndpointConfigName()
        {
            return this._endpointConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property ProductionVariants. 
        /// <para>
        /// List of <code>PendingProductionVariantSummary</code> objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<PendingProductionVariantSummary> ProductionVariants
        {
            get { return this._productionVariants; }
            set { this._productionVariants = value; }
        }

        // Check to see if ProductionVariants property is set
        internal bool IsSetProductionVariants()
        {
            return this._productionVariants != null && this._productionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ShadowProductionVariants. 
        /// <para>
        ///  Array of <code>ProductionVariant</code> objects, one for each model that you want
        /// to host at this endpoint in shadow mode with production traffic replicated from the
        /// model specified on <code>ProductionVariants</code>.If you use this field, you can
        /// only specify one variant for <code>ProductionVariants</code> and one variant for <code>ShadowProductionVariants</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<PendingProductionVariantSummary> ShadowProductionVariants
        {
            get { return this._shadowProductionVariants; }
            set { this._shadowProductionVariants = value; }
        }

        // Check to see if ShadowProductionVariants property is set
        internal bool IsSetShadowProductionVariants()
        {
            return this._shadowProductionVariants != null && this._shadowProductionVariants.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the deployment.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}