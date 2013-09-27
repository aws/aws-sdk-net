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
    /// Copies a snapshot from a source region to the current region.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class CopySnapshotRequest : EC2Request
    {
        private string sourceRegionField;
        private string sourceSnapshotIdField;
        private string descriptionField;


        /// <summary>
        /// Source region to copy the snapshot from.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string SourceRegion
        {
            get { return this.sourceRegionField; }
            set { this.sourceRegionField = value; }
        }

        /// <summary>
        /// Sets the source region to copy the snapshot from.
        /// </summary>
        /// <param name="sourceRegion">Source region.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopySnapshotRequest WithSourceRegion(string sourceRegion)
        {
            this.sourceRegionField = sourceRegion;
            return this;
        }

        /// <summary>
        /// Checks if SourceRegion property is set
        /// </summary>
        /// <returns>true if SourceRegion property is set</returns>
        public bool IsSetSourceRegion()
        {
            return this.sourceRegionField != null;
        }


        /// <summary>
        /// Id of the source snapshot to copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string SourceSnapshotId
        {
            get { return this.sourceSnapshotIdField; }
            set { this.sourceSnapshotIdField = value; }
        }

        /// <summary>
        /// Sets the id of the source snapshot to copy.
        /// </summary>
        /// <param name="sourceSnapshotId">Snapshot id.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopySnapshotRequest WithSourceSnapshotId(string sourceSnapshotId)
        {
            this.sourceSnapshotIdField = sourceSnapshotId;
            return this;
        }

        /// <summary>
        /// Checks if SourceSnapshotId property is set
        /// </summary>
        /// <returns>true if SourceSnapshotId property is set</returns>
        public bool IsSetSourceSnapshotId()
        {
            return this.sourceSnapshotIdField != null;
        }


        /// <summary>
        /// Description of the snapshot copy.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceRegion")]
        public string Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        /// <summary>
        /// Sets the description of the snapshot copy.
        /// </summary>
        /// <param name="description">Description.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CopySnapshotRequest WithDescription(string description)
        {
            this.descriptionField = description;
            return this;
        }

        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public bool IsSetDescription()
        {
            return this.descriptionField != null;
        }
    }
}
