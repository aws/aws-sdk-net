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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
    /// </summary>
    public partial class ValidStorageOptions
    {
        /// <summary>
        /// Gets and sets the property IopsToStorageRatio. 
        /// <para>
        /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DoubleRange> IopsToStorageRatio { get; set; } = AWSConfigs.InitializeCollections ? new List<DoubleRange>() : null;

        /// <summary>
        /// Checks to see if the IopsToStorageRatio property is set.
        /// </summary>
        internal bool IsSetIopsToStorageRatio() => this.IopsToStorageRatio != null && (this.IopsToStorageRatio.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ProvisionedIops. 
        /// <para>
        /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> ProvisionedIops { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the ProvisionedIops property is set.
        /// </summary>
        internal bool IsSetProvisionedIops() => this.ProvisionedIops != null && (this.ProvisionedIops.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageSize. 
        /// <para>
        /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Range> StorageSize { get; set; } = AWSConfigs.InitializeCollections ? new List<Range>() : null;

        /// <summary>
        /// Checks to see if the StorageSize property is set.
        /// </summary>
        internal bool IsSetStorageSize() => this.StorageSize != null && (this.StorageSize.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Not applicable. In Neptune the storage type is managed at the DB Cluster level.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
