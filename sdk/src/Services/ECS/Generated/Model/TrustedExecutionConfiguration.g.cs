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
    /// The trusted execution configuration for a task. This configuration controls the isolation
    /// mode and attestation policy. You set this configuration when you register a task definition.
    /// 
    ///  <note> 
    /// <para>
    /// Trusted execution is supported only for Amazon ECS Managed Instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class TrustedExecutionConfiguration
    {
        /// <summary>
        /// Gets and sets the property AttestationPolicy. 
        /// <para>
        /// The base64-encoded attestation policy envelope for the task. The policy specifies
        /// which containers are allowed to run and the runtime configuration that is cryptographically
        /// attested. This parameter is required when <c>isolationMode</c> is <c>CONFIDENTIAL_SANDBOX</c>.
        /// </para>
        /// </summary>
        public string AttestationPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AttestationPolicy property is set.
        /// </summary>
        internal bool IsSetAttestationPolicy() => this.AttestationPolicy != null;

        /// <summary>
        /// Gets and sets the property IsolationMode. 
        /// <para>
        /// The isolation mode for tasks that use this task definition. The isolation mode determines
        /// how a task is isolated from other tasks on the same Amazon EC2 instance.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SHARED</c>: The task shares the underlying Amazon EC2 instance with other tasks.
        /// This is the default isolation mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ISOLATED_SANDBOX</c>: The task runs in its own <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/amazon-ec2-nitro-sandboxes.html">Nitro
        /// Sandbox</a>, which is a lightweight virtual machine that is isolated by the Amazon
        /// Web Services Nitro System. Each task's sandbox is isolated from every other task's
        /// sandbox on the same Amazon EC2 instance, so one task can't access another task's memory
        /// or storage. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/isolated-confidential-tasks.html">Isolated
        /// and confidential tasks</a> in <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFIDENTIAL_SANDBOX</c>: The task runs in its own <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/amazon-ec2-nitro-sandboxes.html">Nitro
        /// Sandbox</a>, which is a lightweight virtual machine that is isolated by the Amazon
        /// Web Services Nitro System, with cryptographic attestation. The host can't access the
        /// sandbox's memory or storage, and only the approved workload can decrypt data that
        /// you encrypt with your Key Management Service key. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/isolated-confidential-tasks.html">Isolated
        /// and confidential tasks</a> in <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public IsolationMode IsolationMode { get; set; }

        /// <summary>
        /// Checks to see if the IsolationMode property is set.
        /// </summary>
        internal bool IsSetIsolationMode() => this.IsolationMode != null;
    }
}
