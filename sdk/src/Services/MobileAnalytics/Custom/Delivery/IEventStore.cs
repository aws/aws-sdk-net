//
// Copyright 2014-2015 Amazon.com, 
// Inc. or its affiliates. All Rights Reserved.
// 
// Licensed under the Amazon Software License (the "License"). 
// You may not use this file except in compliance with the 
// License. A copy of the License is located at
// 
//     http://aws.amazon.com/asl/
// 
// or in the "license" file accompanying this file. This file is 
// distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, express or implied. See the License 
// for the specific language governing permissions and 
// limitations under the License.
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ThirdParty.Json.LitJson;

namespace Amazon.MobileAnalytics.MobileAnalyticsManager.Internal
{
    
    /// <summary>
    /// The interface for managing events storage.
    /// </summary>
    public interface IEventStore
    {
        /// <summary>
        /// Add an event to the store.
        /// </summary>
        /// <param name="eventString">Amazon Mobile Analytics event in string.</param>
        /// <param name="appId">Amazon Mobile Analytics App ID.</param>
        /// <returns><c>true</c>, if event was put, <c>false</c> otherwise.</returns>
        bool PutEvent(string eventString, string appId);
        
        /// <summary>
        /// Get events from the Event Store
        /// </summary>
        /// <param name="appid">Amazon Mobile Analytics App Id.</param>
        /// <param name="maxAllowed">Max number of events is allowed to return.</param>
        /// <returns>The events as a List of <see cref="ThirdParty.Json.LitJson.JsonData"/>.</returns>
        List<JsonData> GetEvents(string appid, int maxAllowed);
        
        /// <summary>
        /// Deletes a list of events.
        /// </summary>
        /// <param name="rowIds">List of row identifiers.</param>
        /// <returns><c>true</c>, if events was deleted, <c>false</c> otherwise.</returns>
        bool DeleteEvent(List<string> rowIds);
        
        /// <summary>
        /// Gets Numbers the of events.
        /// </summary>
        /// <param name="appId">Amazon Mobile Analytics App Identifier.</param>
        /// <returns>The number of events.</returns>
        long NumberOfEvents(string appId);
        
        /// <summary>
        /// Gets the size of the database.
        /// </summary>
        /// <returns>The database size.</returns>
        long GetDatabaseSize();
        
    }
}

