﻿// /*******************************************************************************
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

using System.Diagnostics.CodeAnalysis;
using Amazon.Runtime.EventStreams;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The Continuation Event.
    /// </summary>
    public class ContinuationEvent : IS3Event
    {
        /// <summary>
        /// Constructs a Continuation Event.
        /// </summary>
        public ContinuationEvent()
        {
        }

        /// <summary>
        /// Constructs a Continuation Event.
        /// </summary>
        /// <param name="message"></param>
        [SuppressMessage("Microsoft.Usage", "CA1801", Justification = "Consistency.")]
        public ContinuationEvent(IEventStreamMessage message)
        {
        }
    }
}