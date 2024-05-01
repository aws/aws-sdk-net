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

#pragma warning disable CS0612,CS0618,CS1570
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
        public int? HardLimit
        {
            get { return this._hardLimit; }
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
        ///  <c>core</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cpu</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>data</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fsize</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>locks</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>memlock</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>msgqueue</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nice</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nofile</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>nproc</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rss</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rtprio</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rttime</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sigpending</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stack</c> 
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
        public int? SoftLimit
        {
            get { return this._softLimit; }
            set { this._softLimit = value; }
        }

        // Check to see if SoftLimit property is set
        internal bool IsSetSoftLimit()
        {
            return this._softLimit.HasValue; 
        }

    }
}