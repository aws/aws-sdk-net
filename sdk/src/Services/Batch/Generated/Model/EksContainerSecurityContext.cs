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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// The security context for a job. For more information, see <a href="https://kubernetes.io/docs/tasks/configure-pod-container/security-context/">Configure
    /// a security context for a pod or container</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksContainerSecurityContext
    {
        private bool? _privileged;
        private bool? _readOnlyRootFilesystem;
        private long? _runAsGroup;
        private bool? _runAsNonRoot;
        private long? _runAsUser;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// When this parameter is <code>true</code>, the container is given elevated permissions
        /// on the host container instance. The level of permissions are similar to the <code>root</code>
        /// user permissions. The default value is <code>false</code>. This parameter maps to
        /// <code>privileged</code> policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#privileged">Privileged
        /// pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool Privileged
        {
            get { return this._privileged.GetValueOrDefault(); }
            set { this._privileged = value; }
        }

        // Check to see if Privileged property is set
        internal bool IsSetPrivileged()
        {
            return this._privileged.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReadOnlyRootFilesystem. 
        /// <para>
        /// When this parameter is <code>true</code>, the container is given read-only access
        /// to its root file system. The default value is <code>false</code>. This parameter maps
        /// to <code>ReadOnlyRootFilesystem</code> policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#volumes-and-file-systems">Volumes
        /// and file systems pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool ReadOnlyRootFilesystem
        {
            get { return this._readOnlyRootFilesystem.GetValueOrDefault(); }
            set { this._readOnlyRootFilesystem = value; }
        }

        // Check to see if ReadOnlyRootFilesystem property is set
        internal bool IsSetReadOnlyRootFilesystem()
        {
            return this._readOnlyRootFilesystem.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunAsGroup. 
        /// <para>
        /// When this parameter is specified, the container is run as the specified group ID (<code>gid</code>).
        /// If this parameter isn't specified, the default is the group that's specified in the
        /// image metadata. This parameter maps to <code>RunAsGroup</code> and <code>MustRunAs</code>
        /// policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public long RunAsGroup
        {
            get { return this._runAsGroup.GetValueOrDefault(); }
            set { this._runAsGroup = value; }
        }

        // Check to see if RunAsGroup property is set
        internal bool IsSetRunAsGroup()
        {
            return this._runAsGroup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunAsNonRoot. 
        /// <para>
        /// When this parameter is specified, the container is run as a user with a <code>uid</code>
        /// other than 0. If this parameter isn't specified, so such rule is enforced. This parameter
        /// maps to <code>RunAsUser</code> and <code>MustRunAsNonRoot</code> policy in the <a
        /// href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool RunAsNonRoot
        {
            get { return this._runAsNonRoot.GetValueOrDefault(); }
            set { this._runAsNonRoot = value; }
        }

        // Check to see if RunAsNonRoot property is set
        internal bool IsSetRunAsNonRoot()
        {
            return this._runAsNonRoot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RunAsUser. 
        /// <para>
        /// When this parameter is specified, the container is run as the specified user ID (<code>uid</code>).
        /// If this parameter isn't specified, the default is the user that's specified in the
        /// image metadata. This parameter maps to <code>RunAsUser</code> and <code>MustRanAs</code>
        /// policy in the <a href="https://kubernetes.io/docs/concepts/security/pod-security-policy/#users-and-groups">Users
        /// and groups pod security policies</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public long RunAsUser
        {
            get { return this._runAsUser.GetValueOrDefault(); }
            set { this._runAsUser = value; }
        }

        // Check to see if RunAsUser property is set
        internal bool IsSetRunAsUser()
        {
            return this._runAsUser.HasValue; 
        }

    }
}