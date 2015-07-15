/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mobileanalytics-2014-06-05.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.MobileAnalytics.Model;

namespace Amazon.MobileAnalytics
{
    /// <summary>
    /// Interface for accessing MobileAnalytics
    ///
    /// Amazon Mobile Analytics is a service for collecting, visualizing, and understanding
    /// app usage data at scale.
    /// </summary>
    public partial interface IAmazonMobileAnalytics : IDisposable
    {

        
        #region  PutEvents


        /// <summary>
        /// The PutEvents operation records one or more events. You can have up to 1,500 unique
        /// custom events per app, any combination of up to 40 attributes and metrics per custom
        /// event, and any number of attribute or metric values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvents service method.</param>
        /// 
        /// <returns>The response from the PutEvents service method, as returned by MobileAnalytics.</returns>
        /// <exception cref="Amazon.MobileAnalytics.Model.BadRequestException">
        /// An exception object returned when a request fails.
        /// </exception>
        PutEventsResponse PutEvents(PutEventsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvents operation on AmazonMobileAnalyticsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvents
        ///         operation.</returns>
        IAsyncResult BeginPutEvents(PutEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvents.</param>
        /// 
        /// <returns>Returns a  PutEventsResult from MobileAnalytics.</returns>
        PutEventsResponse EndPutEvents(IAsyncResult asyncResult);

        #endregion
        
    }
}