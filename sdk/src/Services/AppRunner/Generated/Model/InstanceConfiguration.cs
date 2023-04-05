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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes the runtime configuration of an App Runner service instance (scaling unit).
    /// </summary>
    public partial class InstanceConfiguration
    {
        private string _cpu;
        private string _instanceRoleArn;
        private string _memory;

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units reserved for each instance of your App Runner service.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>1 vCPU</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=9)]
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that provides permissions to your App
        /// Runner service. These are permissions that your code needs when it calls any Amazon
        /// Web Services APIs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=29, Max=1024)]
        public string InstanceRoleArn
        {
            get { return this._instanceRoleArn; }
            set { this._instanceRoleArn = value; }
        }

        // Check to see if InstanceRoleArn property is set
        internal bool IsSetInstanceRoleArn()
        {
            return this._instanceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory, in MB or GB, reserved for each instance of your App Runner service.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>2 GB</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=6)]
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

    }
}