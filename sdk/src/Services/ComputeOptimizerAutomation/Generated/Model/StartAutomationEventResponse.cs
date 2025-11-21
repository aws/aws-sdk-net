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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
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
namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// This is the response object from the StartAutomationEvent operation.
    /// </summary>
    public partial class StartAutomationEventResponse : AmazonWebServiceResponse
    {
        private string _eventId;
        private EventStatus _eventStatus;
        private string _recommendedActionId;

        /// <summary>
        /// Gets and sets the property EventId. 
        /// <para>
        /// The ID of the automation event.
        /// </para>
        /// </summary>
        public string EventId
        {
            get { return this._eventId; }
            set { this._eventId = value; }
        }

        // Check to see if EventId property is set
        internal bool IsSetEventId()
        {
            return this._eventId != null;
        }

        /// <summary>
        /// Gets and sets the property EventStatus. 
        /// <para>
        /// The current status of the automation event.
        /// </para>
        /// </summary>
        public EventStatus EventStatus
        {
            get { return this._eventStatus; }
            set { this._eventStatus = value; }
        }

        // Check to see if EventStatus property is set
        internal bool IsSetEventStatus()
        {
            return this._eventStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RecommendedActionId. 
        /// <para>
        /// The ID of the recommended action being automated.
        /// </para>
        /// </summary>
        public string RecommendedActionId
        {
            get { return this._recommendedActionId; }
            set { this._recommendedActionId = value; }
        }

        // Check to see if RecommendedActionId property is set
        internal bool IsSetRecommendedActionId()
        {
            return this._recommendedActionId != null;
        }

    }
}