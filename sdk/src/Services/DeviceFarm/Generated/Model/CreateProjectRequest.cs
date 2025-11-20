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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a project.
    /// </summary>
    public partial class CreateProjectRequest : AmazonDeviceFarmRequest
    {
        private int? _defaultJobTimeoutMinutes;
        private List<EnvironmentVariable> _environmentVariables = AWSConfigs.InitializeCollections ? new List<EnvironmentVariable>() : null;
        private string _executionRoleArn;
        private string _name;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property DefaultJobTimeoutMinutes. 
        /// <para>
        /// Sets the execution timeout value (in minutes) for a project. All test runs in this
        /// project use the specified execution timeout value unless overridden when scheduling
        /// a run.
        /// </para>
        /// </summary>
        public int DefaultJobTimeoutMinutes
        {
            get { return this._defaultJobTimeoutMinutes.GetValueOrDefault(); }
            set { this._defaultJobTimeoutMinutes = value; }
        }

        // Check to see if DefaultJobTimeoutMinutes property is set
        internal bool IsSetDefaultJobTimeoutMinutes()
        {
            return this._defaultJobTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        ///  A set of environment variables which are used by default for all runs in the project.
        /// These environment variables are applied to the test run during the execution of a
        /// test spec file. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about using test spec files, please see <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/custom-test-environments.html">Custom
        /// test environments </a> in <i>AWS Device Farm.</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<EnvironmentVariable> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && (this._environmentVariables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// An IAM role to be assumed by the test host for all runs in the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The project's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC security groups and subnets that are attached to a project.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}