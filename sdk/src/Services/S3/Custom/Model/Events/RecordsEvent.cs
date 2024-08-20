// /*******************************************************************************
//  *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        /// <para>
        /// The byte array of partial, one or more result records. S3 Select doesn't 
        /// guarantee that a record will be self-contained in one record frame. To 
        /// ensure continuous streaming of data, S3 Select might split the same record 
        /// across multiple record frames instead of aggregating the results in memory. 
        /// Some S3 clients (for example, the SDK for Java) handle this behavior by creating 
        /// a <code>ByteStream</code> out of the response by default. Other clients might 
        /// not handle this behavior by default. In those cases, you must aggregate the 
        /// results on the client side and parse the response.
        /// </para><para>
        /// Payload is a <see cref="Stream"/>, which is not thread-safe.
        /// </para>
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