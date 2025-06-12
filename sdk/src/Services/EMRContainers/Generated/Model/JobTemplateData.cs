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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
        private ParametricConfigurationOverrides _configurationOverrides;
        private string _executionRoleArn;
        private JobDriver _jobDriver;
        private Dictionary<string, string> _jobTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, TemplateParameterConfiguration> _parameterConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, TemplateParameterConfiguration>() : null;
        private string _releaseLabel;

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        ///  The configuration settings that are used to override defaults configuration.
        /// </para>
        /// </summary>
        public ParametricConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDriver.
        /// </summary>
        [AWSProperty(Required=true)]
        public JobDriver JobDriver
        {
            get { return this._jobDriver; }
            set { this._jobDriver = value; }
        }

        // Check to see if JobDriver property is set
        internal bool IsSetJobDriver()
        {
            return this._jobDriver != null;
        }

        /// <summary>
        /// Gets and sets the property JobTags. 
        /// <para>
        /// The tags assigned to jobs started using the job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && (this._jobTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ParameterConfiguration. 
        /// <para>
        /// The configuration of parameters existing in the job template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public Dictionary<string, TemplateParameterConfiguration> ParameterConfiguration
        {
            get { return this._parameterConfiguration; }
            set { this._parameterConfiguration = value; }
        }

        // Check to see if ParameterConfiguration property is set
        internal bool IsSetParameterConfiguration()
        {
            return this._parameterConfiguration != null && (this._parameterConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        ///  The release version of Amazon EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

    }
}