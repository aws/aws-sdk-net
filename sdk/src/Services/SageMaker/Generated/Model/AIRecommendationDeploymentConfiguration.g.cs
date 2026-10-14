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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The deployment configuration for a recommendation.
    /// </summary>
    public partial class AIRecommendationDeploymentConfiguration
    {
        /// <summary>
        /// Gets and sets the property CopyCountPerInstance. 
        /// <para>
        /// The number of model copies per instance.
        /// </para>
        /// </summary>
        public int? CopyCountPerInstance { get; set; }

        /// <summary>
        /// Checks to see if the CopyCountPerInstance property is set.
        /// </summary>
        internal bool IsSetCopyCountPerInstance() => this.CopyCountPerInstance.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// The environment variables for the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> EnvironmentVariables { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the EnvironmentVariables property is set.
        /// </summary>
        internal bool IsSetEnvironmentVariables() => this.EnvironmentVariables != null && (this.EnvironmentVariables.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageUri. 
        /// <para>
        /// The URI of the container image for the deployment.
        /// </para>
        /// </summary>
        public string ImageUri { get; set; }

        /// <summary>
        /// Checks to see if the ImageUri property is set.
        /// </summary>
        internal bool IsSetImageUri() => this.ImageUri != null;

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The recommended number of instances for the deployment.
        /// </para>
        /// </summary>
        public int? InstanceCount { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCount property is set.
        /// </summary>
        internal bool IsSetInstanceCount() => this.InstanceCount.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The recommended instance type for the deployment.
        /// </para>
        /// </summary>
        public AIRecommendationInstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property MinCpuMemoryRequiredInMb. 
        /// <para>
        /// The minimum host (CPU) memory, in MiB, to reserve for each model copy when deploying
        /// the recommendation as an Inference Component. This value maps to the Inference Component's
        /// <c>ComputeResourceRequirements$MinMemoryRequiredInMb</c> field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? MinCpuMemoryRequiredInMb { get; set; }

        /// <summary>
        /// Checks to see if the MinCpuMemoryRequiredInMb property is set.
        /// </summary>
        internal bool IsSetMinCpuMemoryRequiredInMb() => this.MinCpuMemoryRequiredInMb.HasValue;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The Amazon S3 data channels for the deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AIRecommendationDeploymentS3Channel> S3 { get; set; } = AWSConfigs.InitializeCollections ? new List<AIRecommendationDeploymentS3Channel>() : null;

        /// <summary>
        /// Checks to see if the S3 property is set.
        /// </summary>
        internal bool IsSetS3() => this.S3 != null && (this.S3.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
