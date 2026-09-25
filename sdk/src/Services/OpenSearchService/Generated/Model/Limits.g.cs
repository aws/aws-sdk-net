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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Limits for a given instance type and for each of its roles.
    /// </summary>
    public partial class Limits
    {
        /// <summary>
        /// Gets and sets the property AdditionalLimits. 
        /// <para>
        /// List of additional limits that are specific to a given instance type for each of its
        /// instance roles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalLimit> AdditionalLimits { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalLimit>() : null;

        /// <summary>
        /// Checks to see if the AdditionalLimits property is set.
        /// </summary>
        internal bool IsSetAdditionalLimits() => this.AdditionalLimits != null && (this.AdditionalLimits.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InstanceLimits. 
        /// <para>
        /// The limits for a given instance type.
        /// </para>
        /// </summary>
        public InstanceLimits InstanceLimits { get; set; }

        /// <summary>
        /// Checks to see if the InstanceLimits property is set.
        /// </summary>
        internal bool IsSetInstanceLimits() => this.InstanceLimits != null;

        /// <summary>
        /// Gets and sets the property StorageTypes. 
        /// <para>
        /// Storage-related attributes that are available for a given instance type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StorageType> StorageTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<StorageType>() : null;

        /// <summary>
        /// Checks to see if the StorageTypes property is set.
        /// </summary>
        internal bool IsSetStorageTypes() => this.StorageTypes != null && (this.StorageTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
