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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the DuplexStreamWithInitialMessages operation.
    /// 
    /// </summary>
    public partial class DuplexStreamWithInitialMessagesRequest : AmazonRestJsonProtocolRequest
    {
        private string _initialRequestMember;

        /// <summary>
        /// Gets and sets the property InitialRequestMember.
        /// </summary>
        [AWSProperty(Required=true)]
        public string InitialRequestMember
        {
            get { return this._initialRequestMember; }
            set { this._initialRequestMember = value; }
        }

        // Check to see if InitialRequestMember property is set
        internal bool IsSetInitialRequestMember()
        {
            return this._initialRequestMember != null;
        }

        /// <summary>
        /// Gets and sets the property StreamPublisher.
        /// <para>
        /// The Func set for this property by the consumer of the SDK is used to stream events into the service. Consumers
        /// provide a Func that the SDK will continue to call to get events to send. When the consumer is done streaming
        /// events to the service the Func can return null to stop the SDK calling the Func for new events. The Func must
        /// return an event known by the service which can be identified by implementing the IServiceEventStreamEvent
        /// interface. The known implementatons in the SDK for this interface are:
        /// <list type="bullet">
        ///   <item><term><see cref="BlobPayloadEvent"/></term></item>
        ///   <item><term><see cref="HeadersEvent"/></term></item>
        ///   <item><term><see cref="HeadersAndExplicitPayloadEvent"/></term></item>
        ///   <item><term><see cref="HeadersAndImplicitPayloadEvent"/></term></item>
        ///   <item><term><see cref="StringPayloadEvent"/></term></item>
        ///   <item><term><see cref="StructurePayloadEvent"/></term></item>
        ///   <item><term><see cref="UnionPayloadEvent"/></term></item>
        /// </list>
        /// </para>
        /// 
        /// </summary>
        public  Func<System.Threading.Tasks.Task<IServiceEventStreamEvent>> StreamPublisher { get; set; }

    }
}