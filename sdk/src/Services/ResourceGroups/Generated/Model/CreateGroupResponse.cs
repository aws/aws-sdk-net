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
    /// This is the response object from the CreateGroup operation.
    /// </summary>
    public partial class CreateGroupResponse : AmazonWebServiceResponse
    {
        private Group _group;
        private GroupConfiguration _groupConfiguration;
        private ResourceQuery _resourceQuery;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The description of the resource group.
        /// </para>
        /// </summary>
        public Group Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property GroupConfiguration. 
        /// <para>
        /// The service configuration associated with the resource group. For details about the
        /// syntax of a service configuration, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// </para>
        /// </summary>
        public GroupConfiguration GroupConfiguration
        {
            get { return this._groupConfiguration; }
            set { this._groupConfiguration = value; }
        }

        // Check to see if GroupConfiguration property is set
        internal bool IsSetGroupConfiguration()
        {
            return this._groupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The resource query associated with the group. For more information about resource
        /// queries, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html#gettingstarted-query-cli-tag">Create
        /// a tag-based group in Resource Groups</a>. 
        /// </para>
        /// </summary>
        public ResourceQuery ResourceQuery
        {
            get { return this._resourceQuery; }
            set { this._resourceQuery = value; }
        }

        // Check to see if ResourceQuery property is set
        internal bool IsSetResourceQuery()
        {
            return this._resourceQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the group.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}