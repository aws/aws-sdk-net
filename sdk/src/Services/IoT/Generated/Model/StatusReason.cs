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
    /// Provide additional context about the status of a command execution using a reason
    /// code and description.
    /// </summary>
    public partial class StatusReason
    {
        private string _reasonCode;
        private string _reasonDescription;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// A code that provides additional context for the command execution status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property ReasonDescription. 
        /// <para>
        /// A literal string for devices to optionally provide additional information about the
        /// reason code for a command execution status.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ReasonDescription
        {
            get { return this._reasonDescription; }
            set { this._reasonDescription = value; }
        }

        // Check to see if ReasonDescription property is set
        internal bool IsSetReasonDescription()
        {
            return this._reasonDescription != null;
        }

    }
}