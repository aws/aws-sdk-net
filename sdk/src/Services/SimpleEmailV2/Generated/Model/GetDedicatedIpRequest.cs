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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetDedicatedIp operation.
    /// Get information about a dedicated IP address, including the name of the dedicated
    /// IP pool that it's associated with, as well information about the automatic warm-up
    /// process for the address.
    /// </summary>
    public partial class GetDedicatedIpRequest : AmazonSimpleEmailServiceV2Request
    {
        private string _ip;

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IP address that you want to obtain more information about. The value you specify
        /// has to be a dedicated IP address that's assocaited with your Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

    }
}