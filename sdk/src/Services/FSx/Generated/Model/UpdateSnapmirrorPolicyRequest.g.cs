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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSnapmirrorPolicy operation. Updates an Amazon
    /// FSx for NetApp ONTAP SnapMirror policy.
    /// </summary>
    public partial class UpdateSnapmirrorPolicyRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property NetworkCompressionEnabled. 
        /// <para>
        /// Specifies whether SnapMirror compresses data when it transfers the data over the network.
        /// </para>
        /// </summary>
        public bool? NetworkCompressionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCompressionEnabled property is set.
        /// </summary>
        internal bool IsSetNetworkCompressionEnabled() => this.NetworkCompressionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property RetentionRules. 
        /// <para>
        /// Specifies the rules that determine which snapshots SnapMirror retains on the destination
        /// volume, based on their SnapMirror labels. The rules that you specify replace all the
        /// SnapMirror policy's existing retention rules. To keep an existing rule, include it
        /// in the list. To remove all retention rules, specify an empty list.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SnapmirrorPolicyRetentionRule> RetentionRules { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapmirrorPolicyRetentionRule>() : null;

        /// <summary>
        /// Checks to see if the RetentionRules property is set.
        /// </summary>
        internal bool IsSetRetentionRules() => this.RetentionRules != null && (this.RetentionRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapmirrorPolicyId. 
        /// <para>
        /// The ID of the SnapMirror policy that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SnapmirrorPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorPolicyId property is set.
        /// </summary>
        internal bool IsSetSnapmirrorPolicyId() => this.SnapmirrorPolicyId != null;

        /// <summary>
        /// Gets and sets the property ThrottleInKbps. 
        /// <para>
        /// Specifies the maximum bandwidth, in kilobytes per second (KBps), that SnapMirror uses
        /// to transfer data. A value of <c>0</c> means that the bandwidth is unlimited.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ThrottleInKbps { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleInKbps property is set.
        /// </summary>
        internal bool IsSetThrottleInKbps() => this.ThrottleInKbps.HasValue;

        /// <summary>
        /// Gets and sets the property TransferSchedule. 
        /// <para>
        /// Specifies the name of the ONTAP schedule that determines when SnapMirror transfers
        /// data. To remove the transfer schedule, specify an empty string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransferSchedule { get; set; }

        /// <summary>
        /// Checks to see if the TransferSchedule property is set.
        /// </summary>
        internal bool IsSetTransferSchedule() => this.TransferSchedule != null;
    }
}
