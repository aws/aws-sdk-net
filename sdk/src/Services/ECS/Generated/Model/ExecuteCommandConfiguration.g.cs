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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// The details of the execute command configuration.
    /// </summary>
    public partial class ExecuteCommandConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Specify an Key Management Service key ID to encrypt the data between the local client
        /// and the container.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The log configuration for the results of the execute command actions. The logs can
        /// be sent to CloudWatch Logs or an Amazon S3 bucket. When <c>logging=OVERRIDE</c> is
        /// specified, a <c>logConfiguration</c> must be provided.
        /// </para>
        /// </summary>
        public ExecuteCommandLogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

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
        public ExecuteCommandLogging Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;
    }
}
