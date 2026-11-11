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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Provides ownership and status information for an Amazon EC2 security group.
    /// </summary>
    public partial class EC2SecurityGroup
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public EC2SecurityGroup() { }

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        /// The name of the Amazon EC2 security group.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupName property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupName() => this.EC2SecurityGroupName != null;

        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        /// The Amazon account ID of the Amazon EC2 security group owner.
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the EC2SecurityGroupOwnerId property is set.
        /// </summary>
        internal bool IsSetEC2SecurityGroupOwnerId() => this.EC2SecurityGroupOwnerId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Amazon EC2 security group.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
