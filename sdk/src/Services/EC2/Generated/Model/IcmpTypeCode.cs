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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the ICMP type and code.
    /// </summary>
    public partial class IcmpTypeCode
    {
        private int? _code;
        private int? _type;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The ICMP code. A value of -1 means all codes for the specified ICMP type.
        /// </para>
        /// </summary>
        public int Code
        {
            get { return this._code.GetValueOrDefault(); }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The ICMP type. A value of -1 means all types.
        /// </para>
        /// </summary>
        public int Type
        {
            get { return this._type.GetValueOrDefault(); }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type.HasValue; 
        }

    }
}