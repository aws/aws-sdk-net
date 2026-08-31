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
    /// Container for the parameters to the UpdateCrossRegionRouting operation.
    /// Updates the cross-region routing configuration for an Amazon Connect Global Resiliency
    /// instance enabled for global routing. When invoked with <c>IsolatedAll</c> set to <c>true</c>,
    /// this operation disables cross-region routing, meaning contacts originating in one
    /// Region will no longer be routed to agents in another Region.
    /// 
    ///  <note> 
    /// <para>
    /// This operation is available only for Amazon Connect Global Resiliency instances enabled
    /// for global routing. Reporting and contact search continue to operate globally after
    /// you use this operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateCrossRegionRoutingRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private bool? _isolatedAll;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=250)]
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
        /// Gets and sets the property IsolatedAll. 
        /// <para>
        /// Set to <c>true</c> to disable cross-region routing for all Regions associated with
        /// this instance. Set to <c>false</c> to re-enable cross-region routing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? IsolatedAll
        {
            get { return this._isolatedAll; }
            set { this._isolatedAll = value; }
        }

        // Check to see if IsolatedAll property is set
        internal bool IsSetIsolatedAll()
        {
            return this._isolatedAll.HasValue; 
        }

    }
}