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

namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the DeleteCapacityProviderSession operation.
    /// </summary>
    public partial class DeleteCapacityProviderSessionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CapacityProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the capacity provider associated with the deleted
        /// session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CapacityProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the CapacityProviderArn property is set.
        /// </summary>
        internal bool IsSetCapacityProviderArn() => this.CapacityProviderArn != null;

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The unique identifier of the deleted capacity provider session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string SessionId { get; set; }

        /// <summary>
        /// Checks to see if the SessionId property is set.
        /// </summary>
        internal bool IsSetSessionId() => this.SessionId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the capacity provider session. When the status is <c>Deleting</c>,
        /// the session is being deleted and is not available. When the status is <c>Deleted</c>,
        /// the session is no longer available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CapacityProviderSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
