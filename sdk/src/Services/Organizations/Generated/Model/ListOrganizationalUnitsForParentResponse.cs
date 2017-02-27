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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the ListOrganizationalUnitsForParent operation.
    /// </summary>
    public partial class ListOrganizationalUnitsForParentResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OrganizationalUnit> _organizationalUnits = new List<OrganizationalUnit>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If present, this value indicates that there is more output available than is included
        /// in the current response. Use this value in the <code>NextToken</code> request parameter
        /// in a subsequent call to the operation to get the next part of the output. You should
        /// repeat this until the <code>NextToken</code> response element comes back as <code>null</code>.
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

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// A list of the OUs in the specified root or parent OU.
        /// </para>
        /// </summary>
        public List<OrganizationalUnit> OrganizationalUnits
        {
            get { return this._organizationalUnits; }
            set { this._organizationalUnits = value; }
        }

        // Check to see if OrganizationalUnits property is set
        internal bool IsSetOrganizationalUnits()
        {
            return this._organizationalUnits != null && this._organizationalUnits.Count > 0; 
        }

    }
}