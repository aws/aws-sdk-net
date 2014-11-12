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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
    /// at a time.
    /// 
    ///  <note>
    /// <para>
    /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
    /// code cannot be made public.
    /// </para>
    /// </note>
    /// </summary>
    public partial class ModifyImageAttributeRequest : AmazonEC2Request
    {
        private string _attribute;
        private string _description;
        private string _imageId;
        private LaunchPermissionModifications _launchPermission;
        private string _operationType;
        private List<string> _productCodes = new List<string>();
        private List<string> _userGroups = new List<string>();
        private List<string> _userIds = new List<string>();
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ModifyImageAttributeRequest() { }

        /// <summary>
        /// Instantiates ModifyImageAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI.</param>
        /// <param name="attribute">The name of the attribute to modify.</param>
        public ModifyImageAttributeRequest(string imageId, string attribute)
        {
            _imageId = imageId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute to modify.
        /// </para>
        /// </summary>
        public string Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the AMI.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchPermission. 
        /// <para>
        /// 
        /// </para>
        /// </summary>
        public LaunchPermissionModifications LaunchPermission
        {
            get { return this._launchPermission; }
            set { this._launchPermission = value; }
        }

        // Check to see if LaunchPermission property is set
        internal bool IsSetLaunchPermission()
        {
            return this._launchPermission != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The operation type.
        /// </para>
        /// </summary>
        public string OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// One or more product codes. After you add a product code to an AMI, it can't be removed.
        /// This is only valid when modifying the <code>productCodes</code> attribute.
        /// </para>
        /// </summary>
        public List<string> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && this._productCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// One or more user groups. This is only valid when modifying the <code>launchPermission</code>
        /// attribute.
        /// </para>
        /// </summary>
        public List<string> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && this._userGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// One or more AWS account IDs. This is only valid when modifying the <code>launchPermission</code>
        /// attribute.
        /// </para>
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && this._userIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute being modified. This is only valid when modifying the <code>description</code>
        /// attribute.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}