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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateNetworkInterfacePermission operation.
    /// Grants an AWS-authorized account permission to attach the specified network interface
    /// to an instance in their account.
    /// 
    ///  
    /// <para>
    /// You can grant permission to a single AWS account only, and only one account at a time.
    /// </para>
    /// </summary>
    public partial class CreateNetworkInterfacePermissionRequest : AmazonEC2Request
    {
        private string _awsAccountId;
        private string _awsService;
        private string _networkInterfaceId;
        private InterfacePermissionType _permission;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
        /// </para>
        /// </summary>
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsService. 
        /// <para>
        /// The AWS service. Currently not supported.
        /// </para>
        /// </summary>
        public string AwsService
        {
            get { return this._awsService; }
            set { this._awsService = value; }
        }

        // Check to see if AwsService property is set
        internal bool IsSetAwsService()
        {
            return this._awsService != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this._networkInterfaceId; }
            set { this._networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this._networkInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Permission. 
        /// <para>
        /// The type of permission to grant.
        /// </para>
        /// </summary>
        public InterfacePermissionType Permission
        {
            get { return this._permission; }
            set { this._permission = value; }
        }

        // Check to see if Permission property is set
        internal bool IsSetPermission()
        {
            return this._permission != null;
        }

    }
}