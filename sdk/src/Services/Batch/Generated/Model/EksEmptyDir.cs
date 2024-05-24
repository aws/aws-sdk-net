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
    /// Specifies the configuration of a Kubernetes <c>emptyDir</c> volume. An <c>emptyDir</c>
    /// volume is first created when a pod is assigned to a node. It exists as long as that
    /// pod is running on that node. The <c>emptyDir</c> volume is initially empty. All containers
    /// in the pod can read and write the files in the <c>emptyDir</c> volume. However, the
    /// <c>emptyDir</c> volume can be mounted at the same or different paths in each container.
    /// When a pod is removed from a node for any reason, the data in the <c>emptyDir</c>
    /// is deleted permanently. For more information, see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#emptydir">emptyDir</a>
    /// in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksEmptyDir
    {
        private string _medium;
        private string _sizeLimit;

        /// <summary>
        /// Gets and sets the property Medium. 
        /// <para>
        /// The medium to store the volume. The default value is an empty string, which uses the
        /// storage of the node.
        /// </para>
        ///  <dl> <dt>""</dt> <dd> 
        /// <para>
        ///  <b>(Default)</b> Use the disk storage of the node.
        /// </para>
        ///  </dd> <dt>"Memory"</dt> <dd> 
        /// <para>
        /// Use the <c>tmpfs</c> volume that's backed by the RAM of the node. Contents of the
        /// volume are lost when the node reboots, and any storage on the volume counts against
        /// the container's memory limit.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public string Medium
        {
            get { return this._medium; }
            set { this._medium = value; }
        }

        // Check to see if Medium property is set
        internal bool IsSetMedium()
        {
            return this._medium != null;
        }

        /// <summary>
        /// Gets and sets the property SizeLimit. 
        /// <para>
        /// The maximum size of the volume. By default, there's no maximum size defined.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SizeLimit
        {
            get { return this._sizeLimit; }
            set { this._sizeLimit = value; }
        }

        // Check to see if SizeLimit property is set
        internal bool IsSetSizeLimit()
        {
            return this._sizeLimit != null;
        }

    }
}