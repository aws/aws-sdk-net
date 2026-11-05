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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Represents an individual contributor to a multi-timeseries alarm, containing information
    /// about a specific time series and its contribution to the alarm's state.
    /// </summary>
    public partial class AlarmContributor
    {
        /// <summary>
        /// Gets and sets the property ContributorAttributes. 
        /// <para>
        /// A map of attributes that describe the contributor, such as metric dimensions and other
        /// identifying characteristics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 150)]
        public Dictionary<string, string> ContributorAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ContributorAttributes property is set.
        /// </summary>
        internal bool IsSetContributorAttributes() => this.ContributorAttributes != null && (this.ContributorAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ContributorId. 
        /// <para>
        /// The unique identifier for this alarm contributor.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 16)]
        public string ContributorId { get; set; }

        /// <summary>
        /// Checks to see if the ContributorId property is set.
        /// </summary>
        internal bool IsSetContributorId() => this.ContributorId != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// An explanation for the contributor's current state, providing context about why it
        /// is in its current condition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1023)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property StateTransitionedTimestamp. 
        /// <para>
        /// The timestamp when the contributor last transitioned to its current state.
        /// </para>
        /// </summary>
        public DateTime? StateTransitionedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the StateTransitionedTimestamp property is set.
        /// </summary>
        internal bool IsSetStateTransitionedTimestamp() => this.StateTransitionedTimestamp.HasValue;
    }
}
