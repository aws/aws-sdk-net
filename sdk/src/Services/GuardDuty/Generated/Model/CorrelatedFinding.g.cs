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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about a group of correlated findings that have the same finding
    /// type.
    /// </summary>
    public partial class CorrelatedFinding
    {
        /// <summary>
        /// Gets and sets the property CorrelationReasons. 
        /// <para>
        /// The reasons why GuardDuty correlated the findings. Possible values are <c>HIGH_SEVERITY</c>,
        /// <c>SAME_RESOURCE</c>, and <c>SAME_BEHAVIOR</c>. A value can appear more than once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> CorrelationReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the CorrelationReasons property is set.
        /// </summary>
        internal bool IsSetCorrelationReasons() => this.CorrelationReasons != null && (this.CorrelationReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of correlated findings of this type. This value can be greater than the
        /// number of IDs in <c>FindingIds</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property FindingIds. 
        /// <para>
        /// A sample of the IDs of the findings in the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> FindingIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FindingIds property is set.
        /// </summary>
        internal bool IsSetFindingIds() => this.FindingIds != null && (this.FindingIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FindingType. 
        /// <para>
        /// The finding type of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string FindingType { get; set; }

        /// <summary>
        /// Checks to see if the FindingType property is set.
        /// </summary>
        internal bool IsSetFindingType() => this.FindingType != null;

        /// <summary>
        /// Gets and sets the property SeverityMax. 
        /// <para>
        /// The highest severity score among the findings in the group, from 0 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public double? SeverityMax { get; set; }

        /// <summary>
        /// Checks to see if the SeverityMax property is set.
        /// </summary>
        internal bool IsSetSeverityMax() => this.SeverityMax.HasValue;

        /// <summary>
        /// Gets and sets the property SharedBehaviors. 
        /// <para>
        /// The behaviors that the findings in the group share with the investigated activity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<SharedBehavior> SharedBehaviors { get; set; } = AWSConfigs.InitializeCollections ? new List<SharedBehavior>() : null;

        /// <summary>
        /// Checks to see if the SharedBehaviors property is set.
        /// </summary>
        internal bool IsSetSharedBehaviors() => this.SharedBehaviors != null && (this.SharedBehaviors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SharedResources. 
        /// <para>
        /// The resources that the findings in the group share with the investigated activity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 20)]
        public List<SharedResource> SharedResources { get; set; } = AWSConfigs.InitializeCollections ? new List<SharedResource>() : null;

        /// <summary>
        /// Checks to see if the SharedResources property is set.
        /// </summary>
        internal bool IsSetSharedResources() => this.SharedResources != null && (this.SharedResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
