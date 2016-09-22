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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    public partial class DescribeEventCategoriesResponse : AmazonWebServiceResponse
    {
        private List<EventCategoriesMap> _eventCategoriesMapList = new List<EventCategoriesMap>();

        /// <summary>
        /// Gets and sets the property EventCategoriesMapList. 
        /// <para>
        /// A list of event categories descriptions.
        /// </para>
        /// </summary>
        public List<EventCategoriesMap> EventCategoriesMapList
        {
            get { return this._eventCategoriesMapList; }
            set { this._eventCategoriesMapList = value; }
        }

        // Check to see if EventCategoriesMapList property is set
        internal bool IsSetEventCategoriesMapList()
        {
            return this._eventCategoriesMapList != null && this._eventCategoriesMapList.Count > 0; 
        }

    }
}