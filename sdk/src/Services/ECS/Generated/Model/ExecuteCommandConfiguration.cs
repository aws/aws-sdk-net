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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The details of the execute command configuration.
    /// </summary>
    public partial class ExecuteCommandConfiguration
    {
        private string _kmsKeyId;
        private ExecuteCommandLogConfiguration _logConfiguration;
        private ExecuteCommandLogging _logging;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specify an Key Management Service key ID to encrypt the data between the local client
        /// and the container.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration for the results of the execute command actions. The logs can
        /// be sent to CloudWatch Logs or an Amazon S3 bucket. When <c>logging=OVERRIDE</c> is
        /// specified, a <c>logConfiguration</c> must be provided.
        /// </para>
        /// </summary>
        public ExecuteCommandLogConfiguration LogConfiguration
        {
            get { return this._logConfiguration; }
            set { this._logConfiguration = value; }
        }

        // Check to see if LogConfiguration property is set
        internal bool IsSetLogConfiguration()
        {
            return this._logConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The log setting to use for redirecting logs for your execute command results. The
        /// following log settings are available.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NONE</c>: The execute command session is not logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DEFAULT</c>: The <c>awslogs</c> configuration in the task definition is used.
        /// If no logging parameter is specified, it defaults to this value. If no <c>awslogs</c>
        /// log driver is configured in the task definition, the output won't be logged.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OVERRIDE</c>: Specify the logging details as a part of <c>logConfiguration</c>.
        /// If the <c>OVERRIDE</c> logging option is specified, the <c>logConfiguration</c> is
        /// required.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecuteCommandLogging Logging
        {
            get { return this._logging; }
            set { this._logging = value; }
        }

        // Check to see if Logging property is set
        internal bool IsSetLogging()
        {
            return this._logging != null;
        }

    }
}