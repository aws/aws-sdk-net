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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The settings related to the multicast source.
    /// </summary>
    public partial class MulticastSourceSettings
    {
        private string _multicastSourceIp;

        /// <summary>
        /// Gets and sets the property MulticastSourceIp. 
        /// <para>
        ///  The IP address of the source for source-specific multicast (SSM).
        /// </para>
        /// </summary>
        public string MulticastSourceIp
        {
            get { return this._multicastSourceIp; }
            set { this._multicastSourceIp = value; }
        }

        // Check to see if MulticastSourceIp property is set
        internal bool IsSetMulticastSourceIp()
        {
            return this._multicastSourceIp != null;
        }

    }
}