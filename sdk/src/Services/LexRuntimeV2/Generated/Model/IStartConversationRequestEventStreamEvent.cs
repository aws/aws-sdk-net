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
 * Do not modify this file. This file is generated from the runtime.lex.v2-2020-08-07.normal.json service model.
 */

namespace Amazon.LexRuntimeV2.Model
{
#pragma warning disable CA1040
    /// <summary>
    /// Interface used to distinguish the events that can be sent to the service using the StartConversation service operation.
    /// The types that implement this interface are:
    /// <list type="bullet">
    ///   <item><term><see cref="AudioInputEvent"/></term></item>
    ///   <item><term><see cref="ConfigurationEvent"/></term></item>
    ///   <item><term><see cref="DisconnectionEvent"/></term></item>
    ///   <item><term><see cref="DTMFInputEvent"/></term></item>
    ///   <item><term><see cref="PlaybackCompletionEvent"/></term></item>
    ///   <item><term><see cref="TextInputEvent"/></term></item>
    /// </list>
    /// </summary>
    public interface IStartConversationRequestEventStreamEvent
    {
    }
#pragma warning restore CA1040
}