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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the ListGroupResources operation.
    /// This operation returns a list of the ARNs of the canaries that are associated with
    /// the specified group.
    /// </summary>
    public partial class ListGroupResourcesRequest : AmazonSyntheticsRequest
    {
        private string _groupIdentifier;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GroupIdentifier. 
        /// <para>
        /// Specifies the group to return information for. You can specify the group name, the
        /// ARN, or the group ID as the <code>GroupIdentifier</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string GroupIdentifier
        {
            get { return this._groupIdentifier; }
            set { this._groupIdentifier = value; }
        }

        // Check to see if GroupIdentifier property is set
        internal bool IsSetGroupIdentifier()
        {
            return this._groupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specify this parameter to limit how many canary ARNs are returned each time you use
        /// the <code>ListGroupResources</code> operation. If you omit this parameter, the default
        /// of 20 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there is more data available. You can use this token in
        /// a subsequent operation to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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