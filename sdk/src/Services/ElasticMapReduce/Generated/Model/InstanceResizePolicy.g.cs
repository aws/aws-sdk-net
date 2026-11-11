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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Custom policy for requesting termination protection or termination of specific instances
    /// when shrinking an instance group.
    /// </summary>
    public partial class InstanceResizePolicy
    {
        /// <summary>
        /// Gets and sets the property InstanceTerminationTimeout. 
        /// <para>
        /// Decommissioning timeout override for the specific list of instances to be terminated.
        /// </para>
        /// </summary>
        public int? InstanceTerminationTimeout { get; set; }

        /// <summary>
        /// Checks to see if the InstanceTerminationTimeout property is set.
        /// </summary>
        internal bool IsSetInstanceTerminationTimeout() => this.InstanceTerminationTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property InstancesToProtect. 
        /// <para>
        /// Specific list of instances to be protected when shrinking an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstancesToProtect { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstancesToProtect property is set.
        /// </summary>
        internal bool IsSetInstancesToProtect() => this.InstancesToProtect != null && (this.InstancesToProtect.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstancesToTerminate. 
        /// <para>
        /// Specific list of instances to be terminated when shrinking an instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InstancesToTerminate { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InstancesToTerminate property is set.
        /// </summary>
        internal bool IsSetInstancesToTerminate() => this.InstancesToTerminate != null && (this.InstancesToTerminate.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
