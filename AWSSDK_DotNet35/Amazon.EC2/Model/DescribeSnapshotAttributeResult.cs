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
    /// 
    /// </summary>
    public partial class DescribeSnapshotAttributeResult : AmazonWebServiceResponse
    {
        private List<CreateVolumePermission> _createVolumePermissions = new List<CreateVolumePermission>();
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private string _snapshotId;

        /// <summary>
        /// Gets and sets the property CreateVolumePermissions. 
        /// <para>
        /// A list of permissions for creating volumes from the snapshot.
        /// </para>
        /// </summary>
        public List<CreateVolumePermission> CreateVolumePermissions
        {
            get { return this._createVolumePermissions; }
            set { this._createVolumePermissions = value; }
        }

        // Check to see if CreateVolumePermissions property is set
        internal bool IsSetCreateVolumePermissions()
        {
            return this._createVolumePermissions != null && this._createVolumePermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// A list of product codes.
        /// </para>
        /// </summary>
        public List<ProductCode> ProductCodes
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
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the Amazon EBS snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}