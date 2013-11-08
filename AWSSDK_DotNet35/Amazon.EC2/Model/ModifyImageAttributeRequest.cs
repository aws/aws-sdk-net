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
    /// <para> The ModifyImageAttribute operation modifies an attribute of an AMI. </para>
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
        /// The ID of the AMI whose attribute you want to modify.
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
        /// The name of the AMI attribute you want to modify. Available attributes: <c>launchPermission</c>, <c>productCodes</c>
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
        /// The type of operation being requested. Available operation types: <c>add</c>, <c>remove</c>
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
        /// The AWS user ID being added to or removed from the list of users with launch permissions for this AMI. Only valid when the launchPermission
        /// attribute is being modified.
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
        /// The user group being added to or removed from the list of user groups with launch permissions for this AMI. Only valid when the
        /// launchPermission attribute is being modified. Available user groups: <c>all</c>
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
        /// The list of product codes being added to or removed from the specified AMI. Only valid when the productCodes attribute is being modified.
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
        /// The value of the attribute being modified. Only valid when the description attribute is being modified.
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
        /// String value
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
    
