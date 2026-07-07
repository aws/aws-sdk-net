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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An aggregation of information about VM instances.
    /// </summary>
    public partial class VmInstanceAggregation
    {
        private List<StringFilter> _cloudAccountIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudOrgIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudPartitions = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudProviders = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudRegions = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<MapFilter> _instanceTags = AWSConfigs.InitializeCollections ? new List<MapFilter>() : null;
        private List<StringFilter> _operatingSystems = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private VmInstanceSortBy _sortBy;
        private SortOrder _sortOrder;
        private List<StringFilter> _vmImageReferences = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;

        /// <summary>
        /// Gets and sets the property CloudAccountIds. 
        /// <para>
        /// The cloud account IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> CloudAccountIds
        {
            get { return this._cloudAccountIds; }
            set { this._cloudAccountIds = value; }
        }

        // Check to see if CloudAccountIds property is set
        internal bool IsSetCloudAccountIds()
        {
            return this._cloudAccountIds != null && (this._cloudAccountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudOrgIds. 
        /// <para>
        /// The cloud organization IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> CloudOrgIds
        {
            get { return this._cloudOrgIds; }
            set { this._cloudOrgIds = value; }
        }

        // Check to see if CloudOrgIds property is set
        internal bool IsSetCloudOrgIds()
        {
            return this._cloudOrgIds != null && (this._cloudOrgIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudPartitions. 
        /// <para>
        /// The cloud partitions to aggregate findings for. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aws</c> – Amazon Web Services commercial Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-cn</c> – Amazon Web Services China Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aws-us-gov</c> – Amazon Web Services GovCloud (US) Regions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AzureCloud</c> – Azure commercial Regions.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> CloudPartitions
        {
            get { return this._cloudPartitions; }
            set { this._cloudPartitions = value; }
        }

        // Check to see if CloudPartitions property is set
        internal bool IsSetCloudPartitions()
        {
            return this._cloudPartitions != null && (this._cloudPartitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudProviders. 
        /// <para>
        /// The cloud providers to aggregate findings for. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS</c> – Findings from Amazon Web Services resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AZURE</c> – Findings from Microsoft Azure resources.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> CloudProviders
        {
            get { return this._cloudProviders; }
            set { this._cloudProviders = value; }
        }

        // Check to see if CloudProviders property is set
        internal bool IsSetCloudProviders()
        {
            return this._cloudProviders != null && (this._cloudProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CloudRegions. 
        /// <para>
        /// The cloud regions to aggregate findings for. The value format depends on the cloud
        /// provider:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Web Services Region, such as <c>us-east-1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Azure region, such as <c>eastus</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> CloudRegions
        {
            get { return this._cloudRegions; }
            set { this._cloudRegions = value; }
        }

        // Check to see if CloudRegions property is set
        internal bool IsSetCloudRegions()
        {
            return this._cloudRegions != null && (this._cloudRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceTags. 
        /// <para>
        /// The instance tags to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<MapFilter> InstanceTags
        {
            get { return this._instanceTags; }
            set { this._instanceTags = value; }
        }

        // Check to see if InstanceTags property is set
        internal bool IsSetInstanceTags()
        {
            return this._instanceTags != null && (this._instanceTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OperatingSystems. 
        /// <para>
        /// The operating systems to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> OperatingSystems
        {
            get { return this._operatingSystems; }
            set { this._operatingSystems = value; }
        }

        // Check to see if OperatingSystems property is set
        internal bool IsSetOperatingSystems()
        {
            return this._operatingSystems != null && (this._operatingSystems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The resource IDs to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && (this._resourceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value to sort results by. Specify a field name from the aggregation response,
        /// such as <c>CRITICAL</c>, <c>HIGH</c>, <c>ALL</c>, or <c>NETWORK_FINDINGS</c>.
        /// </para>
        /// </summary>
        public VmInstanceSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort results by. Valid values are <c>ASC</c> and <c>DESC</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property VmImageReferences. 
        /// <para>
        /// The VM image references to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> VmImageReferences
        {
            get { return this._vmImageReferences; }
            set { this._vmImageReferences = value; }
        }

        // Check to see if VmImageReferences property is set
        internal bool IsSetVmImageReferences()
        {
            return this._vmImageReferences != null && (this._vmImageReferences.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}