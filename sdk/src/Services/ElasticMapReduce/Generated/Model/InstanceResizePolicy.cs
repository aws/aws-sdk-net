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
    /// Custom policy for requesting termination protection or termination of specific instances
    /// when shrinking an instance group.
    /// </summary>
    public partial class InstanceResizePolicy
    {
        private List<string> _instancesToProtect = new List<string>();
        private List<string> _instancesToTerminate = new List<string>();
        private int? _instanceTerminationTimeout;

        /// <summary>
        /// Gets and sets the property InstancesToProtect. 
        /// <para>
        /// Specific list of instances to be protected when shrinking an instance group.
        /// </para>
        /// </summary>
        public List<string> InstancesToProtect
        {
            get { return this._instancesToProtect; }
            set { this._instancesToProtect = value; }
        }

        // Check to see if InstancesToProtect property is set
        internal bool IsSetInstancesToProtect()
        {
            return this._instancesToProtect != null && this._instancesToProtect.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstancesToTerminate. 
        /// <para>
        /// Specific list of instances to be terminated when shrinking an instance group.
        /// </para>
        /// </summary>
        public List<string> InstancesToTerminate
        {
            get { return this._instancesToTerminate; }
            set { this._instancesToTerminate = value; }
        }

        // Check to see if InstancesToTerminate property is set
        internal bool IsSetInstancesToTerminate()
        {
            return this._instancesToTerminate != null && this._instancesToTerminate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceTerminationTimeout. 
        /// <para>
        /// Decommissioning timeout override for the specific list of instances to be terminated.
        /// </para>
        /// </summary>
        public int InstanceTerminationTimeout
        {
            get { return this._instanceTerminationTimeout.GetValueOrDefault(); }
            set { this._instanceTerminationTimeout = value; }
        }

        // Check to see if InstanceTerminationTimeout property is set
        internal bool IsSetInstanceTerminationTimeout()
        {
            return this._instanceTerminationTimeout.HasValue; 
        }

    }
}