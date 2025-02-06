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
    /// Container for the parameters to the DescribeContactFlow operation.
    /// Describes the specified flow.
    /// 
    ///  
    /// <para>
    /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
    /// Connect Flow language</a>.
    /// </para>
    ///  
    /// <para>
    /// Use the <c>$SAVED</c> alias in the request to describe the <c>SAVED</c> content of
    /// a Flow. For example, <c>arn:aws:.../contact-flow/{id}:$SAVED</c>. After a flow is
    /// published, <c>$SAVED</c> needs to be supplied to view saved content that has not been
    /// published.
    /// </para>
    ///  
    /// <para>
    /// Use <c>arn:aws:.../contact-flow/{id}:{version}</c> to retrieve the content of a specific
    /// flow version.
    /// </para>
    ///  
    /// <para>
    /// In the response, <b>Status</b> indicates the flow status as either <c>SAVED</c> or
    /// <c>PUBLISHED</c>. The <c>PUBLISHED</c> status will initiate validation on the content.
    /// <c>SAVED</c> does not initiate validation of the content. <c>SAVED</c> | <c>PUBLISHED</c>
    /// 
    /// </para>
    /// </summary>
    public partial class DescribeContactFlowRequest : AmazonConnectRequest
    {
        private string _contactFlowId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=500)]
        public string ContactFlowId
        {
            get { return this._contactFlowId; }
            set { this._contactFlowId = value; }
        }

        // Check to see if ContactFlowId property is set
        internal bool IsSetContactFlowId()
        {
            return this._contactFlowId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
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