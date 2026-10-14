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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Contains session configuration information.
    /// </summary>
    public partial class SessionConfiguration
    {
        /// <summary>
        /// Gets and sets the property EncryptionConfiguration.
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfiguration property is set.
        /// </summary>
        internal bool IsSetEncryptionConfiguration() => this.EncryptionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// The ARN of the execution role used to access user resources for Spark sessions and
        /// Identity Center enabled workgroups. This property applies only to Spark enabled workgroups
        /// and Identity Center enabled workgroups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ExecutionRole { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRole property is set.
        /// </summary>
        internal bool IsSetExecutionRole() => this.ExecutionRole != null;

        /// <summary>
        /// Gets and sets the property IdleTimeoutSeconds. 
        /// <para>
        /// The idle timeout in seconds for the session.
        /// </para>
        /// </summary>
        public long? IdleTimeoutSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeoutSeconds property is set.
        /// </summary>
        internal bool IsSetIdleTimeoutSeconds() => this.IdleTimeoutSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property SessionIdleTimeoutInMinutes. 
        /// <para>
        /// The idle timeout in seconds for the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 480)]
        public int? SessionIdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the SessionIdleTimeoutInMinutes property is set.
        /// </summary>
        internal bool IsSetSessionIdleTimeoutInMinutes() => this.SessionIdleTimeoutInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property WorkingDirectory. 
        /// <para>
        /// The Amazon S3 location that stores information for the notebook.
        /// </para>
        /// </summary>
        public string WorkingDirectory { get; set; }

        /// <summary>
        /// Checks to see if the WorkingDirectory property is set.
        /// </summary>
        internal bool IsSetWorkingDirectory() => this.WorkingDirectory != null;
    }
}
