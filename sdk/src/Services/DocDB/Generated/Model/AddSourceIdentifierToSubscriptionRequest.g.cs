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

namespace Amazon.DocDB.Model
{
    /// <summary>
    /// Container for the parameters to the AddSourceIdentifierToSubscription operation. Adds
    /// a source identifier to an existing event notification subscription.
    /// </summary>
    public partial class AddSourceIdentifierToSubscriptionRequest : AmazonDocDBRequest
    {
        /// <summary>
        /// Gets and sets the property SourceIdentifier. 
        /// <para>
        /// The identifier of the event source to be added:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the source type is an instance, a <c>DBInstanceIdentifier</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a security group, a <c>DBSecurityGroupName</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a parameter group, a <c>DBParameterGroupName</c> must be provided.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the source type is a snapshot, a <c>DBSnapshotIdentifier</c> must be provided.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceIdentifier() => this.SourceIdentifier != null;

        /// <summary>
        /// Gets and sets the property SubscriptionName. 
        /// <para>
        /// The name of the Amazon DocumentDB event notification subscription that you want to
        /// add a source identifier to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionName property is set.
        /// </summary>
        internal bool IsSetSubscriptionName() => this.SubscriptionName != null;
    }
}
