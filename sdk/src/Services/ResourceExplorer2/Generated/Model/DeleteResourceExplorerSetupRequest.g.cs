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

namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteResourceExplorerSetup operation. Deletes
    /// a Resource Explorer setup configuration. This operation removes indexes and views
    /// from the specified Regions or all Regions where Resource Explorer is configured.
    /// </summary>
    public partial class DeleteResourceExplorerSetupRequest : AmazonResourceExplorer2Request
    {
        /// <summary>
        /// Gets and sets the property DeleteInAllRegions. 
        /// <para>
        /// Specifies whether to delete Resource Explorer configuration from all Regions where
        /// it is currently enabled. If this parameter is set to <c>true</c>, a value for <c>RegionList</c>
        /// must not be provided. Otherwise, the operation fails with a <c>ValidationException</c>
        /// error.
        /// </para>
        /// </summary>
        public bool? DeleteInAllRegions { get; set; }

        /// <summary>
        /// Checks to see if the DeleteInAllRegions property is set.
        /// </summary>
        internal bool IsSetDeleteInAllRegions() => this.DeleteInAllRegions.HasValue;

        /// <summary>
        /// Gets and sets the property RegionList. 
        /// <para>
        /// A list of Amazon Web Services Regions from which to delete the Resource Explorer configuration.
        /// If not specified, the operation uses the <c>DeleteInAllRegions</c> parameter to determine
        /// scope.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RegionList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RegionList property is set.
        /// </summary>
        internal bool IsSetRegionList() => this.RegionList != null && (this.RegionList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
