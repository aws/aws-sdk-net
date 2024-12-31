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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// The volume mounts for a container for an Amazon EKS job. For more information about
    /// volumes and volume mounts in Kubernetes, see <a href="https://kubernetes.io/docs/concepts/storage/volumes/">Volumes</a>
    /// in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksContainerVolumeMount
    {
        private string _mountPath;
        private string _name;
        private bool? _readOnly;
        private string _subPath;

        /// <summary>
        /// Gets and sets the property MountPath. 
        /// <para>
        /// The path on the container where the volume is mounted.
        /// </para>
        /// </summary>
        public string MountPath
        {
            get { return this._mountPath; }
            set { this._mountPath = value; }
        }

        // Check to see if MountPath property is set
        internal bool IsSetMountPath()
        {
            return this._mountPath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name the volume mount. This must match the name of one of the volumes in the pod.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// If this value is <c>true</c>, the container has read-only access to the volume. Otherwise,
        /// the container can write to the volume. The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? ReadOnly
        {
            get { return this._readOnly; }
            set { this._readOnly = value; }
        }

        // Check to see if ReadOnly property is set
        internal bool IsSetReadOnly()
        {
            return this._readOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubPath. 
        /// <para>
        /// A sub-path inside the referenced volume instead of its root.
        /// </para>
        /// </summary>
        public string SubPath
        {
            get { return this._subPath; }
            set { this._subPath = value; }
        }

        // Check to see if SubPath property is set
        internal bool IsSetSubPath()
        {
            return this._subPath != null;
        }

    }
}