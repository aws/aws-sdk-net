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
    /// Container for the parameters to the UpdateContactFlowModuleContent operation.
    /// Updates specified flow module for the specified Amazon Connect instance. 
    /// 
    ///  
    /// <para>
    /// Use the <c>$SAVED</c> alias in the request to describe the <c>SAVED</c> content of
    /// a Flow. For example, <c>arn:aws:.../contact-flow/{id}:$SAVED</c>. After a flow is
    /// published, <c>$SAVED</c> needs to be supplied to view saved content that has not been
    /// published.
    /// </para>
    /// </summary>
    public partial class UpdateContactFlowModuleContentRequest : AmazonConnectRequest
    {
        private string _contactFlowModuleId;
        private string _content;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactFlowModuleId. 
        /// <para>
        /// The identifier of the flow module.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactFlowModuleId
        {
            get { return this._contactFlowModuleId; }
            set { this._contactFlowModuleId = value; }
        }

        // Check to see if ContactFlowModuleId property is set
        internal bool IsSetContactFlowModuleId()
        {
            return this._contactFlowModuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON string that represents the content of the flow. For an example, see <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language-example.html">Example
        /// flow in Amazon Connect Flow language</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

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

    }
}