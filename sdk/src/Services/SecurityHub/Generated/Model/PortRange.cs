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
    /// A range of ports.
    /// </summary>
    public partial class PortRange
    {
        private int? _begin;
        private int? _end;

        /// <summary>
        /// Gets and sets the property Begin. 
        /// <para>
        /// The first port in the port range.
        /// </para>
        /// </summary>
        public int? Begin
        {
            get { return this._begin; }
            set { this._begin = value; }
        }

        // Check to see if Begin property is set
        internal bool IsSetBegin()
        {
            return this._begin.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property End. 
        /// <para>
        /// The last port in the port range.
        /// </para>
        /// </summary>
        public int? End
        {
            get { return this._end; }
            set { this._end = value; }
        }

        // Check to see if End property is set
        internal bool IsSetEnd()
        {
            return this._end.HasValue; 
        }

    }
}