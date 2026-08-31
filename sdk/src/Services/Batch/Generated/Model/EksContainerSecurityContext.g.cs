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
    /// The security context for a job. For more information, see <a href="https://kubernetes.io/docs/tasks/configure-pod-container/security-context/">Configure
    /// a security context for a pod or container</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksContainerSecurityContext
    {
        /// <summary>
        /// Gets and sets the property AllowPrivilegeEscalation. 
        /// <para>
        /// Whether or not a container or a Kubernetes pod is allowed to gain more privileges
        /// than its parent process. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? AllowPrivilegeEscalation { get; set; }

        /// <summary>
        /// Checks to see if the AllowPrivilegeEscalation property is set.
        /// </summary>
        internal bool IsSetAllowPrivilegeEscalation() => this.AllowPrivilegeEscalation.HasValue;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is <c>true</c>, the container is given elevated permissions on
        /// the host container instance. The level of permissions are similar to the <c>root</c>
        /// user permissions. The default value is <c>false</c>. This parameter maps to <c>privileged</c>
        /// policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#privileged">Privileged
        /// pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property ReadOnlyRootFilesystem. 
        /// <para>
        /// When this parameter is <c>true</c>, the container is given read-only access to its
        /// root file system. The default value is <c>false</c>. This parameter maps to <c>ReadOnlyRootFilesystem</c>
        /// policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#volumes-and-file-systems">Volumes
        /// and file systems pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool? ReadOnlyRootFilesystem { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnlyRootFilesystem property is set.
        /// </summary>
        internal bool IsSetReadOnlyRootFilesystem() => this.ReadOnlyRootFilesystem.HasValue;

        /// <summary>
        /// Gets and sets the property RunAsGroup. 
        /// <para>
        /// When this parameter is specified, the container is run as the specified group ID (<c>gid</c>).
        /// If this parameter isn't specified, the default is the group that's specified in the
        /// image metadata. This parameter maps to <c>RunAsGroup</c> and <c>MustRunAs</c> policy
        /// in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
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
        /// When this parameter is specified, the container is run as a user with a <c>uid</c>
        /// other than 0. If this parameter isn't specified, so such rule is enforced. This parameter
        /// maps to <c>RunAsUser</c> and <c>MustRunAsNonRoot</c> policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
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
        /// When this parameter is specified, the container is run as the specified user ID (<c>uid</c>).
        /// If this parameter isn't specified, the default is the user that's specified in the
        /// image metadata. This parameter maps to <c>RunAsUser</c> and <c>MustRanAs</c> policy
        /// in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public long? RunAsUser { get; set; }

        /// <summary>
        /// Checks to see if the RunAsUser property is set.
        /// </summary>
        internal bool IsSetRunAsUser() => this.RunAsUser.HasValue;
    }
}
