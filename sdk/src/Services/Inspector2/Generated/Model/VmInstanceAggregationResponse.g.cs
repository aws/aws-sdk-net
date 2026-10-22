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
    /// A response that contains the results of a VM instance aggregation.
    /// </summary>
    public partial class VmInstanceAggregationResponse
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID associated with the VM instance.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property CloudAccountId. 
        /// <para>
        /// The cloud account ID for the VM instance aggregation.
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
        /// The cloud organization ID for the VM instance aggregation.
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
        /// The cloud infrastructure partition associated with this VM instance aggregation. Valid
        /// values:
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
        /// The cloud service provider associated with this VM instance aggregation. Valid values:
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
        /// The cloud Region associated with this VM instance aggregation. The value format depends
        /// on the cloud provider:
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
        /// The number of active findings with an exploit available for the VM instance.
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
        /// The number of active findings with a fix available for the VM instance.
        /// </para>
        /// </summary>
        public long? FixAvailableActiveFindingsCount { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailableActiveFindingsCount property is set.
        /// </summary>
        internal bool IsSetFixAvailableActiveFindingsCount() => this.FixAvailableActiveFindingsCount.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkFindings. 
        /// <para>
        /// The number of network findings for the VM instance. This field applies only to Amazon
        /// Web Services resources.
        /// </para>
        /// </summary>
        public long? NetworkFindings { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFindings property is set.
        /// </summary>
        internal bool IsSetNetworkFindings() => this.NetworkFindings.HasValue;

        /// <summary>
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system of the VM instance.
        /// </para>
        /// </summary>
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Checks to see if the OperatingSystem property is set.
        /// </summary>
        internal bool IsSetOperatingSystem() => this.OperatingSystem != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID for the VM instance.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the VM instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VmImageReference. 
        /// <para>
        /// The VM image reference for the VM instance.
        /// </para>
        /// </summary>
        public string VmImageReference { get; set; }

        /// <summary>
        /// Checks to see if the VmImageReference property is set.
        /// </summary>
        internal bool IsSetVmImageReference() => this.VmImageReference != null;
    }
}
