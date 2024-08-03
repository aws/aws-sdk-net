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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Information about an instance type.
    /// </summary>
    public partial class InstanceTypeItem
    {
        private string _instanceType;
        private int? _vcpUs;

        /// <summary>
        /// Gets and sets the property InstanceType.
        /// </summary>
        public string InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property VCPUs. 
        /// <para>
        /// The number of default VCPUs in an instance type.
        /// </para>
        /// </summary>
        public int? VCPUs
        {
            get { return this._vcpUs; }
            set { this._vcpUs = value; }
        }

        // Check to see if VCPUs property is set
        internal bool IsSetVCPUs()
        {
            return this._vcpUs.HasValue; 
        }

    }
}