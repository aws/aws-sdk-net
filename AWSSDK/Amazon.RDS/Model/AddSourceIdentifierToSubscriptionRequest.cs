/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the AddSourceIdentifierToSubscription operation.
    /// <para>Adds a source identifier to an existing RDS event notification subscription.</para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.AddSourceIdentifierToSubscription"/>
    public class AddSourceIdentifierToSubscriptionRequest : AmazonWebServiceRequest
    {
        private string subscriptionName;
        private string sourceIdentifier;

        /// <summary>
        /// The name of the RDS event notification subscription you want to add a source identifier to.
        ///  
        /// </summary>
        public string SubscriptionName
        {
            get { return this.subscriptionName; }
            set { this.subscriptionName = value; }
        }

        /// <summary>
        /// Sets the SubscriptionName property
        /// </summary>
        /// <param name="subscriptionName">The value to set for the SubscriptionName property </param>
        /// <returns>this instance</returns>
        public AddSourceIdentifierToSubscriptionRequest WithSubscriptionName(string subscriptionName)
        {
            this.subscriptionName = subscriptionName;
            return this;
        }
            

        // Check to see if SubscriptionName property is set
        internal bool IsSetSubscriptionName()
        {
            return this.subscriptionName != null;
        }

        /// <summary>
        /// The identifier of the event source to be added. An identifier must begin with a letter and must contain only ASCII letters, digits, and
        /// hyphens; it cannot end with a hyphen or contain two consecutive hyphens. Constraints: <ul> <li>If the source type is a DB instance, then a
        /// DBInstanceIdentifier must be supplied.</li> <li>If the source type is a DB security group, a DBSecurityGroupName must be supplied.</li>
        /// <li>If the source type is a DB parameter group, a DBParameterGroupName must be supplied.</li> <li>If the source type is a DB Snapshot, a
        /// DBSnapshotIdentifier must be supplied.</li> </ul>
        ///  
        /// </summary>
        public string SourceIdentifier
        {
            get { return this.sourceIdentifier; }
            set { this.sourceIdentifier = value; }
        }

        /// <summary>
        /// Sets the SourceIdentifier property
        /// </summary>
        /// <param name="sourceIdentifier">The value to set for the SourceIdentifier property </param>
        /// <returns>this instance</returns>
        public AddSourceIdentifierToSubscriptionRequest WithSourceIdentifier(string sourceIdentifier)
        {
            this.sourceIdentifier = sourceIdentifier;
            return this;
        }
            

        // Check to see if SourceIdentifier property is set
        internal bool IsSetSourceIdentifier()
        {
            return this.sourceIdentifier != null;
        }
    }
}
    
