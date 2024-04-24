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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
namespace Amazon.Chime.Model
{
    /// <summary>
    /// This is the response object from the GetEventsConfiguration operation.
    /// </summary>
    public partial class GetEventsConfigurationResponse : AmazonWebServiceResponse
    {
        private EventsConfiguration _eventsConfiguration;

        /// <summary>
        /// Gets and sets the property EventsConfiguration. 
        /// <para>
        /// The events configuration details.
        /// </para>
        /// </summary>
        public EventsConfiguration EventsConfiguration
        {
            get { return this._eventsConfiguration; }
            set { this._eventsConfiguration = value; }
        }

        // Check to see if EventsConfiguration property is set
        internal bool IsSetEventsConfiguration()
        {
            return this._eventsConfiguration != null;
        }

    }
}