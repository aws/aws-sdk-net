/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the settings for events that cause a campaign to be sent.
    /// </summary>
    public partial class CampaignEventFilter
    {
        private EventDimensions _dimensions;
        private FilterType _filterType;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimension settings of the event filter for the campaign.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of event that causes the campaign to be sent. Valid values are: SYSTEM, sends
        /// the campaign when a system event occurs; and, ENDPOINT, sends the campaign when an
        /// endpoint event (<link  linkend="apps-application-id-events">Events</link> resource)
        /// occurs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FilterType FilterType
        {
            get { return this._filterType; }
            set { this._filterType = value; }
        }

        // Check to see if FilterType property is set
        internal bool IsSetFilterType()
        {
            return this._filterType != null;
        }

    }
}