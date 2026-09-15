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

namespace Amazon.RestJsonProtocol.Model
{
#pragma warning disable CA1040
    /// <summary>
    /// Interface used to distinguish the events that can be sent to the service using the InputStreamWithInitialRequest service operation.
    /// The types that implement this interface are:
    /// <list type="bullet">
    ///   <item><term><see cref="BlobPayloadEvent"/></term></item>
    ///   <item><term><see cref="HeadersEvent"/></term></item>
    ///   <item><term><see cref="HeadersAndExplicitPayloadEvent"/></term></item>
    ///   <item><term><see cref="HeadersAndImplicitPayloadEvent"/></term></item>
    ///   <item><term><see cref="StringPayloadEvent"/></term></item>
    ///   <item><term><see cref="StructurePayloadEvent"/></term></item>
    ///   <item><term><see cref="UnionPayloadEvent"/></term></item>
    /// </list>
    /// </summary>
    public interface IEventStreamEvent
    {
    }
#pragma warning restore CA1040
}