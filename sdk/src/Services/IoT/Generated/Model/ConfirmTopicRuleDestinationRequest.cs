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
    /// Container for the parameters to the ConfirmTopicRuleDestination operation.
    /// Confirms a topic rule destination. When you create a rule requiring a destination,
    /// IoT sends a confirmation message to the endpoint or base address you specify. The
    /// message includes a token which you pass back when calling <c>ConfirmTopicRuleDestination</c>
    /// to confirm that you own or have access to the endpoint.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ConfirmTopicRuleDestination</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class ConfirmTopicRuleDestinationRequest : AmazonIoTRequest
    {
        private string _confirmationToken;

        /// <summary>
        /// Gets and sets the property ConfirmationToken. 
        /// <para>
        /// The token used to confirm ownership or access to the topic rule confirmation URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConfirmationToken
        {
            get { return this._confirmationToken; }
            set { this._confirmationToken = value; }
        }

        // Check to see if ConfirmationToken property is set
        internal bool IsSetConfirmationToken()
        {
            return this._confirmationToken != null;
        }

    }
}