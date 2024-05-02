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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// This is the response object from the CreateMonitor operation.
    /// </summary>
    public partial class CreateMonitorResponse : AmazonWebServiceResponse
    {
        private string _identityCenterApplicationArn;
        private string _monitorId;

        /// <summary>
        /// Gets and sets the property IdentityCenterApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that IAM Identity Center assigns to the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IdentityCenterApplicationArn
        {
            get { return this._identityCenterApplicationArn; }
            set { this._identityCenterApplicationArn = value; }
        }

        // Check to see if IdentityCenterApplicationArn property is set
        internal bool IsSetIdentityCenterApplicationArn()
        {
            return this._identityCenterApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property MonitorId. 
        /// <para>
        /// The unique identifier of the monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MonitorId
        {
            get { return this._monitorId; }
            set { this._monitorId = value; }
        }

        // Check to see if MonitorId property is set
        internal bool IsSetMonitorId()
        {
            return this._monitorId != null;
        }

    }
}