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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeEventSubscriptionsResult
    {
        private List<EventSubscription> _eventSubscriptionsList = new List<EventSubscription>();
        private string _marker;


        /// <summary>
        /// Gets and sets the property EventSubscriptionsList. 
        /// <para>
        /// A list of event subscriptions.
        /// </para>
        /// </summary>
        public List<EventSubscription> EventSubscriptionsList
        {
            get { return this._eventSubscriptionsList; }
            set { this._eventSubscriptionsList = value; }
        }

        /// <summary>
        /// Sets the EventSubscriptionsList property
        /// </summary>
        /// <param name="eventSubscriptionsList">The values to add to the EventSubscriptionsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventSubscriptionsResult WithEventSubscriptionsList(params EventSubscription[] eventSubscriptionsList)
        {
            foreach (var element in eventSubscriptionsList)
            {
                this._eventSubscriptionsList.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the EventSubscriptionsList property
        /// </summary>
        /// <param name="eventSubscriptionsList">The values to add to the EventSubscriptionsList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventSubscriptionsResult WithEventSubscriptionsList(IEnumerable<EventSubscription> eventSubscriptionsList)
        {
            foreach (var element in eventSubscriptionsList)
            {
                this._eventSubscriptionsList.Add(element);
            }
            return this;
        }
        // Check to see if EventSubscriptionsList property is set
        internal bool IsSetEventSubscriptionsList()
        {
            return this._eventSubscriptionsList != null && this._eventSubscriptionsList.Count > 0; 
        }


        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///             A value that indicates the starting point for the next set of response
        /// records in a subsequent request.             If a value is returned in a response,
        /// you can retrieve the next set of records by providing this returned             marker
        /// value in the <code>Marker</code> parameter and retrying the command. If the <code>Marker</code>
        /// field            is empty, all response records have been retrieved for the request.
        ///        
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }


        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEventSubscriptionsResult WithMarker(string marker)
        {
            this._marker = marker;
            return this;
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}