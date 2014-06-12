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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes an Amazon EC2 security group.
    /// </summary>
    public partial class EC2SecurityGroup
    {
        private string _eC2SecurityGroupName;
        private string _eC2SecurityGroupOwnerId;
        private string _status;


        /// <summary>
        /// Gets and sets the property EC2SecurityGroupName. 
        /// <para>
        ///         The name of the EC2 Security Group.        
        /// </para>
        /// </summary>
        public string EC2SecurityGroupName
        {
            get { return this._eC2SecurityGroupName; }
            set { this._eC2SecurityGroupName = value; }
        }


        /// <summary>
        /// Sets the EC2SecurityGroupName property
        /// </summary>
        /// <param name="eC2SecurityGroupName">The value to set for the EC2SecurityGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EC2SecurityGroup WithEC2SecurityGroupName(string eC2SecurityGroupName)
        {
            this._eC2SecurityGroupName = eC2SecurityGroupName;
            return this;
        }

        // Check to see if EC2SecurityGroupName property is set
        internal bool IsSetEC2SecurityGroupName()
        {
            return this._eC2SecurityGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property EC2SecurityGroupOwnerId. 
        /// <para>
        ///         The AWS ID of the owner of the EC2 security group        specified in the
        /// <code>EC2SecurityGroupName</code> field.        
        /// </para>
        /// </summary>
        public string EC2SecurityGroupOwnerId
        {
            get { return this._eC2SecurityGroupOwnerId; }
            set { this._eC2SecurityGroupOwnerId = value; }
        }


        /// <summary>
        /// Sets the EC2SecurityGroupOwnerId property
        /// </summary>
        /// <param name="eC2SecurityGroupOwnerId">The value to set for the EC2SecurityGroupOwnerId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EC2SecurityGroup WithEC2SecurityGroupOwnerId(string eC2SecurityGroupOwnerId)
        {
            this._eC2SecurityGroupOwnerId = eC2SecurityGroupOwnerId;
            return this;
        }

        // Check to see if EC2SecurityGroupOwnerId property is set
        internal bool IsSetEC2SecurityGroupOwnerId()
        {
            return this._eC2SecurityGroupOwnerId != null;
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///         The status of the EC2 security group.        
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public EC2SecurityGroup WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}