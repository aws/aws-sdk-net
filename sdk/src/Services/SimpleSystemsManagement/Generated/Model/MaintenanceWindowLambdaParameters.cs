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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The parameters for a <code>LAMBDA</code> task type.
    /// 
    ///  
    /// <para>
    /// For information about specifying and updating task parameters, see <a>RegisterTaskWithMaintenanceWindow</a>
    /// and <a>UpdateMaintenanceWindowTask</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  <code>LoggingInfo</code> has been deprecated. To specify an Amazon Simple Storage
    /// Service (Amazon S3) bucket to contain logs, instead use the <code>OutputS3BucketName</code>
    /// and <code>OutputS3KeyPrefix</code> options in the <code>TaskInvocationParameters</code>
    /// structure. For information about how Amazon Web Services Systems Manager handles these
    /// options for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
    /// </para>
    ///  
    /// <para>
    ///  <code>TaskParameters</code> has been deprecated. To specify parameters to pass to
    /// a task when it runs, instead use the <code>Parameters</code> option in the <code>TaskInvocationParameters</code>
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
        private string _clientContext;
        private MemoryStream _payload;
        private string _qualifier;

        /// <summary>
        /// Gets and sets the property ClientContext. 
        /// <para>
        /// Pass client-specific information to the Lambda function that you are invoking. You
        /// can then process the client information in your Lambda function as you choose through
        /// the context variable.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8000)]
        public string ClientContext
        {
            get { return this._clientContext; }
            set { this._clientContext = value; }
        }

        // Check to see if ClientContext property is set
        internal bool IsSetClientContext()
        {
            return this._clientContext != null;
        }

        /// <summary>
        /// Gets and sets the property Payload. 
        /// <para>
        /// JSON to provide to your Lambda function as input.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=4096)]
        public MemoryStream Payload
        {
            get { return this._payload; }
            set { this._payload = value; }
        }

        // Check to see if Payload property is set
        internal bool IsSetPayload()
        {
            return this._payload != null;
        }

        /// <summary>
        /// Gets and sets the property Qualifier. 
        /// <para>
        /// (Optional) Specify an Lambda function version or alias name. If you specify a function
        /// version, the operation uses the qualified function Amazon Resource Name (ARN) to invoke
        /// a specific Lambda function. If you specify an alias name, the operation uses the alias
        /// ARN to invoke the Lambda function version to which the alias points.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Qualifier
        {
            get { return this._qualifier; }
            set { this._qualifier = value; }
        }

        // Check to see if Qualifier property is set
        internal bool IsSetQualifier()
        {
            return this._qualifier != null;
        }

    }
}