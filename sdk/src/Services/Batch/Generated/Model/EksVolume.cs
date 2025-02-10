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
    /// Specifies an Amazon EKS volume for a job definition.
    /// </summary>
    public partial class EksVolume
    {
        private EksEmptyDir _emptyDir;
        private EksHostPath _hostPath;
        private string _name;
        private EksPersistentVolumeClaim _persistentVolumeClaim;
        private EksSecret _secret;

        /// <summary>
        /// Gets and sets the property EmptyDir. 
        /// <para>
        /// Specifies the configuration of a Kubernetes <c>emptyDir</c> volume. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#emptydir">emptyDir</a>
        /// in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksEmptyDir EmptyDir
        {
            get { return this._emptyDir; }
            set { this._emptyDir = value; }
        }

        // Check to see if EmptyDir property is set
        internal bool IsSetEmptyDir()
        {
            return this._emptyDir != null;
        }

        /// <summary>
        /// Gets and sets the property HostPath. 
        /// <para>
        /// Specifies the configuration of a Kubernetes <c>hostPath</c> volume. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#hostpath">hostPath</a>
        /// in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksHostPath HostPath
        {
            get { return this._hostPath; }
            set { this._hostPath = value; }
        }

        // Check to see if HostPath property is set
        internal bool IsSetHostPath()
        {
            return this._hostPath != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the volume. The name must be allowed as a DNS subdomain name. For more
        /// information, see <a href="https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#dns-subdomain-names">DNS
        /// subdomain names</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PersistentVolumeClaim. 
        /// <para>
        /// Specifies the configuration of a Kubernetes <c>persistentVolumeClaim</c> bounded to
        /// a <c>persistentVolume</c>. For more information, see <a href="https://kubernetes.io/docs/concepts/storage/persistent-volumes/#persistentvolumeclaims">
        /// Persistent Volume Claims</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksPersistentVolumeClaim PersistentVolumeClaim
        {
            get { return this._persistentVolumeClaim; }
            set { this._persistentVolumeClaim = value; }
        }

        // Check to see if PersistentVolumeClaim property is set
        internal bool IsSetPersistentVolumeClaim()
        {
            return this._persistentVolumeClaim != null;
        }

        /// <summary>
        /// Gets and sets the property Secret. 
        /// <para>
        /// Specifies the configuration of a Kubernetes <c>secret</c> volume. For more information,
        /// see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#secret">secret</a>
        /// in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public EksSecret Secret
        {
            get { return this._secret; }
            set { this._secret = value; }
        }

        // Check to see if Secret property is set
        internal bool IsSetSecret()
        {
            return this._secret != null;
        }

    }
}