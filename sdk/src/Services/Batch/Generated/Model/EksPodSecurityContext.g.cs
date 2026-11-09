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
    /// The security context for the pod. The settings apply to all containers in the pod
    /// when the container does not specify an overriding value. For more information, see
    /// <a href="https://kubernetes.io/docs/tasks/configure-pod-container/security-context/#set-the-security-context-for-a-pod">Set
    /// the security context for a Pod</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksPodSecurityContext
    {
        /// <summary>
        /// Gets and sets the property FsGroup. 
        /// <para>
        /// A special supplemental group that is applied to all containers in the pod. Some volume
        /// types allow Kubernetes to change the ownership and permissions of the volume contents
        /// to this group when the volume is mounted. The supported value range is <c>0</c> through
        /// <c>2147483647</c>.
        /// </para>
        /// </summary>
        public long? FsGroup { get; set; }

        /// <summary>
        /// Checks to see if the FsGroup property is set.
        /// </summary>
        internal bool IsSetFsGroup() => this.FsGroup.HasValue;

        /// <summary>
        /// Gets and sets the property RunAsGroup. 
        /// <para>
        /// The primary group ID that runs containers in the pod when a container does not specify
        /// its own group ID. The supported value range is <c>0</c> through <c>2147483647</c>.
        /// </para>
        /// </summary>
        public long? RunAsGroup { get; set; }

        /// <summary>
        /// Checks to see if the RunAsGroup property is set.
        /// </summary>
        internal bool IsSetRunAsGroup() => this.RunAsGroup.HasValue;

        /// <summary>
        /// Gets and sets the property RunAsNonRoot. 
        /// <para>
        /// Specifies whether Kubernetes validates that containers in the pod don't run as the
        /// root user unless a container specifies an overriding value.
        /// </para>
        /// </summary>
        public bool? RunAsNonRoot { get; set; }

        /// <summary>
        /// Checks to see if the RunAsNonRoot property is set.
        /// </summary>
        internal bool IsSetRunAsNonRoot() => this.RunAsNonRoot.HasValue;

        /// <summary>
        /// Gets and sets the property RunAsUser. 
        /// <para>
        /// The user ID that runs containers in the pod when a container does not specify its
        /// own user ID. The supported value range is <c>0</c> through <c>2147483647</c>.
        /// </para>
        /// </summary>
        public long? RunAsUser { get; set; }

        /// <summary>
        /// Checks to see if the RunAsUser property is set.
        /// </summary>
        internal bool IsSetRunAsUser() => this.RunAsUser.HasValue;

        /// <summary>
        /// Gets and sets the property SeccompProfile. 
        /// <para>
        /// The default seccomp profile for containers in the pod. A container-level seccomp profile
        /// overrides this value.
        /// </para>
        /// </summary>
        public EksSeccompProfile SeccompProfile { get; set; }

        /// <summary>
        /// Checks to see if the SeccompProfile property is set.
        /// </summary>
        internal bool IsSetSeccompProfile() => this.SeccompProfile != null;
    }
}
