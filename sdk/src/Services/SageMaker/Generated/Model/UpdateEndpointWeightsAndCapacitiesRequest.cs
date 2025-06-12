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
    /// Container for the parameters to the UpdateEndpointWeightsAndCapacities operation.
    /// Updates variant weight of one or more variants associated with an existing endpoint,
    /// or capacity of one variant associated with an existing endpoint. When it receives
    /// the request, SageMaker sets the endpoint status to <c>Updating</c>. After updating
    /// the endpoint, it sets the status to <c>InService</c>. To check the status of an endpoint,
    /// use the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_DescribeEndpoint.html">DescribeEndpoint</a>
    /// API.
    /// </summary>
    public partial class UpdateEndpointWeightsAndCapacitiesRequest : AmazonSageMakerRequest
    {
        private List<DesiredWeightAndCapacity> _desiredWeightsAndCapacities = AWSConfigs.InitializeCollections ? new List<DesiredWeightAndCapacity>() : null;
        private string _endpointName;

        /// <summary>
        /// Gets and sets the property DesiredWeightsAndCapacities. 
        /// <para>
        /// An object that provides new capacity and weight values for a variant.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<DesiredWeightAndCapacity> DesiredWeightsAndCapacities
        {
            get { return this._desiredWeightsAndCapacities; }
            set { this._desiredWeightsAndCapacities = value; }
        }

        // Check to see if DesiredWeightsAndCapacities property is set
        internal bool IsSetDesiredWeightsAndCapacities()
        {
            return this._desiredWeightsAndCapacities != null && (this._desiredWeightsAndCapacities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of an existing SageMaker endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=63)]
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