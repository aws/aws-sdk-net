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
    /// The type and amount of resources to assign to a container. The supported resources
    /// include <code>memory</code>, <code>cpu</code>, and <code>nvidia.com/gpu</code>. For
    /// more information, see <a href="https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/">Resource
    /// management for pods and containers</a> in the <i>Kubernetes documentation</i>.
    /// </summary>
    public partial class EksContainerResourceRequirements
    {
        private Dictionary<string, string> _limits = new Dictionary<string, string>();
        private Dictionary<string, string> _requests = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Limits. 
        /// <para>
        /// The type and quantity of the resources to reserve for the container. The values vary
        /// based on the <code>name</code> that's specified. Resources can be requested using
        /// either the <code>limits</code> or the <code>requests</code> objects.
        /// </para>
        ///  <dl> <dt>memory</dt> <dd> 
        /// <para>
        /// The memory hard limit (in MiB) for the container, using whole integers, with a "Mi"
        /// suffix. If your container attempts to exceed the memory specified, the container is
        /// terminated. You must specify at least 4 MiB of memory for a job. <code>memory</code>
        /// can be specified in <code>limits</code>, <code>requests</code>, or both. If <code>memory</code>
        /// is specified in both places, then the value that's specified in <code>limits</code>
        /// must be equal to the value that's specified in <code>requests</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// To maximize your resource utilization, provide your jobs with as much memory as possible
        /// for the specific instance type that you are using. To learn how, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// management</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> </dd> <dt>cpu</dt> <dd> 
        /// <para>
        /// The number of CPUs that's reserved for the container. Values must be an even multiple
        /// of <code>0.25</code>. <code>cpu</code> can be specified in <code>limits</code>, <code>requests</code>,
        /// or both. If <code>cpu</code> is specified in both places, then the value that's specified
        /// in <code>limits</code> must be at least as large as the value that's specified in
        /// <code>requests</code>.
        /// </para>
        ///  </dd> <dt>nvidia.com/gpu</dt> <dd> 
        /// <para>
        /// The number of GPUs that's reserved for the container. Values must be a whole integer.
        /// <code>memory</code> can be specified in <code>limits</code>, <code>requests</code>,
        /// or both. If <code>memory</code> is specified in both places, then the value that's
        /// specified in <code>limits</code> must be equal to the value that's specified in <code>requests</code>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public Dictionary<string, string> Limits
        {
            get { return this._limits; }
            set { this._limits = value; }
        }

        // Check to see if Limits property is set
        internal bool IsSetLimits()
        {
            return this._limits != null && this._limits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Requests. 
        /// <para>
        /// The type and quantity of the resources to request for the container. The values vary
        /// based on the <code>name</code> that's specified. Resources can be requested by using
        /// either the <code>limits</code> or the <code>requests</code> objects.
        /// </para>
        ///  <dl> <dt>memory</dt> <dd> 
        /// <para>
        /// The memory hard limit (in MiB) for the container, using whole integers, with a "Mi"
        /// suffix. If your container attempts to exceed the memory specified, the container is
        /// terminated. You must specify at least 4 MiB of memory for a job. <code>memory</code>
        /// can be specified in <code>limits</code>, <code>requests</code>, or both. If <code>memory</code>
        /// is specified in both, then the value that's specified in <code>limits</code> must
        /// be equal to the value that's specified in <code>requests</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you're trying to maximize your resource utilization by providing your jobs as much
        /// memory as possible for a particular instance type, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/memory-management.html">Memory
        /// management</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  </note> </dd> <dt>cpu</dt> <dd> 
        /// <para>
        /// The number of CPUs that are reserved for the container. Values must be an even multiple
        /// of <code>0.25</code>. <code>cpu</code> can be specified in <code>limits</code>, <code>requests</code>,
        /// or both. If <code>cpu</code> is specified in both, then the value that's specified
        /// in <code>limits</code> must be at least as large as the value that's specified in
        /// <code>requests</code>.
        /// </para>
        ///  </dd> <dt>nvidia.com/gpu</dt> <dd> 
        /// <para>
        /// The number of GPUs that are reserved for the container. Values must be a whole integer.
        /// <code>nvidia.com/gpu</code> can be specified in <code>limits</code>, <code>requests</code>,
        /// or both. If <code>nvidia.com/gpu</code> is specified in both, then the value that's
        /// specified in <code>limits</code> must be equal to the value that's specified in <code>requests</code>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public Dictionary<string, string> Requests
        {
            get { return this._requests; }
            set { this._requests = value; }
        }

        // Check to see if Requests property is set
        internal bool IsSetRequests()
        {
            return this._requests != null && this._requests.Count > 0; 
        }

    }
}