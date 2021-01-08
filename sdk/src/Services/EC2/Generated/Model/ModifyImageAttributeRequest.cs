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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyImageAttribute operation.
    /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
    /// at a time. You can use the <code>Attribute</code> parameter to specify the attribute
    /// or one of the following parameters: <code>Description</code>, <code>LaunchPermission</code>,
    /// or <code>ProductCode</code>.
    /// 
    ///  
    /// <para>
    /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
    /// code cannot be made public.
    /// </para>
    ///  
    /// <para>
    /// To enable the SriovNetSupport enhanced networking attribute of an image, enable SriovNetSupport
    /// on an instance and create an AMI from the instance.
    /// </para>
    /// </summary>
    public partial class ModifyImageAttributeRequest : AmazonEC2Request
    {
        private string _attribute;
        private string _description;
        private string _imageId;
        private LaunchPermissionModifications _launchPermission;
        private OperationType _operationType;
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
        /// <param name="attribute">The name of the attribute to modify. The valid values are <code>description</code>, <code>launchPermission</code>, and <code>productCodes</code>.</param>
        public ModifyImageAttributeRequest(string imageId, string attribute)
        {
            _imageId = imageId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute to modify. The valid values are <code>description</code>,
        /// <code>launchPermission</code>, and <code>productCodes</code>.
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
        /// A new description for the AMI.
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
        [AWSProperty(Required=true)]
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
        /// A new launch permission for the AMI.
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
        /// The operation type. This parameter can be used only when the <code>Attribute</code>
        /// parameter is <code>launchPermission</code>.
        /// </para>
        /// </summary>
        public OperationType OperationType
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
        /// The DevPay product codes. After you add a product code to an AMI, it can't be removed.
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
        /// The user groups. This parameter can be used only when the <code>Attribute</code> parameter
        /// is <code>launchPermission</code>.
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
        /// The AWS account IDs. This parameter can be used only when the <code>Attribute</code>
        /// parameter is <code>launchPermission</code>.
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
        /// The value of the attribute being modified. This parameter can be used only when the
        /// <code>Attribute</code> parameter is <code>description</code> or <code>productCodes</code>.
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