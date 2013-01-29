/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// <para> Paginated representation of a workflow history for a workflow execution. This is the up to date, complete and authoritative record of
    /// the events related to all tasks and events in the life of the workflow execution. </para>
    /// </summary>
    public class History
    {
        
        private List<HistoryEvent> events = new List<HistoryEvent>();
        private string nextPageToken;

        /// <summary>
        /// The list of history events.
        ///  
        /// </summary>
        public List<HistoryEvent> Events
        {
            get { return this.events; }
            set { this.events = value; }
        }
        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        public History WithEvents(params HistoryEvent[] events)
        {
            foreach (HistoryEvent element in events)
            {
                this.events.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the Events collection
        /// </summary>
        /// <param name="events">The values to add to the Events collection </param>
        /// <returns>this instance</returns>
        public History WithEvents(IEnumerable<HistoryEvent> events)
        {
            foreach (HistoryEvent element in events)
            {
                this.events.Add(element);
            }

            return this;
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this.events.Count > 0;
        }

        /// <summary>
        /// The token for the next page. If set, the history consists of more than one page and the next page can be retrieved by repeating the request
        /// with this token and all other arguments unchanged.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>0 - 2048</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this.nextPageToken; }
            set { this.nextPageToken = value; }
        }

        /// <summary>
        /// Sets the NextPageToken property
        /// </summary>
        /// <param name="nextPageToken">The value to set for the NextPageToken property </param>
        /// <returns>this instance</returns>
        public History WithNextPageToken(string nextPageToken)
        {
            this.nextPageToken = nextPageToken;
            return this;
        }
            

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this.nextPageToken != null;
        }
    }
}
