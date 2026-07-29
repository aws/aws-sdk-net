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
    /// An aggregation of information about container images.
    /// </summary>
    public partial class ContainerImageAggregation
    {
        private List<StringFilter> _architectures = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudAccountIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudOrgIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudPartitions = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudProviders = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _cloudRegions = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _imageDigests = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _imageTags = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<NumberFilter> _inUseCount = AWSConfigs.InitializeCollections ? new List<NumberFilter>() : null;
        private List<DateFilter> _lastInUseAt = AWSConfigs.InitializeCollections ? new List<DateFilter>() : null;
        private List<StringFilter> _registries = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _repositories = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private List<StringFilter> _resourceIds = AWSConfigs.InitializeCollections ? new List<StringFilter>() : null;
        private ContainerImageSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property Architectures. 
        /// <para>
        /// The image architectures to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Architectures
        {
            get { return this._architectures; }
            set { this._architectures = value; }
        }

        // Check to see if Architectures property is set
        internal bool IsSetArchitectures()
        {
            return this._architectures != null && (this._architectures.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Gets and sets the property ImageDigests. 
        /// <para>
        /// The image digests to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ImageDigests
        {
            get { return this._imageDigests; }
            set { this._imageDigests = value; }
        }

        // Check to see if ImageDigests property is set
        internal bool IsSetImageDigests()
        {
            return this._imageDigests != null && (this._imageDigests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The image tags to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ImageTags
        {
            get { return this._imageTags; }
            set { this._imageTags = value; }
        }

        // Check to see if ImageTags property is set
        internal bool IsSetImageTags()
        {
            return this._imageTags != null && (this._imageTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The in-use counts to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<NumberFilter> InUseCount
        {
            get { return this._inUseCount; }
            set { this._inUseCount = value; }
        }

        // Check to see if InUseCount property is set
        internal bool IsSetInUseCount()
        {
            return this._inUseCount != null && (this._inUseCount.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The last in-use timestamps to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<DateFilter> LastInUseAt
        {
            get { return this._lastInUseAt; }
            set { this._lastInUseAt = value; }
        }

        // Check to see if LastInUseAt property is set
        internal bool IsSetLastInUseAt()
        {
            return this._lastInUseAt != null && (this._lastInUseAt.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Registries. 
        /// <para>
        /// The image registries to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Registries
        {
            get { return this._registries; }
            set { this._registries = value; }
        }

        // Check to see if Registries property is set
        internal bool IsSetRegistries()
        {
            return this._registries != null && (this._registries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Repositories. 
        /// <para>
        /// The image repositories to aggregate findings for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Repositories
        {
            get { return this._repositories; }
            set { this._repositories = value; }
        }

        // Check to see if Repositories property is set
        internal bool IsSetRepositories()
        {
            return this._repositories != null && (this._repositories.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// such as <c>CRITICAL</c>, <c>HIGH</c>, or <c>ALL</c>.
        /// </para>
        /// </summary>
        public ContainerImageSortBy SortBy
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

    }
}