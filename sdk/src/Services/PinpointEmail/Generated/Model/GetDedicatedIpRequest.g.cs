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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetDedicatedIp operation. Get information about
    /// a dedicated IP address, including the name of the dedicated IP pool that it's associated
    /// with, as well information about the automatic warm-up process for the address.
    /// </summary>
    public partial class GetDedicatedIpRequest : AmazonPinpointEmailRequest
    {
        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IP address that you want to obtain more information about. The value you specify
        /// has to be a dedicated IP address that's assocaited with your Amazon Pinpoint account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Ip { get; set; }

        /// <summary>
        /// Checks to see if the Ip property is set.
        /// </summary>
        internal bool IsSetIp() => this.Ip != null;
    }
}
