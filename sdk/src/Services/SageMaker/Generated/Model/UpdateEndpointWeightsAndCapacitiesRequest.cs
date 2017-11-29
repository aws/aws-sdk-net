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
    /// Container for the parameters to the UpdateEndpointWeightsAndCapacities operation.
    /// Updates variant weight, capacity, or both of one or more variants associated with
    /// an endpoint. This operation updates weight, capacity, or both for the previously provisioned
    /// endpoint. When it receives the request, Amazon SageMaker sets the endpoint status
    /// to <code>Updating</code>. After updating the endpoint, it sets the status to <code>InService</code>.
    /// To check the status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
    /// API.
    /// </summary>
    public partial class UpdateEndpointWeightsAndCapacitiesRequest : AmazonSageMakerRequest
    {
        private List<DesiredWeightAndCapacity> _desiredWeightsAndCapacities = new List<DesiredWeightAndCapacity>();
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property DesiredWeightsAndCapacities. 
        /// <para>
        /// An object that provides new capacity and weight values for a variant.
        /// </para>
        /// </summary>
        public List<DesiredWeightAndCapacity> DesiredWeightsAndCapacities
        {
            get { return this._desiredWeightsAndCapacities; }
            set { this._desiredWeightsAndCapacities = value; }
        }

        // Check to see if DesiredWeightsAndCapacities property is set
        internal bool IsSetDesiredWeightsAndCapacities()
        {
            return this._desiredWeightsAndCapacities != null && this._desiredWeightsAndCapacities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an existing Amazon SageMaker endpoint.
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

    }
}