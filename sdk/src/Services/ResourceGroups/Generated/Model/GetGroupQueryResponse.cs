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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// This is the response object from the GetGroupQuery operation.
    /// </summary>
    public partial class GetGroupQueryResponse : AmazonWebServiceResponse
    {
        private GroupQuery _groupQuery;

        /// <summary>
        /// Gets and sets the property GroupQuery. 
        /// <para>
        /// The resource query associated with the specified group. For more information about
        /// resource queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>.
        /// </para>
        /// </summary>
        public GroupQuery GroupQuery
        {
            get { return this._groupQuery; }
            set { this._groupQuery = value; }
        }

        // Check to see if GroupQuery property is set
        internal bool IsSetGroupQuery()
        {
            return this._groupQuery != null;
        }

    }
}