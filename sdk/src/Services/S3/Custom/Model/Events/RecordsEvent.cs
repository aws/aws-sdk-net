// /*******************************************************************************
//  *  Copyright 2008-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//  *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
//  *  this file except in compliance with the License. A copy of the License is located at
//  *
//  *  http://aws.amazon.com/apache2.0
//  *
//  *  or in the "license" file accompanying this file.
//  *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
//  *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
//  *  specific language governing permissions and limitations under the License.
//  * *****************************************************************************
//  *    __  _    _  ___
//  *   (  )( \/\/ )/ __)
//  *   /__\ \    / \__ \
//  *  (_)(_) \/\/  (___/
//  *
//  *  AWS SDK for .NET
//  *
//  */

using System.IO;
using Amazon.Runtime.EventStreams;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The Records Event
    /// </summary>
    public class RecordsEvent : IS3Event
    {
        /// <summary>
        /// The byte array of partial, one or more result records.
        /// <para></para>
        /// Payload is a <see cref="Stream"/>, which is not thread-safe.
        /// </summary>
        public Stream Payload { get; set; }

        /// <summary>
        /// Constructs a RecordsEvent
        /// </summary>
        public RecordsEvent()
        {
        }

        /// <summary>
        /// Creates a new End Event.
        /// </summary>
        /// <param name="message"></param>
        public RecordsEvent(IEventStreamMessage message)
        {
            Payload = new MemoryStream(message.Payload);
        }
    }
}