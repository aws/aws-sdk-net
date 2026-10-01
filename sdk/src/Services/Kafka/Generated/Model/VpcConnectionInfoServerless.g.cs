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

namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Description of the VPC connection.
    /// </summary>
    public partial class VpcConnectionInfoServerless
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when Amazon MSK creates the VPC Connnection.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the VPC Connection.
        /// </para>
        /// </summary>
        public string Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property UserIdentity. 
        /// <para>
        /// Description of the requester that calls the API operation.
        /// </para>
        /// </summary>
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentity property is set.
        /// </summary>
        internal bool IsSetUserIdentity() => this.UserIdentity != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC connection.
        /// </para>
        /// </summary>
        public string VpcConnectionArn { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionArn property is set.
        /// </summary>
        internal bool IsSetVpcConnectionArn() => this.VpcConnectionArn != null;
    }
}
