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
using Amazon.MobileAnalytics.Model;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    /// <summary>
    /// The interface for delivery client.
    /// </summary>
    public partial interface IDeliveryClient
    {
        /// <summary>
        /// Attempts the delivery of events from local store to service.
        /// </summary>
        System.Threading.Tasks.Task AttemptDeliveryAsync();
    }
}

