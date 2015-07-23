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
    public interface IDeliveryClient
    {
        /// <summary>
        /// Attempts the delivery of events from local store to service.
        /// </summary>
#if PCL || BCL45
        System.Threading.Tasks.Task AttemptDeliveryAsync();
#elif BCL35
        void AttemptDelivery();  
#endif
        
        /// <summary>
        /// Enqueues the events for delivery. The event is stored in an <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IEventStore"/>.
        /// </summary>
        /// <param name="eventObject">Event object. <see cref="Amazon.MobileAnalytics.Model.Event"/></param>
        void EnqueueEventsForDelivery(Amazon.MobileAnalytics.Model.Event eventObject);

        /// <summary>
        /// Sets custom policies to the delivery client. This will allow you to fine grain control on when an attempt should be made to deliver the events on the service.
        /// </summary>
        /// <param name="policy">An instance of <see cref="Amazon.MobileAnalytics.MobileAnalyticsManager.Internal.IDeliveryPolicy"/></param>
        void AddDeliveryPolicies(IDeliveryPolicy policy);
    }
}

