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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// Lists tags that are attached to the specified resource.
    /// 
    ///  
    /// <para>
    /// You can attach tags to the following resources in AWS Organizations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// AWS account
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organization root
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Organizational unit (OU)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Policy (any type)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator for an AWS service.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonOrganizationsRequest
    {
        private string _nextToken;
        private string _resourceId;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The parameter for receiving additional results if you receive a <code>NextToken</code>
        /// response in a previous request. A <code>NextToken</code> response indicates that more
        /// output is available. Set this parameter to the value of the previous call's <code>NextToken</code>
        /// response to indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource with the tags to list.
        /// </para>
        ///  
        /// <para>
        /// You can specify any of the following taggable resources.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS account – specify the account ID number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Organizational unit – specify the OU ID that begins with <code>ou-</code> and looks
        /// similar to: <code>ou-<i>1a2b-34uvwxyz</i> </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Root – specify the root ID that begins with <code>r-</code> and looks similar to:
        /// <code>r-<i>1a2b</i> </code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Policy – specify the policy ID that begins with <code>p-</code> andlooks similar to:
        /// <code>p-<i>12abcdefg3</i> </code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=130)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

    }
}