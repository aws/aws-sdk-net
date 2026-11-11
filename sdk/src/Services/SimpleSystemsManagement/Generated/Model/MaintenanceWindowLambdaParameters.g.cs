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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The parameters for a <c>LAMBDA</c> task type.
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
    /// For Lambda tasks, Systems Manager ignores any values specified for TaskParameters
    /// and LoggingInfo.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class MaintenanceWindowLambdaParameters
    {
        /// <summary>
        /// Gets and sets the property ClientContext. 
        /// <para>
        /// Pass client-specific information to the Lambda function that you are invoking. You
        /// can then process the client information in your Lambda function as you choose through
        /// the context variable.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8000)]
        public string ClientContext { get; set; }

        /// <summary>
        /// Checks to see if the ClientContext property is set.
        /// </summary>
        internal bool IsSetClientContext() => this.ClientContext != null;

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// JSON to provide to your Lambda function as input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 4096)]
        public MemoryStream Payload { get; set; }

        /// <summary>
        /// Checks to see if the Payload property is set.
        /// </summary>
        internal bool IsSetPayload() => this.Payload != null;

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// (Optional) Specify an Lambda function version or alias name. If you specify a function
        /// version, the operation uses the qualified function Amazon Resource Name (ARN) to invoke
        /// a specific Lambda function. If you specify an alias name, the operation uses the alias
        /// ARN to invoke the Lambda function version to which the alias points.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Qualifier { get; set; }

        /// <summary>
        /// Checks to see if the Qualifier property is set.
        /// </summary>
        internal bool IsSetQualifier() => this.Qualifier != null;
    }
}
