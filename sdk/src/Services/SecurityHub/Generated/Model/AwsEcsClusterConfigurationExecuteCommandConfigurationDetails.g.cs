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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Contains the run command configuration for the cluster.
    /// </summary>
    public partial class AwsEcsClusterConfigurationExecuteCommandConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key that is used to encrypt the data between the local client
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
        /// The log configuration for the results of the run command actions. Required if <c>Logging</c>
        /// is <c>NONE</c>.
        /// </para>
        /// </summary>
        public AwsEcsClusterConfigurationExecuteCommandConfigurationLogConfigurationDetails LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Logging. 
        /// <para>
        /// The log setting to use for redirecting logs for run command results.
        /// </para>
        /// </summary>
        public string Logging { get; set; }

        /// <summary>
        /// Checks to see if the Logging property is set.
        /// </summary>
        internal bool IsSetLogging() => this.Logging != null;
    }
}
