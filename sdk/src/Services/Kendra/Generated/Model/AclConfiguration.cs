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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Provides information about the column that should be used for filtering the query
    /// response by groups.
    /// </summary>
    public partial class AclConfiguration
    {
        private string _allowedGroupsColumnName;

        /// <summary>
        /// Gets and sets the property AllowedGroupsColumnName. 
        /// <para>
        /// A list of groups, separated by semi-colons, that filters a query response based on
        /// user context. The document is only returned to users that are in one of the groups
        /// specified in the <c>UserContext</c> field of the <c>Query</c> API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string AllowedGroupsColumnName
        {
            get { return this._allowedGroupsColumnName; }
            set { this._allowedGroupsColumnName = value; }
        }

        // Check to see if AllowedGroupsColumnName property is set
        internal bool IsSetAllowedGroupsColumnName()
        {
            return this._allowedGroupsColumnName != null;
        }

    }
}