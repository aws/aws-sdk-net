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
    /// Contains information about findings that are related to the investigated activity.
    /// </summary>
    public partial class RelatedFindings
    {
        /// <summary>
        /// Gets and sets the property Correlated. 
        /// <para>
        /// The findings that GuardDuty correlated with the investigated activity, grouped by
        /// finding type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 8)]
        public List<CorrelatedFinding> Correlated { get; set; } = AWSConfigs.InitializeCollections ? new List<CorrelatedFinding>() : null;

        /// <summary>
        /// Checks to see if the Correlated property is set.
        /// </summary>
        internal bool IsSetCorrelated() => this.Correlated != null && (this.Correlated.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Observed. 
        /// <para>
        /// Other finding types that GuardDuty observed, with counts. These entries don't include
        /// finding IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ObservedFindingType> Observed { get; set; } = AWSConfigs.InitializeCollections ? new List<ObservedFindingType>() : null;

        /// <summary>
        /// Checks to see if the Observed property is set.
        /// </summary>
        internal bool IsSetObserved() => this.Observed != null && (this.Observed.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
