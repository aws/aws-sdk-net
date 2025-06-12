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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyFpgaImageAttribute operation.
    /// Modifies the specified attribute of the specified Amazon FPGA Image (AFI).
    /// </summary>
    public partial class ModifyFpgaImageAttributeRequest : AmazonEC2Request
    {
        private FpgaImageAttributeName _attribute;
        private string _description;
        private bool? _dryRun;
        private string _fpgaImageId;
        private LoadPermissionModifications _loadPermission;
        private string _name;
        private OperationType _operationType;
        private List<string> _productCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _userIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The name of the attribute.
        /// </para>
        /// </summary>
        public FpgaImageAttributeName Attribute
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
        /// A description for the AFI.
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
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FpgaImageId. 
        /// <para>
        /// The ID of the AFI.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FpgaImageId
        {
            get { return this._fpgaImageId; }
            set { this._fpgaImageId = value; }
        }

        // Check to see if FpgaImageId property is set
        internal bool IsSetFpgaImageId()
        {
            return this._fpgaImageId != null;
        }

        /// <summary>
        /// Gets and sets the property LoadPermission. 
        /// <para>
        /// The load permission for the AFI.
        /// </para>
        /// </summary>
        public LoadPermissionModifications LoadPermission
        {
            get { return this._loadPermission; }
            set { this._loadPermission = value; }
        }

        // Check to see if LoadPermission property is set
        internal bool IsSetLoadPermission()
        {
            return this._loadPermission != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the AFI.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The operation type.
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
        /// The product codes. After you add a product code to an AFI, it can't be removed. This
        /// parameter is valid only when modifying the <c>productCodes</c> attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && (this._productCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserGroups. 
        /// <para>
        /// The user groups. This parameter is valid only when modifying the <c>loadPermission</c>
        /// attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserGroups
        {
            get { return this._userGroups; }
            set { this._userGroups = value; }
        }

        // Check to see if UserGroups property is set
        internal bool IsSetUserGroups()
        {
            return this._userGroups != null && (this._userGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The Amazon Web Services account IDs. This parameter is valid only when modifying the
        /// <c>loadPermission</c> attribute.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null && (this._userIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}