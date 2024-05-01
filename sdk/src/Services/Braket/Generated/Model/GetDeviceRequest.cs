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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
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
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the GetDevice operation.
    /// Retrieves the devices available in Amazon Braket.
    /// 
    ///  <note> 
    /// <para>
    /// For backwards compatibility with older versions of BraketSchemas, OpenQASM information
    /// is omitted from GetDevice API calls. To get this information the user-agent needs
    /// to present a recent version of the BraketSchemas (1.8.0 or later). The Braket SDK
    /// automatically reports this for you. If you do not see OpenQASM results in the GetDevice
    /// response when using a Braket SDK, you may need to set AWS_EXECUTION_ENV environment
    /// variable to configure user-agent. See the code examples provided below for how to
    /// do this for the AWS CLI, Boto3, and the Go, Java, and JavaScript/TypeScript SDKs.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetDeviceRequest : AmazonBraketRequest
    {
        private string _deviceArn;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

    }
}