/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Object representing any node overrides to a job definition that is used in a <a>SubmitJob</a>
    /// API operation.
    /// </summary>
    public partial class NodeOverrides
    {
        private List<NodePropertyOverride> _nodePropertyOverrides = new List<NodePropertyOverride>();

        /// <summary>
        /// Gets and sets the property NodePropertyOverrides. 
        /// <para>
        /// The node property overrides for the job.
        /// </para>
        /// </summary>
        public List<NodePropertyOverride> NodePropertyOverrides
        {
            get { return this._nodePropertyOverrides; }
            set { this._nodePropertyOverrides = value; }
        }

        // Check to see if NodePropertyOverrides property is set
        internal bool IsSetNodePropertyOverrides()
        {
            return this._nodePropertyOverrides != null && this._nodePropertyOverrides.Count > 0; 
        }

    }
}