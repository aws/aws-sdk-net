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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Contains a list of event sources (see <a>API_EventSourceConfiguration</a>)
    /// </summary>
    public partial class ListEventSourcesResult : AmazonWebServiceResponse
    {
        private List<EventSourceConfiguration> _eventSources = new List<EventSourceConfiguration>();
        private string _nextMarker;

        /// <summary>
        /// Gets and sets the property EventSources. 
        /// <para>
        /// An arrary of <code>EventSourceConfiguration</code> objects.
        /// </para>
        /// </summary>
        public List<EventSourceConfiguration> EventSources
        {
            get { return this._eventSources; }
            set { this._eventSources = value; }
        }

        // Check to see if EventSources property is set
        internal bool IsSetEventSources()
        {
            return this._eventSources != null && this._eventSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// A string, present if there are more event source mappings.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

    }
}