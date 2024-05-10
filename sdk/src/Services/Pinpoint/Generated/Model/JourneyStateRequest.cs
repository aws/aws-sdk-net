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
    /// Changes the status of a journey.
    /// </summary>
    public partial class JourneyStateRequest
    {
        private State _state;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The status of the journey. Currently, Supported values are ACTIVE, PAUSED, and CANCELLED
        /// </para>
        ///  
        /// <para>
        /// If you cancel a journey, Amazon Pinpoint continues to perform activities that are
        /// currently in progress, until those activities are complete. Amazon Pinpoint also continues
        /// to collect and aggregate analytics data for those activities, until they are complete,
        /// and any activities that were complete when you cancelled the journey.
        /// </para>
        ///  
        /// <para>
        /// After you cancel a journey, you can't add, change, or remove any activities from the
        /// journey. In addition, Amazon Pinpoint stops evaluating the journey and doesn't perform
        /// any activities that haven't started.
        /// </para>
        ///  
        /// <para>
        /// When the journey is paused, Amazon Pinpoint continues to perform activities that are
        /// currently in progress, until those activities are complete. Endpoints will stop entering
        /// journeys when the journey is paused and will resume entering the journey after the
        /// journey is resumed. For wait activities, wait time is paused when the journey is paused.
        /// Currently, PAUSED only supports journeys with a segment refresh interval.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}