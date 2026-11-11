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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about which channels are supported, and how many contacts an
    /// agent can have on a channel simultaneously.
    /// </summary>
    public partial class MediaConcurrency
    {
        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The channels that agents can handle in the Contact Control Panel (CCP).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Channel Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property Concurrency. 
        /// <para>
        /// The number of contacts an agent can have on a channel simultaneously.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>VOICE</c>: Minimum value of 1. Maximum value of 1.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>CHAT</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        ///  
        /// <para>
        /// Valid Range for <c>TASK</c>: Minimum value of 1. Maximum value of 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? Concurrency { get; set; }

        /// <summary>
        /// Checks to see if the Concurrency property is set.
        /// </summary>
        internal bool IsSetConcurrency() => this.Concurrency.HasValue;

        /// <summary>
        /// Gets and sets the property CrossChannelBehavior. 
        /// <para>
        /// Defines the cross-channel routing behavior for each channel that is enabled for this
        /// Routing Profile. For example, this allows you to offer an agent a different contact
        /// from another channel when they are currently working with a contact from a Voice channel.
        /// </para>
        /// </summary>
        public CrossChannelBehavior CrossChannelBehavior { get; set; }

        /// <summary>
        /// Checks to see if the CrossChannelBehavior property is set.
        /// </summary>
        internal bool IsSetCrossChannelBehavior() => this.CrossChannelBehavior != null;

        /// <summary>
        /// Gets and sets the property WorkloadTypeConcurrencies. 
        /// <para>
        /// Defines the list of workload type concurrency configurations for a channel. When provided,
        /// enables granular concurrency control based on workload type values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<WorkloadTypeConcurrency> WorkloadTypeConcurrencies { get; set; } = AWSConfigs.InitializeCollections ? new List<WorkloadTypeConcurrency>() : null;

        /// <summary>
        /// Checks to see if the WorkloadTypeConcurrencies property is set.
        /// </summary>
        internal bool IsSetWorkloadTypeConcurrencies() => this.WorkloadTypeConcurrencies != null && (this.WorkloadTypeConcurrencies.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
