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

namespace Amazon.ConnectParticipant.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeView operation. Retrieves the view for
    /// the specified view token. <para> For security recommendations, see <a href="https://docs.aws.amazon.com/connect/latest/adminguide/security-best-practices.html#bp-security-chat">Connect
    /// Customer Chat security best practices</a>. </para>
    /// </summary>
    public partial class DescribeViewRequest : AmazonConnectParticipantRequest
    {
        /// <summary>
        /// Gets and sets the property ConnectionToken. 
        /// <para>
        /// The connection token.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ConnectionToken { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionToken property is set.
        /// </summary>
        internal bool IsSetConnectionToken() => this.ConnectionToken != null;

        /// <summary>
        /// Gets and sets the property ViewToken. 
        /// <para>
        /// An encrypted token originating from the interactive message of a ShowView block operation.
        /// Represents the desired view.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string ViewToken { get; set; }

        /// <summary>
        /// Checks to see if the ViewToken property is set.
        /// </summary>
        internal bool IsSetViewToken() => this.ViewToken != null;
    }
}
