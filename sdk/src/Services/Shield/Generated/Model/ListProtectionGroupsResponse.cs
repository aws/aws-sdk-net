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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// This is the response object from the ListProtectionGroups operation.
    /// </summary>
    public partial class ListProtectionGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProtectionGroup> _protectionGroups = new List<ProtectionGroup>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <code>MaxResults</code> and you have more protection groups
        /// than the value of MaxResults, AWS Shield Advanced returns this token that you can
        /// use in your next request, to get the next batch of objects. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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

        /// <summary>
        /// Gets and sets the property ProtectionGroups.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProtectionGroup> ProtectionGroups
        {
            get { return this._protectionGroups; }
            set { this._protectionGroups = value; }
        }

        // Check to see if ProtectionGroups property is set
        internal bool IsSetProtectionGroups()
        {
            return this._protectionGroups != null && this._protectionGroups.Count > 0; 
        }

    }
}