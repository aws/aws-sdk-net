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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Information about an application. Amazon EMR Serverless uses applications to run jobs.
    /// </summary>
    public partial class Application
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The CPU architecture of an application.
        /// </para>
        /// </summary>
        public Architecture Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 60, Max = 1024)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AutoStartConfiguration. 
        /// <para>
        /// The configuration for an application to automatically start on job submission.
        /// </para>
        /// </summary>
        public AutoStartConfig AutoStartConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoStartConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoStartConfiguration() => this.AutoStartConfiguration != null;

        /// <summary>
        /// Gets and sets the property AutoStopConfiguration. 
        /// <para>
        /// The configuration for an application to automatically stop after a certain amount
        /// of time being idle.
        /// </para>
        /// </summary>
        public AutoStopConfig AutoStopConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the AutoStopConfiguration property is set.
        /// </summary>
        internal bool IsSetAutoStopConfiguration() => this.AutoStopConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the application run was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DiskEncryptionConfiguration. 
        /// <para>
        /// The configuration object that allows encrypting local disks.
        /// </para>
        /// </summary>
        public DiskEncryptionConfiguration DiskEncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DiskEncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetDiskEncryptionConfiguration() => this.DiskEncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// The IAM Identity Center configuration applied to enable trusted identity propagation.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityCenterConfiguration() => this.IdentityCenterConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The image configuration applied to all worker types.
        /// </para>
        /// </summary>
        public ImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

        /// <summary>
        /// Gets and sets the property InitialCapacity. 
        /// <para>
        /// The initial capacity of the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public Dictionary<string, InitialCapacityConfig> InitialCapacity { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, InitialCapacityConfig>() : null;

        /// <summary>
        /// Checks to see if the InitialCapacity property is set.
        /// </summary>
        internal bool IsSetInitialCapacity() => this.InitialCapacity != null && (this.InitialCapacity.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InteractiveConfiguration. 
        /// <para>
        /// The interactive configuration object that enables the interactive use cases for an
        /// application.
        /// </para>
        /// </summary>
        public InteractiveConfiguration InteractiveConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InteractiveConfiguration property is set.
        /// </summary>
        internal bool IsSetInteractiveConfiguration() => this.InteractiveConfiguration != null;

        /// <summary>
        /// Gets and sets the property JobLevelCostAllocationConfiguration. 
        /// <para>
        /// The configuration object that enables job level cost allocation.
        /// </para>
        /// </summary>
        public JobLevelCostAllocationConfiguration JobLevelCostAllocationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the JobLevelCostAllocationConfiguration property is set.
        /// </summary>
        internal bool IsSetJobLevelCostAllocationConfiguration() => this.JobLevelCostAllocationConfiguration != null;

        /// <summary>
        /// Gets and sets the property MaximumCapacity. 
        /// <para>
        /// The maximum capacity of the application. This is cumulative across all workers at
        /// any given point in time during the lifespan of the application is created. No new
        /// resources will be created once any one of the defined limits is hit.
        /// </para>
        /// </summary>
        public MaximumAllowedResources MaximumCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaximumCapacity property is set.
        /// </summary>
        internal bool IsSetMaximumCapacity() => this.MaximumCapacity != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration.
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The network configuration for customer VPC connectivity for the application.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release associated with the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/emr-serverless/latest/APIReference/API_Configuration.html">Configuration</a>
        /// specifications of an application. Each configuration consists of a classification
        /// and properties. You use this parameter when creating or updating an application. To
        /// see the runtimeConfiguration object of an application, run the <a href="https://docs.aws.amazon.com/emr-serverless/latest/APIReference/API_GetApplication.html">GetApplication</a>
        /// API operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<Configuration> RuntimeConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new List<Configuration>() : null;

        /// <summary>
        /// Checks to see if the RuntimeConfiguration property is set.
        /// </summary>
        internal bool IsSetRuntimeConfiguration() => this.RuntimeConfiguration != null && (this.RuntimeConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SchedulerConfiguration. 
        /// <para>
        /// The scheduler configuration for batch and streaming jobs running on this application.
        /// Supported with release labels emr-7.0.0 and above.
        /// </para>
        /// </summary>
        public SchedulerConfiguration SchedulerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SchedulerConfiguration property is set.
        /// </summary>
        internal bool IsSetSchedulerConfiguration() => this.SchedulerConfiguration != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ApplicationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// The state details of the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string StateDetails { get; set; }

        /// <summary>
        /// Checks to see if the StateDetails property is set.
        /// </summary>
        internal bool IsSetStateDetails() => this.StateDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of application, such as Spark or Hive.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time when the application run was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property WorkerTypeSpecifications. 
        /// <para>
        /// The specification applied to each worker type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, WorkerTypeSpecification> WorkerTypeSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkerTypeSpecification>() : null;

        /// <summary>
        /// Checks to see if the WorkerTypeSpecifications property is set.
        /// </summary>
        internal bool IsSetWorkerTypeSpecifications() => this.WorkerTypeSpecifications != null && (this.WorkerTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
