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
    /// Common Contract for S3 Events.
    /// </summary>
    [SuppressMessage("Microsoft.Design", "CA1040", Justification = "This interface exists to categorize S3 events, and provide future extensibility.")]
    public interface IS3Event : IEventStreamEvent
    {
    }
}