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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfileJob operation. Modifies the definition
    /// of an existing profile job.
    /// </summary>
    public partial class UpdateProfileJobRequest : AmazonGlueDataBrewRequest
    {
        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Configuration for profile jobs. Used to select columns, do evaluations, and override
        /// default parameters of evaluations. When configuration is null, the profile job will
        /// run with default settings.
        /// </para>
        /// </summary>
        public ProfileConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an encryption key that is used to protect the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The encryption mode for the job, which can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SSE-KMS</c> - Server-side encryption with keys managed by KMS.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSE-S3</c> - Server-side encryption with keys managed by Amazon S3.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EncryptionMode EncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionMode property is set.
        /// </summary>
        internal bool IsSetEncryptionMode() => this.EncryptionMode != null;

        /// <summary>
        /// Gets and sets the property JobSample. 
        /// <para>
        /// Sample configuration for Profile Jobs only. Determines the number of rows on which
        /// the Profile job will be executed. If a JobSample value is not provided for profile
        /// jobs, the default value will be used. The default value is CUSTOM_ROWS for the mode
        /// parameter and 20000 for the size parameter.
        /// </para>
        /// </summary>
        public JobSample JobSample { get; set; }

        /// <summary>
        /// Checks to see if the JobSample property is set.
        /// </summary>
        internal bool IsSetJobSample() => this.JobSample != null;

        /// <summary>
        /// Gets and sets the property LogSubscription. 
        /// <para>
        /// Enables or disables Amazon CloudWatch logging for the job. If logging is enabled,
        /// CloudWatch writes one log stream for each job run.
        /// </para>
        /// </summary>
        public LogSubscription LogSubscription { get; set; }

        /// <summary>
        /// Checks to see if the LogSubscription property is set.
        /// </summary>
        internal bool IsSetLogSubscription() => this.LogSubscription != null;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum number of compute nodes that DataBrew can use when the job processes data.
        /// </para>
        /// </summary>
        public int? MaxCapacity { get; set; }

        /// <summary>
        /// Checks to see if the MaxCapacity property is set.
        /// </summary>
        internal bool IsSetMaxCapacity() => this.MaxCapacity.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRetries. 
        /// <para>
        /// The maximum number of times to retry the job after a job run fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Checks to see if the MaxRetries property is set.
        /// </summary>
        internal bool IsSetMaxRetries() => this.MaxRetries.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 240)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OutputLocation.
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the OutputLocation property is set.
        /// </summary>
        internal bool IsSetOutputLocation() => this.OutputLocation != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role to
        /// be assumed when DataBrew runs the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The job's timeout in minutes. A job that attempts to run longer than this timeout
        /// period ends with a status of <c>TIMEOUT</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationConfigurations. 
        /// <para>
        /// List of validation configurations that are applied to the profile job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<ValidationConfiguration> ValidationConfigurations { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidationConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ValidationConfigurations property is set.
        /// </summary>
        internal bool IsSetValidationConfigurations() => this.ValidationConfigurations != null && (this.ValidationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
