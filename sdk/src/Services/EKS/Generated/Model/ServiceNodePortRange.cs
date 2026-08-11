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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The port range for Kubernetes NodePort services.
    /// </summary>
    public partial class ServiceNodePortRange
    {
        private int? _maxPort;
        private int? _minPort;

        /// <summary>
        /// Gets and sets the property MaxPort. 
        /// <para>
        /// The maximum port number in the range.
        /// </para>
        /// </summary>
        public int? MaxPort
        {
            get { return this._maxPort; }
            set { this._maxPort = value; }
        }

        // Check to see if MaxPort property is set
        internal bool IsSetMaxPort()
        {
            return this._maxPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinPort. 
        /// <para>
        /// The minimum port number in the range.
        /// </para>
        /// </summary>
        public int? MinPort
        {
            get { return this._minPort; }
            set { this._minPort = value; }
        }

        // Check to see if MinPort property is set
        internal bool IsSetMinPort()
        {
            return this._minPort.HasValue; 
        }

    }
}