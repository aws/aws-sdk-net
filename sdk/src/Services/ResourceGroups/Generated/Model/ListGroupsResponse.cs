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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// This is the response object from the ListGroups operation.
    /// </summary>
    public partial class ListGroupsResponse : AmazonWebServiceResponse
    {
        private List<GroupIdentifier> _groupIdentifiers = new List<GroupIdentifier>();
        private List<Group> _groups = new List<Group>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property GroupIdentifiers. 
        /// <para>
        /// A list of <a>GroupIdentifier</a> objects. Each identifier is an object that contains
        /// both the <code>Name</code> and the <code>GroupArn</code>.
        /// </para>
        /// </summary>
        public List<GroupIdentifier> GroupIdentifiers
        {
            get { return this._groupIdentifiers; }
            set { this._groupIdentifiers = value; }
        }

        // Check to see if GroupIdentifiers property is set
        internal bool IsSetGroupIdentifiers()
        {
            return this._groupIdentifiers != null && this._groupIdentifiers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Groups. <important> 
        /// <para>
        ///  <i> <b>Deprecated - don't use this field. Use the <code>GroupIdentifiers</code> response
        /// field instead.</b> </i> 
        /// </para>
        ///  </important>
        /// </summary>
        [Obsolete("This field is deprecated, use GroupIdentifiers instead.")]
        public List<Group> Groups
        {
            get { return this._groups; }
            set { this._groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this._groups != null && this._groups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, indicates that more output is available than is included in the current
        /// response. Use this value in the <code>NextToken</code> request parameter in a subsequent
        /// call to the operation to get the next part of the output. You should repeat this until
        /// the <code>NextToken</code> response element comes back as <code>null</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
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