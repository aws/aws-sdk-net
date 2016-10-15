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
 * Do not modify this file. This file is generated from the ec2-2016-09-15.normal.json service model.
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
    /// Container for the parameters to the GetConsoleScreenshot operation.
    /// Retrieve a JPG-format screenshot of a running instance to help with troubleshooting.
    /// 
    ///  
    /// <para>
    /// The returned content is Base64-encoded.
    /// </para>
    /// </summary>
    public partial class GetConsoleScreenshotRequest : AmazonEC2Request
    {
        private string _instanceId;
        private bool? _wakeUp;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property WakeUp. 
        /// <para>
        /// When set to <code>true</code>, acts as keystroke input and wakes up an instance that's
        /// in standby or "sleep" mode.
        /// </para>
        /// </summary>
        public bool WakeUp
        {
            get { return this._wakeUp.GetValueOrDefault(); }
            set { this._wakeUp = value; }
        }

        // Check to see if WakeUp property is set
        internal bool IsSetWakeUp()
        {
            return this._wakeUp.HasValue; 
        }

    }
}