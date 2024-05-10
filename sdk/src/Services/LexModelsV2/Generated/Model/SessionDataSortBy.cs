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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// An object specifying the measure and method by which to sort the session analytics
    /// data.
    /// </summary>
    public partial class SessionDataSortBy
    {
        private AnalyticsSessionSortByName _name;
        private AnalyticsSortOrder _order;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The measure by which to sort the session analytics data.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>conversationStartTime</c> – The date and time when the conversation began. A conversation
        /// is defined as a unique combination of a <c>sessionId</c> and an <c>originatingRequestId</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>numberOfTurns</c> – The number of turns that the session took.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>conversationDurationSeconds</c> – The duration of the conversation in seconds.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsSessionSortByName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// Specifies whether to sort the results in ascending or descending order.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AnalyticsSortOrder Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

    }
}