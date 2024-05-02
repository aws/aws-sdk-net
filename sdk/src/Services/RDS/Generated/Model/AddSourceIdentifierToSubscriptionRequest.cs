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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the AddSourceIdentifierToSubscription operation.
    /// Adds a source identifier to an existing RDS event notification subscription.
    /// </summary>
    public partial class AddSourceIdentifierToSubscriptionRequest : AmazonRDSRequest
    {
        private string _sourceIdentifier;
        private string _subscriptionName;

        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// The identifier of the event source to be added.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the source type is a DB instance, a <c>DBInstanceIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster, a <c>DBClusterIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB parameter group, a <c>DBParameterGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB security group, a <c>DBSecurityGroupName</c> value must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB snapshot, a <c>DBSnapshotIdentifier</c> value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB cluster snapshot, a <c>DBClusterSnapshotIdentifier</c>
        /// value must be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is an RDS Proxy, a <c>DBProxyName</c> value must be supplied.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceIdentifier
        {
            get { return this._sourceIdentifier; }
            set { this._sourceIdentifier = value; }
        }

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this._sourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the RDS event notification subscription you want to add a source identifier
        /// to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionName
        {
            get { return this._subscriptionName; }
            set { this._subscriptionName = value; }
        }

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this._subscriptionName != null;
        }

    }
}