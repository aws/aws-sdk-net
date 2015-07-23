/*
 * Copyright 2015-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal   
{
    /// <summary>
    /// Exception thrown by the SDK for errors that occur within the Mobile Analytics event store.
    /// </summary>
    public class EventStoreException : Exception
    {
        
        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.EventStoreException"/>
        /// </summary>
        /// <param name="message">Exception message.</param>
        public EventStoreException(string message) : base(message) { }

        /// <summary>
        /// Constructor of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.EventStoreException"/>
        /// </summary>
        /// <param name="message">Exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public EventStoreException(string message, Exception innerException) : base(message, innerException) { }
    }
} 
