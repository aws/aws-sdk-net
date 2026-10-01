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
    /// Container for the parameters to the UpdateApplication operation. Updates a specified
    /// application. An application has to be in a stopped or created state in order to be
    /// updated.
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonEMRServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application to update.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the application to update. Its value must be unique
        /// for each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        /// Specifies the IAM Identity Center configuration used to enable or disable trusted
        /// identity propagation. When provided, this configuration determines how the application
        /// interacts with IAM Identity Center for user authentication and access control.
        /// </para>
        /// </summary>
        public IdentityCenterConfigurationInput IdentityCenterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityCenterConfiguration() => this.IdentityCenterConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The image configuration to be used for all worker types. You can either set this parameter
        /// or <c>imageConfiguration</c> for each worker type in <c>WorkerTypeSpecificationInput</c>.
        /// </para>
        /// </summary>
        public ImageConfigurationInput ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

        /// <summary>
        /// Gets and sets the property InitialCapacity. 
        /// <para>
        /// The capacity to initialize when the application is updated.
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
        /// The interactive configuration object that contains new interactive use cases when
        /// the application is updated.
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
        /// The maximum capacity to allocate when the application is updated. This is cumulative
        /// across all workers at any given point in time during the lifespan of the application.
        /// No new resources will be created once any one of the defined limits is hit.
        /// </para>
        /// </summary>
        public MaximumAllowedResources MaximumCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaximumCapacity property is set.
        /// </summary>
        internal bool IsSetMaximumCapacity() => this.MaximumCapacity != null;

        /// <summary>
        /// Gets and sets the property MonitoringConfiguration. 
        /// <para>
        /// The configuration setting for monitoring.
        /// </para>
        /// </summary>
        public MonitoringConfiguration MonitoringConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringConfiguration property is set.
        /// </summary>
        internal bool IsSetMonitoringConfiguration() => this.MonitoringConfiguration != null;

        /// <summary>
        /// Gets and sets the property NetworkConfiguration.
        /// </summary>
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfiguration property is set.
        /// </summary>
        internal bool IsSetNetworkConfiguration() => this.NetworkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release label for the application. You can change the release label
        /// to use a different release of Amazon EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;

        /// <summary>
        /// Gets and sets the property RuntimeConfiguration. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/emr-serverless/latest/APIReference/API_Configuration.html">Configuration</a>
        /// specifications to use when updating an application. Each configuration consists of
        /// a classification and properties. This configuration is applied across all the job
        /// runs submitted under the application.
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
        /// Gets and sets the property WorkerTypeSpecifications. 
        /// <para>
        /// The key-value pairs that specify worker type to <c>WorkerTypeSpecificationInput</c>.
        /// This parameter must contain all valid worker types for a Spark or Hive application.
        /// Valid worker types include <c>Driver</c> and <c>Executor</c> for Spark applications
        /// and <c>HiveDriver</c> and <c>TezTask</c> for Hive applications. You can either set
        /// image details in this parameter for each worker type, or in <c>imageConfiguration</c>
        /// for all worker types.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, WorkerTypeSpecificationInput> WorkerTypeSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, WorkerTypeSpecificationInput>() : null;

        /// <summary>
        /// Checks to see if the WorkerTypeSpecifications property is set.
        /// </summary>
        internal bool IsSetWorkerTypeSpecifications() => this.WorkerTypeSpecifications != null && (this.WorkerTypeSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
