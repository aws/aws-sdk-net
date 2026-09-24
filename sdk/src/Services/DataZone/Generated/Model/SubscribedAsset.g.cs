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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the asset for which the subscription grant is created.
    /// </summary>
    public partial class SubscribedAsset
    {
        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The identifier of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetRevision. 
        /// <para>
        /// The revision of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AssetRevision { get; set; }

        /// <summary>
        /// Checks to see if the AssetRevision property is set.
        /// </summary>
        internal bool IsSetAssetRevision() => this.AssetRevision != null;

        /// <summary>
        /// Gets and sets the property AssetScope. 
        /// <para>
        /// The asset scope of the subscribed asset.
        /// </para>
        /// </summary>
        public AssetScope AssetScope { get; set; }

        /// <summary>
        /// Checks to see if the AssetScope property is set.
        /// </summary>
        internal bool IsSetAssetScope() => this.AssetScope != null;

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// The failure cause included in the details of the asset for which the subscription
        /// grant is created.
        /// </para>
        /// </summary>
        public FailureCause FailureCause { get; set; }

        /// <summary>
        /// Checks to see if the FailureCause property is set.
        /// </summary>
        internal bool IsSetFailureCause() => this.FailureCause != null;

        /// <summary>
        /// Gets and sets the property FailureTimestamp. 
        /// <para>
        /// The failure timestamp included in the details of the asset for which the subscription
        /// grant is created.
        /// </para>
        /// </summary>
        public DateTime? FailureTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the FailureTimestamp property is set.
        /// </summary>
        internal bool IsSetFailureTimestamp() => this.FailureTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property GrantedTimestamp. 
        /// <para>
        /// The timestamp of when the subscription grant to the asset is created.
        /// </para>
        /// </summary>
        public DateTime? GrantedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the GrantedTimestamp property is set.
        /// </summary>
        internal bool IsSetGrantedTimestamp() => this.GrantedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// The asset permissions.
        /// </para>
        /// </summary>
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Checks to see if the Permissions property is set.
        /// </summary>
        internal bool IsSetPermissions() => this.Permissions != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SubscriptionGrantStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The target name of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string TargetName { get; set; }

        /// <summary>
        /// Checks to see if the TargetName property is set.
        /// </summary>
        internal bool IsSetTargetName() => this.TargetName != null;
    }
}
