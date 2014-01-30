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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyImageAttribute operation.
    /// <para>Modifies the specified attribute of the specified AMI. You can specify only one attribute at a time.</para> <para><b>NOTE:</b> AWS
    /// Marketplace product codes cannot be modified. Images with an AWS Marketplace product code cannot be made public. </para>
    /// </summary>
    public partial class ModifyImageAttributeRequest : AmazonEC2Request
    {
        private string imageId;
        private string attribute;
        private string operationType;
        private List<string> userIds = new List<string>();
        private List<string> userGroups = new List<string>();
        private List<string> productCodes = new List<string>();
        private string value;
        private LaunchPermissionModifications launchPermission;
        private string description;


        /// <summary>
        /// The ID of the AMI.
        ///  
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// The name of the attribute to modify.
        ///  
        /// </summary>
        public string Attribute
        {
            get { return this.attribute; }
            set { this.attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this.attribute != null;
        }

        /// <summary>
        /// The operation type.
        ///  
        /// </summary>
        public string OperationType
        {
            get { return this.operationType; }
            set { this.operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this.operationType != null;
        }

        /// <summary>
        /// One or more AWS account IDs. This is only valid when modifying the <c>launchPermission</c> attribute.
        ///  
        /// </summary>
        public List<string> UserIds
        {
            get { return this.userIds; }
            set { this.userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this.userIds.Count > 0;
        }

        /// <summary>
        /// One or more user groups. This is only valid when modifying the <c>launchPermission</c> attribute.
        ///  
        /// </summary>
        public List<string> UserGroups
        {
            get { return this.userGroups; }
            set { this.userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this.userGroups.Count > 0;
        }

        /// <summary>
        /// One or more product codes. After you add a product code to an AMI, it can't be removed. This is only valid when modifying the
        /// <c>productCodes</c> attribute.
        ///  
        /// </summary>
        public List<string> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }

        /// <summary>
        /// The value of the attribute being modified. This is only valid when modifying the <c>description</c> attribute.
        ///  
        /// </summary>
        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this.value != null;
        }

        /// <summary>
        /// <p/>
        ///  
        /// </summary>
        public LaunchPermissionModifications LaunchPermission
        {
            get { return this.launchPermission; }
            set { this.launchPermission = value; }
        }

        // Check to see if LaunchPermission property is set
        internal bool IsSetLaunchPermission()
        {
            return this.launchPermission != null;
        }

        /// <summary>
        /// A description for the AMI.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

    }
}
    
