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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateService operation. Updates an existing service.
    /// </summary>
    public partial class UpdateServiceRequest : AmazonResiliencehubv2Request
    {
        /// <summary>
        /// Gets and sets the property AssociatedSystems. 
        /// <para>
        /// The updated systems to associate with the service.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public List<AssociatedSystem> AssociatedSystems { get; set; } = AWSConfigs.InitializeCollections ? new List<AssociatedSystem>() : null;

        /// <summary>
        /// Checks to see if the AssociatedSystems property is set.
        /// </summary>
        internal bool IsSetAssociatedSystems() => this.AssociatedSystems != null && (this.AssociatedSystems.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DependencyDiscovery.
        /// </summary>
        public DependencyDiscoveryInput DependencyDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the DependencyDiscovery property is set.
        /// </summary>
        internal bool IsSetDependencyDiscovery() => this.DependencyDiscovery != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max = 615)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DevOpsAgentConfiguration. 
        /// <para>
        /// The optional DevOps Agent integration configuration to set, replace, or disconnect
        /// for the service. If you omit this field, the existing DevOps Agent linkage stays unchanged.
        /// </para>
        /// </summary>
        public DevOpsAgentConfiguration DevOpsAgentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DevOpsAgentConfiguration property is set.
        /// </summary>
        internal bool IsSetDevOpsAgentConfiguration() => this.DevOpsAgentConfiguration != null;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The updated permission model for the service.
        /// </para>
        /// </summary>
        public PermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property PolicyArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string PolicyArn { get; set; }

        /// <summary>
        /// Checks to see if the PolicyArn property is set.
        /// </summary>
        internal bool IsSetPolicyArn() => this.PolicyArn != null;

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// The updated AWS Regions where the service operates.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportConfiguration.
        /// </summary>
        public ServiceReportConfiguration ReportConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ReportConfiguration property is set.
        /// </summary>
        internal bool IsSetReportConfiguration() => this.ReportConfiguration != null;

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;
    }
}
