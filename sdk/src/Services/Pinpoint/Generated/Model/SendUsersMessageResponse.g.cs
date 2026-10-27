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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Provides information about which users and endpoints a message was sent to.
    /// </summary>
    public partial class SendUsersMessageResponse
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier for the application that was used to send the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique identifier that was assigned to the message request.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// An object that indicates which endpoints the message was sent to, for each user. The
        /// object lists user IDs and, for each user ID, provides the endpoint IDs that the message
        /// was sent to. For each endpoint ID, it provides an EndpointMessageResult object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Dictionary<string, EndpointMessageResult>> Result { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Dictionary<string, EndpointMessageResult>>() : null;

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null && (this.Result.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
