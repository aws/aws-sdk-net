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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private string _assetId;
        private string _assetRevision;
        private AssetScope _assetScope;
        private FailureCause _failureCause;
        private DateTime? _failureTimestamp;
        private DateTime? _grantedTimestamp;
        private SubscriptionGrantStatus _status;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The identifier of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetRevision. 
        /// <para>
        /// The revision of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string AssetRevision
        {
            get { return this._assetRevision; }
            set { this._assetRevision = value; }
        }

        // Check to see if AssetRevision property is set
        internal bool IsSetAssetRevision()
        {
            return this._assetRevision != null;
        }

        /// <summary>
        /// Gets and sets the property AssetScope. 
        /// <para>
        /// The asset scope of the subscribed asset.
        /// </para>
        /// </summary>
        public AssetScope AssetScope
        {
            get { return this._assetScope; }
            set { this._assetScope = value; }
        }

        // Check to see if AssetScope property is set
        internal bool IsSetAssetScope()
        {
            return this._assetScope != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// The failure cause included in the details of the asset for which the subscription
        /// grant is created.
        /// </para>
        /// </summary>
        public FailureCause FailureCause
        {
            get { return this._failureCause; }
            set { this._failureCause = value; }
        }

        // Check to see if FailureCause property is set
        internal bool IsSetFailureCause()
        {
            return this._failureCause != null;
        }

        /// <summary>
        /// Gets and sets the property FailureTimestamp. 
        /// <para>
        /// The failure timestamp included in the details of the asset for which the subscription
        /// grant is created.
        /// </para>
        /// </summary>
        public DateTime? FailureTimestamp
        {
            get { return this._failureTimestamp; }
            set { this._failureTimestamp = value; }
        }

        // Check to see if FailureTimestamp property is set
        internal bool IsSetFailureTimestamp()
        {
            return this._failureTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GrantedTimestamp. 
        /// <para>
        /// The timestamp of when the subscription grant to the asset is created.
        /// </para>
        /// </summary>
        public DateTime? GrantedTimestamp
        {
            get { return this._grantedTimestamp; }
            set { this._grantedTimestamp = value; }
        }

        // Check to see if GrantedTimestamp property is set
        internal bool IsSetGrantedTimestamp()
        {
            return this._grantedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SubscriptionGrantStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TargetName. 
        /// <para>
        /// The target name of the asset for which the subscription grant is created.
        /// </para>
        /// </summary>
        public string TargetName
        {
            get { return this._targetName; }
            set { this._targetName = value; }
        }

        // Check to see if TargetName property is set
        internal bool IsSetTargetName()
        {
            return this._targetName != null;
        }

    }
}