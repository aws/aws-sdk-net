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
    public partial class NodePropertyOverride
    {
        private ContainerOverrides _containerOverrides;
        private string _targetNodes;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// The overrides that should be sent to a node range.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property TargetNodes. 
        /// <para>
        /// The range of nodes, using node index values, with which to override. A range of <code>0:3</code>
        /// indicates nodes with index values of <code>0</code> through <code>3</code>. If the
        /// starting range value is omitted (<code>:n</code>), then <code>0</code> is used to
        /// start the range. If the ending range value is omitted (<code>n:</code>), then the
        /// highest possible node index is used to end the range.
        /// </para>
        /// </summary>
        public string TargetNodes
        {
            get { return this._targetNodes; }
            set { this._targetNodes = value; }
        }

        // Check to see if TargetNodes property is set
        internal bool IsSetTargetNodes()
        {
            return this._targetNodes != null;
        }

    }
}