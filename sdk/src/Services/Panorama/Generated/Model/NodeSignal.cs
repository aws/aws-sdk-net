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
 * Do not modify this file. This file is generated from the panorama-2019-07-24.normal.json service model.
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
namespace Amazon.Panorama.Model
{
    /// <summary>
    /// A signal to a camera node to start or stop processing video.
    /// </summary>
    public partial class NodeSignal
    {
        private string _nodeInstanceId;
        private NodeSignalValue _signal;

        /// <summary>
        /// Gets and sets the property NodeInstanceId. 
        /// <para>
        /// The camera node's name, from the application manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string NodeInstanceId
        {
            get { return this._nodeInstanceId; }
            set { this._nodeInstanceId = value; }
        }

        // Check to see if NodeInstanceId property is set
        internal bool IsSetNodeInstanceId()
        {
            return this._nodeInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Signal. 
        /// <para>
        /// The signal value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NodeSignalValue Signal
        {
            get { return this._signal; }
            set { this._signal = value; }
        }

        // Check to see if Signal property is set
        internal bool IsSetSignal()
        {
            return this._signal != null;
        }

    }
}