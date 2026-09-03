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
    /// A <c>persistentVolumeClaim</c> volume is used to mount a <a href="https://kubernetes.io/docs/concepts/storage/persistent-volumes/">PersistentVolume</a>
    /// into a Pod. PersistentVolumeClaims are a way for users to "claim" durable storage
    /// without knowing the details of the particular cloud environment. See the information
    /// about <a href="https://kubernetes.io/docs/concepts/storage/persistent-volumes/">PersistentVolumes</a>
    /// in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksPersistentVolumeClaim
    {
        /// <summary>
        /// Gets and sets the property ClaimName. 
        /// <para>
        /// The name of the <c>persistentVolumeClaim</c> bounded to a <c>persistentVolume</c>.
        /// For more information, see <a href="https://kubernetes.io/docs/concepts/storage/persistent-volumes/#persistentvolumeclaims">
        /// Persistent Volume Claims</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClaimName { get; set; }

        /// <summary>
        /// Checks to see if the ClaimName property is set.
        /// </summary>
        internal bool IsSetClaimName() => this.ClaimName != null;

        /// <summary>
        /// Gets and sets the property ReadOnly. 
        /// <para>
        /// An optional boolean value indicating if the mount is read only. Default is false.
        /// For more information, see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#read-only-mounts">
        /// Read Only Mounts</a> in the <i>Kubernetes documentation</i>.
        /// </para>
        /// </summary>
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Checks to see if the ReadOnly property is set.
        /// </summary>
        internal bool IsSetReadOnly() => this.ReadOnly.HasValue;
    }
}
