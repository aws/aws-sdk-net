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
        public int? DefaultJobTimeoutMinutes
        {
            get { return this._defaultJobTimeoutMinutes; }
            set { this._defaultJobTimeoutMinutes = value; }
        }

        // Check to see if DefaultJobTimeoutMinutes property is set
        internal bool IsSetDefaultJobTimeoutMinutes()
        {
            return this._defaultJobTimeoutMinutes.HasValue; 
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