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
    /// Container for the parameters to the UpdateSubscriptionGrantStatus operation.
    /// Updates the status of the specified subscription grant status in Amazon DataZone.
    /// </summary>
    public partial class UpdateSubscriptionGrantStatusRequest : AmazonDataZoneRequest
    {
        private string _assetIdentifier;
        private string _domainIdentifier;
        private FailureCause _failureCause;
        private string _identifier;
        private SubscriptionGrantStatus _status;
        private string _targetName;

        /// <summary>
        /// Gets and sets the property AssetIdentifier. 
        /// <para>
        /// The identifier of the asset the subscription grant status of which is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssetIdentifier
        {
            get { return this._assetIdentifier; }
            set { this._assetIdentifier = value; }
        }

        // Check to see if AssetIdentifier property is set
        internal bool IsSetAssetIdentifier()
        {
            return this._assetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon DataZone domain in which a subscription grant status
        /// is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCause. 
        /// <para>
        /// Specifies the error message that is returned if the operation cannot be successfully
        /// completed.
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
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The identifier of the subscription grant the status of which is to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to be updated as part of the <c>UpdateSubscriptionGrantStatus</c> action.
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
        /// The target name to be updated as part of the <c>UpdateSubscriptionGrantStatus</c>
        /// action.
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