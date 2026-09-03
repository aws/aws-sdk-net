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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateServiceEnvironment operation. Updates a
    /// service environment. You can update the state of a service environment from <c>ENABLED</c>
    /// to <c>DISABLED</c> to prevent new service jobs from being placed in the service environment.
    /// </summary>
    public partial class UpdateServiceEnvironmentRequest : AmazonBatchRequest
    {
        /// <summary>
        /// Gets and sets the property CapacityLimits. 
        /// <para>
        /// The capacity limits for the service environment. This defines the maximum resources
        /// that can be used by service jobs in this environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CapacityLimit> CapacityLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<CapacityLimit>() : null;

        /// <summary>
        /// Checks to see if the CapacityLimits property is set.
        /// </summary>
        internal bool IsSetCapacityLimits() => this.CapacityLimits != null && (this.CapacityLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ServiceEnvironment. 
        /// <para>
        /// The name or ARN of the service environment to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ServiceEnvironment { get; set; }

        /// <summary>
        /// Checks to see if the ServiceEnvironment property is set.
        /// </summary>
        internal bool IsSetServiceEnvironment() => this.ServiceEnvironment != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the service environment. 
        /// </para>
        /// </summary>
        public ServiceEnvironmentState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
