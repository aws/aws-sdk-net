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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
    /// Container for the parameters to the DeleteResourceExplorerSetup operation.
    /// Deletes a Resource Explorer setup configuration. This operation removes indexes and
    /// views from the specified Regions or all Regions where Resource Explorer is configured.
    /// </summary>
    public partial class DeleteResourceExplorerSetupRequest : AmazonResourceExplorer2Request
    {
        private bool? _deleteInAllRegions;
        private List<string> _regionList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DeleteInAllRegions. 
        /// <para>
        /// Specifies whether to delete Resource Explorer configuration from all Regions where
        /// it is currently enabled. If this parameter is set to <c>true</c>, a value for <c>RegionList</c>
        /// must not be provided. Otherwise, the operation fails with a <c>ValidationException</c>
        /// error.
        /// </para>
        /// </summary>
        public bool DeleteInAllRegions
        {
            get { return this._deleteInAllRegions.GetValueOrDefault(); }
            set { this._deleteInAllRegions = value; }
        }

        // Check to see if DeleteInAllRegions property is set
        internal bool IsSetDeleteInAllRegions()
        {
            return this._deleteInAllRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionList. 
        /// <para>
        /// A list of Amazon Web Services Regions from which to delete the Resource Explorer configuration.
        /// If not specified, the operation uses the <c>DeleteInAllRegions</c> parameter to determine
        /// scope.
        /// </para>
        /// </summary>
        public List<string> RegionList
        {
            get { return this._regionList; }
            set { this._regionList = value; }
        }

        // Check to see if RegionList property is set
        internal bool IsSetRegionList()
        {
            return this._regionList != null && (this._regionList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}