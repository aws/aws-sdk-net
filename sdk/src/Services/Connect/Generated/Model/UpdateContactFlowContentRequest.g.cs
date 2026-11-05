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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateContactFlowContent operation. Updates the
    /// specified flow. <para> You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Connect
    /// Customer Flow language</a>. </para> <para> Use the <c>$SAVED</c> alias in the request
    /// to describe the <c>SAVED</c> content of a Flow. For example, <c>arn:aws:.../contact-flow/{id}:$SAVED</c>.
    /// After a flow is published, <c>$SAVED</c> needs to be supplied to view saved content
    /// that has not been published. </para>
    /// </summary>
    public partial class UpdateContactFlowContentRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ContactFlowId. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 500)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// Checks to see if the ContactFlowId property is set.
        /// </summary>
        internal bool IsSetContactFlowId() => this.ContactFlowId != null;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The JSON string that represents the content of the flow. For an example, see <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language-example.html">Example
        /// flow in Connect Customer Flow language</a>. 
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum length of 1. Maximum length of 256000.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;
    }
}
