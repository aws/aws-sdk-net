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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServiceEnvironment operation.
    /// Updates a service environment. You can update the state of a service environment from
    /// <c>ENABLED</c> to <c>DISABLED</c> to prevent new service jobs from being placed in
    /// the service environment.
    /// </summary>
    public partial class UpdateServiceEnvironmentRequest : AmazonBatchRequest
    {
        private List<CapacityLimit> _capacityLimits = AWSConfigs.InitializeCollections ? new List<CapacityLimit>() : null;
        private string _serviceEnvironment;
        private ServiceEnvironmentState _state;

        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the service environment. This defines the maximum resources
        /// that can be used by service jobs in this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityLimit> CapacityLimits
        {
            get { return this._capacityLimits; }
            set { this._capacityLimits = value; }
        }

        // Check to see if CapacityLimits property is set
        internal bool IsSetCapacityLimits()
        {
            return this._capacityLimits != null && (this._capacityLimits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ServiceEnvironment. 
        /// <para>
        /// The name or ARN of the service environment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ServiceEnvironment
        {
            get { return this._serviceEnvironment; }
            set { this._serviceEnvironment = value; }
        }

        // Check to see if ServiceEnvironment property is set
        internal bool IsSetServiceEnvironment()
        {
            return this._serviceEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the service environment. 
        /// </para>
        /// </summary>
        public ServiceEnvironmentState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}