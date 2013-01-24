/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Snapshot Attribute
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class SnapshotAttribute
    {    
        private string snapshotIdField;
        private List<CreateVolumePermission> createVolumePermissionField;
        private List<ProductCode> productCodesField;

        /// <summary>
        /// The ID of the Amazon EBS snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotId")]
        public string SnapshotId
        {
            get { return this.snapshotIdField; }
            set { this.snapshotIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Amazon EBS snapshot.
        /// </summary>
        /// <param name="snapshotId">The ID of the Amazon EBS snapshot.</param>
        /// <returns>this instance</returns>
        public SnapshotAttribute WithSnapshotId(string snapshotId)
        {
            this.snapshotIdField = snapshotId;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotId property is set
        /// </summary>
        /// <returns>true if SnapshotId property is set</returns>
        public bool IsSetSnapshotId()
        {
            return this.snapshotIdField != null;
        }

        /// <summary>
        /// List of create volume permissions
        /// </summary>
        [XmlElementAttribute(ElementName = "CreateVolumePermission")]
        public List<CreateVolumePermission> CreateVolumePermission
        {
            get
            {
                if (this.createVolumePermissionField == null)
                {
                    this.createVolumePermissionField = new List<CreateVolumePermission>();
                }
                return this.createVolumePermissionField;
            }
            set { this.createVolumePermissionField = value; }
        }

        /// <summary>
        /// Sets the list of create volume permissions
        /// </summary>
        /// <param name="list">list of create volume permissions</param>
        /// <returns>this instance</returns>
        public SnapshotAttribute WithCreateVolumePermission(params CreateVolumePermission[] list)
        {
            foreach (CreateVolumePermission item in list)
            {
                CreateVolumePermission.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if CreateVolumePermission property is set
        /// </summary>
        /// <returns>true if CreateVolumePermission property is set</returns>
        public bool IsSetCreateVolumePermission()
        {
            return (CreateVolumePermission.Count > 0);
        }

        /// <summary>
        /// The product codes associated with the snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "ProductCode")]
        public List<ProductCode> ProductCodes
        {
            get
            {
                if (this.productCodesField == null)
                {
                    this.productCodesField = new List<ProductCode>();
                }
                return this.productCodesField;
            }
            set { this.productCodesField = value; }
        }

        /// <summary>
        /// Sets the product codes associated with the snapshot.
        /// </summary>
        /// <param name="list">Product codes.</param>
        /// <returns>this instance</returns>
        public SnapshotAttribute WithProductCodes(params ProductCode[] list)
        {
            foreach (ProductCode item in list)
            {
                ProductCodes.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ProductCodes property is set
        /// </summary>
        /// <returns>true if ProductCodes property is set</returns>
        public bool IsSetProductCodes()
        {
            return (ProductCodes.Count > 0);
        }

    }
}
