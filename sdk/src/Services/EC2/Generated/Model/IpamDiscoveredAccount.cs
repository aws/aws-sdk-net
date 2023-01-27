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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// An IPAM discovered account. A discovered account is an Amazon Web Services account
    /// that is monitored under a resource discovery. If you have integrated IPAM with Amazon
    /// Web Services Organizations, all accounts in the organization are discovered accounts.
    /// </summary>
    public partial class IpamDiscoveredAccount
    {
        private string _accountId;
        private string _discoveryRegion;
        private IpamDiscoveryFailureReason _failureReason;
        private DateTime? _lastAttemptedDiscoveryTime;
        private DateTime? _lastSuccessfulDiscoveryTime;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID.
        /// </para>
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DiscoveryRegion. 
        /// <para>
        /// The Amazon Web Services Region that the account information is returned from. An account
        /// can be discovered in multiple regions and will have a separate discovered account
        /// for each Region.
        /// </para>
        /// </summary>
        public string DiscoveryRegion
        {
            get { return this._discoveryRegion; }
            set { this._discoveryRegion = value; }
        }

        // Check to see if DiscoveryRegion property is set
        internal bool IsSetDiscoveryRegion()
        {
            return this._discoveryRegion != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The resource discovery failure reason.
        /// </para>
        /// </summary>
        public IpamDiscoveryFailureReason FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property LastAttemptedDiscoveryTime. 
        /// <para>
        /// The last attempted resource discovery time.
        /// </para>
        /// </summary>
        public DateTime LastAttemptedDiscoveryTime
        {
            get { return this._lastAttemptedDiscoveryTime.GetValueOrDefault(); }
            set { this._lastAttemptedDiscoveryTime = value; }
        }

        // Check to see if LastAttemptedDiscoveryTime property is set
        internal bool IsSetLastAttemptedDiscoveryTime()
        {
            return this._lastAttemptedDiscoveryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSuccessfulDiscoveryTime. 
        /// <para>
        /// The last successful resource discovery time.
        /// </para>
        /// </summary>
        public DateTime LastSuccessfulDiscoveryTime
        {
            get { return this._lastSuccessfulDiscoveryTime.GetValueOrDefault(); }
            set { this._lastSuccessfulDiscoveryTime = value; }
        }

        // Check to see if LastSuccessfulDiscoveryTime property is set
        internal bool IsSetLastSuccessfulDiscoveryTime()
        {
            return this._lastSuccessfulDiscoveryTime.HasValue; 
        }

    }
}