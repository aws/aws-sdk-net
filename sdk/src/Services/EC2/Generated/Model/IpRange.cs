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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an IPv4 range.
    /// </summary>
    public partial class IpRange
    {
        private string _cidrIp;
        private string _description;

        /// <summary>
        /// Gets and sets the property CidrIp. 
        /// <para>
        /// The IPv4 CIDR range. You can either specify a CIDR range or a source security group,
        /// not both. To specify a single IPv4 address, use the /32 prefix.
        /// </para>
        /// </summary>
        public string CidrIp
        {
            get { return this._cidrIp; }
            set { this._cidrIp = value; }
        }

        // Check to see if CidrIp property is set
        internal bool IsSetCidrIp()
        {
            return this._cidrIp != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the security group rule that references this IPv4 address range.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. Allowed characters are a-z, A-Z, 0-9,
        /// spaces, and ._-:/()#,@[]+=;{}!$*
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

    }
}