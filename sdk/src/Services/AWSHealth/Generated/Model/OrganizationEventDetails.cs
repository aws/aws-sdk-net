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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Detailed information about an event. A combination of an <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_Event.html">Event</a>
    /// object, an <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_EventDescription.html">EventDescription</a>
    /// object, and additional metadata about the event. Returned by the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEventDetailsForOrganization.html">DescribeEventDetailsForOrganization</a>
    /// operation.
    /// </summary>
    public partial class OrganizationEventDetails
    {
        private string _awsAccountId;
        private Event _event;
        private EventDescription _eventDescription;
        private Dictionary<string, string> _eventMetadata = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The 12-digit Amazon Web Services account numbers that contains the affected entities.
        /// </para>
        /// </summary>
        [AWSProperty(Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Event.
        /// </summary>
        public Event Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventDescription.
        /// </summary>
        public EventDescription EventDescription
        {
            get { return this._eventDescription; }
            set { this._eventDescription = value; }
        }

        // Check to see if EventDescription property is set
        internal bool IsSetEventDescription()
        {
            return this._eventDescription != null;
        }

        /// <summary>
        /// Gets and sets the property EventMetadata. 
        /// <para>
        /// Additional metadata about the event.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> EventMetadata
        {
            get { return this._eventMetadata; }
            set { this._eventMetadata = value; }
        }

        // Check to see if EventMetadata property is set
        internal bool IsSetEventMetadata()
        {
            return this._eventMetadata != null && (this._eventMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}