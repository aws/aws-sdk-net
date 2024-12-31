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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a managed node's type.
    /// </summary>
    public partial class NodeType
    {
        private InstanceInfo _instance;

        /// <summary>
        /// Gets and sets the property Instance. 
        /// <para>
        /// Information about a specific managed node.
        /// </para>
        /// </summary>
        public InstanceInfo Instance
        {
            get { return this._instance; }
            set { this._instance = value; }
        }

        // Check to see if Instance property is set
        internal bool IsSetInstance()
        {
            return this._instance != null;
        }

    }
}