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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The Linux seccomp profile for a pod or container. For more information, see <a href="https://kubernetes.io/docs/tutorials/security/seccomp/">Restrict
    /// a Container's Syscalls with seccomp</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksSeccompProfile
    {
        /// <summary>
        /// Gets and sets the property LocalhostProfile. 
        /// <para>
        /// The path of the profile on the node, relative to the configured seccomp profile location.
        /// You must specify this parameter when <c>type</c> is <c>Localhost</c>. Don't set this
        /// parameter for any other type. You are responsible for ensuring that the profile exists
        /// on every eligible worker node. For information about providing files to Amazon EKS
        /// nodes, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/eks-launch-templates.html">Use
        /// a launch template with Batch on Amazon EKS</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4095)]
        public string LocalhostProfile { get; set; }

        /// <summary>
        /// Checks to see if the LocalhostProfile property is set.
        /// </summary>
        internal bool IsSetLocalhostProfile() => this.LocalhostProfile != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The seccomp profile type can be one of the following values:
        /// </para>
        ///  <dl> <dt>RuntimeDefault</dt> <dd> 
        /// <para>
        /// The <c>RuntimeDefault</c> value uses the container runtime's default seccomp profile.
        /// </para>
        ///  </dd> <dt>Unconfined</dt> <dd> 
        /// <para>
        /// The <c>Unconfined</c> value doesn't filter the container with seccomp.
        /// </para>
        ///  </dd> <dt>Localhost</dt> <dd> 
        /// <para>
        /// The <c>Localhost</c> value uses a custom profile at the path specified by <c>localhostProfile</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public EksSeccompProfileType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
