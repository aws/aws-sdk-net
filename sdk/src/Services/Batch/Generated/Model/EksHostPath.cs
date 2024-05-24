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
    /// Specifies the configuration of a Kubernetes <c>hostPath</c> volume. A <c>hostPath</c>
    /// volume mounts an existing file or directory from the host node's filesystem into your
    /// pod. For more information, see <a href="https://kubernetes.io/docs/concepts/storage/volumes/#hostpath">hostPath</a>
    /// in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksHostPath
    {
        private string _path;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path of the file or directory on the host to mount into containers on the pod.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

    }
}