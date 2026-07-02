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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Specifies a range of ports.
    /// </summary>
    public partial class PortRange
    {
        private int? _endPort;
        private int? _startPort;

        /// <summary>
        /// Gets and sets the property EndPort. 
        /// <para>
        /// The ending port number of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? EndPort
        {
            get { return this._endPort; }
            set { this._endPort = value; }
        }

        // Check to see if EndPort property is set
        internal bool IsSetEndPort()
        {
            return this._endPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartPort. 
        /// <para>
        /// The starting port number of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
        public int? StartPort
        {
            get { return this._startPort; }
            set { this._startPort = value; }
        }

        // Check to see if StartPort property is set
        internal bool IsSetStartPort()
        {
            return this._startPort.HasValue; 
        }

    }
}