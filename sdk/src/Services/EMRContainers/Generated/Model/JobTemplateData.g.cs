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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The values of StartJobRun API requests used in job runs started using the job template.
    /// </summary>
    public partial class JobTemplateData
    {
        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        ///  The configuration settings that are used to override defaults configuration.
        /// </para>
        /// </summary>
        public ParametricConfigurationOverrides ConfigurationOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationOverrides property is set.
        /// </summary>
        internal bool IsSetConfigurationOverrides() => this.ConfigurationOverrides != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property JobDriver.
        /// </summary>
        [AWSProperty(Required = true)]
        public JobDriver JobDriver { get; set; }

        /// <summary>
        /// Checks to see if the JobDriver property is set.
        /// </summary>
        internal bool IsSetJobDriver() => this.JobDriver != null;

        /// <summary>
        /// Gets and sets the property JobTags. 
        /// <para>
        /// The tags assigned to jobs started using the job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> JobTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the JobTags property is set.
        /// </summary>
        internal bool IsSetJobTags() => this.JobTags != null && (this.JobTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ParameterConfiguration. 
        /// <para>
        /// The configuration of parameters existing in the job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, TemplateParameterConfiguration> ParameterConfiguration { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, TemplateParameterConfiguration>() : null;

        /// <summary>
        /// Checks to see if the ParameterConfiguration property is set.
        /// </summary>
        internal bool IsSetParameterConfiguration() => this.ParameterConfiguration != null && (this.ParameterConfiguration.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        ///  The release version of Amazon EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ReleaseLabel { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseLabel property is set.
        /// </summary>
        internal bool IsSetReleaseLabel() => this.ReleaseLabel != null;
    }
}
