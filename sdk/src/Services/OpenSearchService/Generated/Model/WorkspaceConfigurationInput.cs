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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Configuration for creating a new workspace when attaching a data source to an OpenSearch
    /// application. The workspace is created after the data source is successfully attached.
    /// </summary>
    public partial class WorkspaceConfigurationInput
    {
        private string _name;
        private string _workspaceType;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the workspace to create. Must be between 1 and 40 characters and can contain
        /// alphanumeric characters, parentheses, brackets, hyphens, underscores, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceType. 
        /// <para>
        /// The type of workspace to create, which determines the use-case features enabled for
        /// the workspace. Valid values are <c>OBSERVABILITY</c>, <c>SECURITY_ANALYTICS</c>, and
        /// <c>SEARCH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkspaceType
        {
            get { return this._workspaceType; }
            set { this._workspaceType = value; }
        }

        // Check to see if WorkspaceType property is set
        internal bool IsSetWorkspaceType()
        {
            return this._workspaceType != null;
        }

    }
}