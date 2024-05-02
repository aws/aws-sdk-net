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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Structure that contains <c>payloadVersion</c> and <c>targetArn</c>.
    /// </summary>
    public partial class ProvisioningHook
    {
        private string _payloadVersion;
        private string _targetArn;

        /// <summary>
        /// Gets and sets the property PayloadVersion. 
        /// <para>
        /// The payload that was sent to the target function.
        /// </para>
        ///  
        /// <para>
        ///  <i>Note:</i> Only Lambda functions are currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=32)]
        public string PayloadVersion
        {
            get { return this._payloadVersion; }
            set { this._payloadVersion = value; }
        }

        // Check to see if PayloadVersion property is set
        internal bool IsSetPayloadVersion()
        {
            return this._payloadVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TargetArn. 
        /// <para>
        /// The ARN of the target function.
        /// </para>
        ///  
        /// <para>
        ///  <i>Note:</i> Only Lambda functions are currently supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string TargetArn
        {
            get { return this._targetArn; }
            set { this._targetArn = value; }
        }

        // Check to see if TargetArn property is set
        internal bool IsSetTargetArn()
        {
            return this._targetArn != null;
        }

    }
}