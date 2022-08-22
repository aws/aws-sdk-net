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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A ulimit to set in the container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsUlimitsDetails
    {
        private int? _hardLimit;
        private string _name;
        private int? _softLimit;

        /// <summary>
        /// Gets and sets the property HardLimit. 
        /// <para>
        /// The hard limit for the ulimit type.
        /// </para>
        /// </summary>
        public int HardLimit
        {
            get { return this._hardLimit.GetValueOrDefault(); }
            set { this._hardLimit = value; }
        }

        // Check to see if HardLimit property is set
        internal bool IsSetHardLimit()
        {
            return this._hardLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The type of the ulimit. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>core</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cpu</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>data</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fsize</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>locks</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>memlock</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>msgqueue</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>nice</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>nofile</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>nproc</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rss</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rtprio</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>rttime</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>sigpending</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>stack</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SoftLimit. 
        /// <para>
        /// The soft limit for the ulimit type.
        /// </para>
        /// </summary>
        public int SoftLimit
        {
            get { return this._softLimit.GetValueOrDefault(); }
            set { this._softLimit = value; }
        }

        // Check to see if SoftLimit property is set
        internal bool IsSetSoftLimit()
        {
            return this._softLimit.HasValue; 
        }

    }
}