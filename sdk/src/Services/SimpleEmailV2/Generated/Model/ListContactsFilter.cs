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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A filter that can be applied to a list of contacts.
    /// </summary>
    public partial class ListContactsFilter
    {
        private SubscriptionStatus _filteredStatus;
        private TopicFilter _topicFilter;

        /// <summary>
        /// Gets and sets the property FilteredStatus. 
        /// <para>
        /// The status by which you are filtering: <c>OPT_IN</c> or <c>OPT_OUT</c>.
        /// </para>
        /// </summary>
        public SubscriptionStatus FilteredStatus
        {
            get { return this._filteredStatus; }
            set { this._filteredStatus = value; }
        }

        // Check to see if FilteredStatus property is set
        internal bool IsSetFilteredStatus()
        {
            return this._filteredStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TopicFilter. 
        /// <para>
        /// Used for filtering by a specific topic preference.
        /// </para>
        /// </summary>
        public TopicFilter TopicFilter
        {
            get { return this._topicFilter; }
            set { this._topicFilter = value; }
        }

        // Check to see if TopicFilter property is set
        internal bool IsSetTopicFilter()
        {
            return this._topicFilter != null;
        }

    }
}