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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para>Data returned from the <b>DescribeEventCategories</b> action.</para>
    /// </summary>
    public class DescribeEventCategoriesResult
    {
        
        private List<EventCategoriesMap> eventCategoriesMapList = new List<EventCategoriesMap>();

        /// <summary>
        /// A list of EventCategoriesMap data types.
        ///  
        /// </summary>
        public List<EventCategoriesMap> EventCategoriesMapList
        {
            get { return this.eventCategoriesMapList; }
            set { this.eventCategoriesMapList = value; }
        }
        /// <summary>
        /// Adds elements to the EventCategoriesMapList collection
        /// </summary>
        /// <param name="eventCategoriesMapList">The values to add to the EventCategoriesMapList collection </param>
        /// <returns>this instance</returns>
        public DescribeEventCategoriesResult WithEventCategoriesMapList(params EventCategoriesMap[] eventCategoriesMapList)
        {
            foreach (EventCategoriesMap element in eventCategoriesMapList)
            {
                this.eventCategoriesMapList.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the EventCategoriesMapList collection
        /// </summary>
        /// <param name="eventCategoriesMapList">The values to add to the EventCategoriesMapList collection </param>
        /// <returns>this instance</returns>
        public DescribeEventCategoriesResult WithEventCategoriesMapList(IEnumerable<EventCategoriesMap> eventCategoriesMapList)
        {
            foreach (EventCategoriesMap element in eventCategoriesMapList)
            {
                this.eventCategoriesMapList.Add(element);
            }

            return this;
        }

        // Check to see if EventCategoriesMapList property is set
        internal bool IsSetEventCategoriesMapList()
        {
            return this.eventCategoriesMapList.Count > 0;
        }
    }
}
