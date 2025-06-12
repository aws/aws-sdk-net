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
    /// Describes an Amazon FPGA image (AFI) attribute.
    /// </summary>
    public partial class FpgaImageAttribute
    {
        private string _description;
        private string _fpgaImageId;
        private List<LoadPermission> _loadPermissions = AWSConfigs.InitializeCollections ? new List<LoadPermission>() : null;
        private string _name;
        private List<ProductCode> _productCodes = AWSConfigs.InitializeCollections ? new List<ProductCode>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AFI.
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
        /// Gets and sets the property FpgaImageId. 
        /// <para>
        /// The ID of the AFI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LoadPermissions. 
        /// <para>
        /// The load permissions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LoadPermission> LoadPermissions
        {
            get { return this._loadPermissions; }
            set { this._loadPermissions = value; }
        }

        // Check to see if LoadPermissions property is set
        internal bool IsSetLoadPermissions()
        {
            return this._loadPermissions != null && (this._loadPermissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AFI.
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
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && (this._productCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}