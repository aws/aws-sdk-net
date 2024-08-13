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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
        private DateTime? _creationTime;
        private string _owner;
        private UserIdentity _userIdentity;
        private string _vpcConnectionArn;

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when Amazon MSK creates the VPC Connnection.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Owner.             
        /// <para>
        /// The owner of the VPC Connection.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentity.             
        /// <para>
        /// Description of the requester that calls the API operation.
        /// </para>
        /// </summary>
        public UserIdentity UserIdentity
        {
            get { return this._userIdentity; }
            set { this._userIdentity = value; }
        }

        // Check to see if UserIdentity property is set
        internal bool IsSetUserIdentity()
        {
            return this._userIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConnectionArn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the VPC connection.
        /// </para>
        /// </summary>
        public string VpcConnectionArn
        {
            get { return this._vpcConnectionArn; }
            set { this._vpcConnectionArn = value; }
        }

        // Check to see if VpcConnectionArn property is set
        internal bool IsSetVpcConnectionArn()
        {
            return this._vpcConnectionArn != null;
        }

    }
}