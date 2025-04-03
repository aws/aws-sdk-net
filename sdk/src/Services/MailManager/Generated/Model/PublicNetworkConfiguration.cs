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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Specifies the network configuration for the public ingress point.
    /// </summary>
    public partial class PublicNetworkConfiguration
    {
        private IpType _ipType;

        /// <summary>
        /// Gets and sets the property IpType. 
        /// <para>
        /// The IP address type for the public ingress point. Valid values are IPV4 and DUAL_STACK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IpType IpType
        {
            get { return this._ipType; }
            set { this._ipType = value; }
        }

        // Check to see if IpType property is set
        internal bool IsSetIpType()
        {
            return this._ipType != null;
        }

    }
}