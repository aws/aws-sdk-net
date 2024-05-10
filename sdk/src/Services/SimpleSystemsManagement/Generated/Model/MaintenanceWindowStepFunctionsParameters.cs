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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The parameters for a <c>STEP_FUNCTIONS</c> task.
    /// 
    ///  
    /// <para>
    /// For information about specifying and updating task parameters, see <a>RegisterTaskWithMaintenanceWindow</a>
    /// and <a>UpdateMaintenanceWindowTask</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <c>LoggingInfo</c> has been deprecated. To specify an Amazon Simple Storage Service
    /// (Amazon S3) bucket to contain logs, instead use the <c>OutputS3BucketName</c> and
    /// <c>OutputS3KeyPrefix</c> options in the <c>TaskInvocationParameters</c> structure.
    /// For information about how Amazon Web Services Systems Manager handles these options
    /// for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    ///  <c>TaskParameters</c> has been deprecated. To specify parameters to pass to a task
    /// when it runs, instead use the <c>Parameters</c> option in the <c>TaskInvocationParameters</c>
    /// structure. For information about how Systems Manager handles these options for the
    /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    /// For Step Functions tasks, Systems Manager ignores any values specified for <c>TaskParameters</c>
    /// and <c>LoggingInfo</c>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MaintenanceWindowStepFunctionsParameters
    {
        private string _input;
        private string _name;

        /// <summary>
        /// Gets and sets the property Input. 
        /// <para>
        /// The inputs for the <c>STEP_FUNCTIONS</c> task.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
        public string Input
        {
            get { return this._input; }
            set { this._input = value; }
        }

        // Check to see if Input property is set
        internal bool IsSetInput()
        {
            return this._input != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>STEP_FUNCTIONS</c> task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
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

    }
}