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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// A result message containing a list of completed and failed managed actions.
    /// </summary>
    public partial class DescribeEnvironmentManagedActionHistoryResponse : AmazonWebServiceResponse
    {
        private List<ManagedActionHistoryItem> _managedActionHistoryItems = new List<ManagedActionHistoryItem>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ManagedActionHistoryItems. 
        /// <para>
        /// A list of completed and failed managed actions.
        /// </para>
        /// </summary>
        public List<ManagedActionHistoryItem> ManagedActionHistoryItems
        {
            get { return this._managedActionHistoryItems; }
            set { this._managedActionHistoryItems = value; }
        }

        // Check to see if ManagedActionHistoryItems property is set
        internal bool IsSetManagedActionHistoryItems()
        {
            return this._managedActionHistoryItems != null && this._managedActionHistoryItems.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that you pass to <a>DescribeEnvironmentManagedActionHistory</a>
        /// to get the next page of results.
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