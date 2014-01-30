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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeSnapshotAttributeResult : AmazonWebServiceResponse
    {
        
        private string snapshotId;
        private List<CreateVolumePermission> createVolumePermissions = new List<CreateVolumePermission>();
        private List<ProductCode> productCodes = new List<ProductCode>();


        /// <summary>
        /// The ID of the Amazon EBS snapshot.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// A list of permissions for creating volumes from the snapshot.
        ///  
        /// </summary>
        public List<CreateVolumePermission> CreateVolumePermissions
        {
            get { return this.createVolumePermissions; }
            set { this.createVolumePermissions = value; }
        }

        // Check to see if CreateVolumePermissions property is set
        internal bool IsSetCreateVolumePermissions()
        {
            return this.createVolumePermissions.Count > 0;
        }

        /// <summary>
        /// A list of product codes.
        ///  
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }
    }
}
