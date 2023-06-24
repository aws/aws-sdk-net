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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Managed scaling policy for an Amazon EMR cluster. The policy specifies the limits
    /// for resources that can be added or terminated from a cluster. The policy only applies
    /// to the core and task nodes. The master node cannot be scaled after initial configuration.
    /// </summary>
    public partial class ManagedScalingPolicy
    {
        private ComputeLimits _computeLimits;

        /// <summary>
        /// Gets and sets the property ComputeLimits. 
        /// <para>
        /// The Amazon EC2 unit limits for a managed scaling policy. The managed scaling activity
        /// of a cluster is not allowed to go above or below these limits. The limit only applies
        /// to the core and task nodes. The master node cannot be scaled after initial configuration.
        /// </para>
        /// </summary>
        public ComputeLimits ComputeLimits
        {
            get { return this._computeLimits; }
            set { this._computeLimits = value; }
        }

        // Check to see if ComputeLimits property is set
        internal bool IsSetComputeLimits()
        {
            return this._computeLimits != null;
        }

    }
}