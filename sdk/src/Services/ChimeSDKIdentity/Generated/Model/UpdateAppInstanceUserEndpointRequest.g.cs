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

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAppInstanceUserEndpoint operation. Updates
    /// the details of an <c>AppInstanceUserEndpoint</c>. You can update the name and <c>AllowMessage</c>
    /// values.
    /// </summary>
    public partial class UpdateAppInstanceUserEndpointRequest : AmazonChimeSDKIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property AllowMessages. 
        /// <para>
        /// Boolean that controls whether the <c>AppInstanceUserEndpoint</c> is opted in to receive
        /// messages. <c>ALL</c> indicates the endpoint will receive all messages. <c>NONE</c>
        /// indicates the endpoint will receive no messages.
        /// </para>
        /// </summary>
        public AllowMessages AllowMessages { get; set; }

        /// <summary>
        /// Checks to see if the AllowMessages property is set.
        /// </summary>
        internal bool IsSetAllowMessages() => this.AllowMessages != null;

        /// <summary>
        /// Gets and sets the property AppInstanceUserArn. 
        /// <para>
        /// The ARN of the <c>AppInstanceUser</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 1600)]
        public string AppInstanceUserArn { get; set; }

        /// <summary>
        /// Checks to see if the AppInstanceUserArn property is set.
        /// </summary>
        internal bool IsSetAppInstanceUserArn() => this.AppInstanceUserArn != null;

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The unique identifier of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string EndpointId { get; set; }

        /// <summary>
        /// Checks to see if the EndpointId property is set.
        /// </summary>
        internal bool IsSetEndpointId() => this.EndpointId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the <c>AppInstanceUserEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 1600)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
