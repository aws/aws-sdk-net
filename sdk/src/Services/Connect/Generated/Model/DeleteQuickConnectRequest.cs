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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteQuickConnect operation.
    /// Deletes a quick connect. 
    /// 
    ///  <important> 
    /// <para>
    /// After calling <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_DeleteUser.html">DeleteUser</a>,
    /// it's important to call <c>DeleteQuickConnect</c> to delete any records related to
    /// the deleted users. This will help you:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Avoid dangling resources that impact your service quotas.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Remove deleted users so they don't appear to agents as transfer options.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Avoid the disruption of other Amazon Connect processes, such as instance replication
    /// and syncing if you're using <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-connect-global-resiliency.html">Amazon
    /// Connect Global Resiliency</a>. 
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class DeleteQuickConnectRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private string _quickConnectId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property QuickConnectId. 
        /// <para>
        /// The identifier for the quick connect.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QuickConnectId
        {
            get { return this._quickConnectId; }
            set { this._quickConnectId = value; }
        }

        // Check to see if QuickConnectId property is set
        internal bool IsSetQuickConnectId()
        {
            return this._quickConnectId != null;
        }

    }
}