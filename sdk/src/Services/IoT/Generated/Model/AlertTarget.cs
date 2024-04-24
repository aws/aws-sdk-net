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
    /// A structure containing the alert target ARN and the role ARN.
    /// </summary>
    public partial class AlertTarget
    {
        private string _alertTargetArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AlertTargetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the notification target to which alerts are sent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AlertTargetArn
        {
            get { return this._alertTargetArn; }
            set { this._alertTargetArn = value; }
        }

        // Check to see if AlertTargetArn property is set
        internal bool IsSetAlertTargetArn()
        {
            return this._alertTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to send alerts to the notification target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}