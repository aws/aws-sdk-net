/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the AddSourceIdentifierToSubscription operation.
    /// Adds a source identifier to an existing RDS event notification subscription.
    /// </summary>
    public partial class AddSourceIdentifierToSubscriptionRequest : AmazonNeptuneRequest
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
        /// If the source type is a DB instance, then a <code>DBInstanceIdentifier</code> must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB security group, a <code>DBSecurityGroupName</code> must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB parameter group, a <code>DBParameterGroupName</code> must
        /// be supplied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a DB snapshot, a <code>DBSnapshotIdentifier</code> must be supplied.
        /// </para>
        ///  </li> </ul>
        /// </summary>
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