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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// A response that contains the results of a container image aggregation.
    /// </summary>
    public partial class ContainerImageAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID associated with the container image.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the container image.
        /// </para>
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the container image aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string CloudAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CloudAccountId property is set.
        /// </summary>
        internal bool IsSetCloudAccountId() => this.CloudAccountId != null;

        /// <summary>
        /// Gets and sets the property CloudOrgId. 
        /// <para>
        /// The cloud organization ID for the container image aggregation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string CloudOrgId { get; set; }

        /// <summary>
        /// Checks to see if the CloudOrgId property is set.
        /// </summary>
        internal bool IsSetCloudOrgId() => this.CloudOrgId != null;

        /// <summary>
        /// Gets and sets the property CloudPartition. 
        /// <para>
        /// The cloud infrastructure partition associated with this container image aggregation.
        /// Valid values:
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CloudPartition { get; set; }

        /// <summary>
        /// Checks to see if the CloudPartition property is set.
        /// </summary>
        internal bool IsSetCloudPartition() => this.CloudPartition != null;

        /// <summary>
        /// Gets and sets the property CloudProvider. 
        /// <para>
        /// The cloud service provider associated with this container image aggregation. Valid
        /// values:
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
        /// </summary>
        public Provider CloudProvider { get; set; }

        /// <summary>
        /// Checks to see if the CloudProvider property is set.
        /// </summary>
        internal bool IsSetCloudProvider() => this.CloudProvider != null;

        /// <summary>
        /// Gets and sets the property CloudRegion. 
        /// <para>
        /// The cloud Region associated with this container image aggregation. The value format
        /// depends on the cloud provider:
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
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CloudRegion { get; set; }

        /// <summary>
        /// Checks to see if the CloudRegion property is set.
        /// </summary>
        internal bool IsSetCloudRegion() => this.CloudRegion != null;

        /// <summary>
        /// Gets and sets the property ExploitAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings with an exploit available for the container image.
        /// </para>
        /// </summary>
        public long? ExploitAvailableActiveFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the ExploitAvailableActiveFindingsCount property is set.
        /// </summary>
        internal bool IsSetExploitAvailableActiveFindingsCount() => this.ExploitAvailableActiveFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property FixAvailableActiveFindingsCount. 
        /// <para>
        /// The number of active findings with a fix available for the container image.
        /// </para>
        /// </summary>
        public long? FixAvailableActiveFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailableActiveFindingsCount property is set.
        /// </summary>
        internal bool IsSetFixAvailableActiveFindingsCount() => this.FixAvailableActiveFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The image digest for the container image.
        /// </para>
        /// </summary>
        public string ImageDigest { get; set; }

        /// <summary>
        /// Checks to see if the ImageDigest property is set.
        /// </summary>
        internal bool IsSetImageDigest() => this.ImageDigest != null;

        /// <summary>
        /// Gets and sets the property ImageTags. 
        /// <para>
        /// The image tags attached to the container image.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ImageTags { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImageTags property is set.
        /// </summary>
        internal bool IsSetImageTags() => this.ImageTags != null && (this.ImageTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InUseCount. 
        /// <para>
        /// The number of times the container image is in use.
        /// </para>
        /// </summary>
        public long? InUseCount { get; set; }

        /// <summary>
        /// Checks to see if the InUseCount property is set.
        /// </summary>
        internal bool IsSetInUseCount() => this.InUseCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastInUseAt. 
        /// <para>
        /// The last time the container image was in use.
        /// </para>
        /// </summary>
        public DateTime? LastInUseAt { get; set; }

        /// <summary>
        /// Checks to see if the LastInUseAt property is set.
        /// </summary>
        internal bool IsSetLastInUseAt() => this.LastInUseAt.HasValue;

        /// <summary>
        /// Gets and sets the property Registry. 
        /// <para>
        /// The registry for the container image.
        /// </para>
        /// </summary>
        public string Registry { get; set; }

        /// <summary>
        /// Checks to see if the Registry property is set.
        /// </summary>
        internal bool IsSetRegistry() => this.Registry != null;

        /// <summary>
        /// Gets and sets the property Repository. 
        /// <para>
        /// The repository for the container image.
        /// </para>
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// Checks to see if the Repository property is set.
        /// </summary>
        internal bool IsSetRepository() => this.Repository != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID for the container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SeverityCounts.
        /// </summary>
        public SeverityCounts SeverityCounts { get; set; }

        /// <summary>
        /// Checks to see if the SeverityCounts property is set.
        /// </summary>
        internal bool IsSetSeverityCounts() => this.SeverityCounts != null;
    }
}
