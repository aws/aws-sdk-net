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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the BatchUpdateExclusionWindows operation. Add or
    /// remove time window exclusions for one or more Service Level Objectives (SLOs).
    /// </summary>
    public partial class BatchUpdateExclusionWindowsRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property AddExclusionWindows. 
        /// <para>
        /// A list of exclusion windows to add to the specified SLOs. You can add up to 10 exclusion
        /// windows per SLO.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<ExclusionWindow> AddExclusionWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<ExclusionWindow>() : null;

        /// <summary>
        /// Checks to see if the AddExclusionWindows property is set.
        /// </summary>
        internal bool IsSetAddExclusionWindows() => this.AddExclusionWindows != null && (this.AddExclusionWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemoveExclusionWindows. 
        /// <para>
        /// A list of exclusion windows to remove from the specified SLOs. The window configuration
        /// must match an existing exclusion window.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 10)]
        public List<ExclusionWindow> RemoveExclusionWindows { get; set; } = AWSConfigs.InitializeCollections ? new List<ExclusionWindow>() : null;

        /// <summary>
        /// Checks to see if the RemoveExclusionWindows property is set.
        /// </summary>
        internal bool IsSetRemoveExclusionWindows() => this.RemoveExclusionWindows != null && (this.RemoveExclusionWindows.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SloIds. 
        /// <para>
        /// The list of SLO IDs to add or remove exclusion windows from.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> SloIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SloIds property is set.
        /// </summary>
        internal bool IsSetSloIds() => this.SloIds != null && (this.SloIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
