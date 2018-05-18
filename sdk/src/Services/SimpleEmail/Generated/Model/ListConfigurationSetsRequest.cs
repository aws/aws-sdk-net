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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Container for the parameters to the ListConfigurationSets operation.
    /// Provides a list of the configuration sets associated with your Amazon SES account
    /// in the current AWS Region. For information about using configuration sets, see <a
    /// href="http://docs.aws.amazon.com/ses/latest/DeveloperGuide/monitor-sending-activity.html">Monitoring
    /// Your Amazon SES Sending Activity</a> in the <i>Amazon SES Developer Guide.</i> 
    /// 
    ///  
    /// <para>
    /// You can execute this operation no more than once per second. This operation will return
    /// up to 1,000 configuration sets each time it is run. If your Amazon SES account has
    /// more than 1,000 configuration sets, this operation will also return a NextToken element.
    /// You can then execute the <code>ListConfigurationSets</code> operation again, passing
    /// the <code>NextToken</code> parameter and the value of the NextToken element to retrieve
    /// additional results.
    /// </para>
    /// </summary>
    public partial class ListConfigurationSetsRequest : AmazonSimpleEmailServiceRequest
    {
        private int? _maxItems;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// The number of configuration sets to return.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <code>ListConfigurationSets</code> to indicate
        /// the position of the configuration set in the configuration set list.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}