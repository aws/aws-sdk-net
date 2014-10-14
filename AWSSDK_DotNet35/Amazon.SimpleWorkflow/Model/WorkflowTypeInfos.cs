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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains a paginated list of information structures about workflow types.
    /// </summary>
    public partial class WorkflowTypeInfos
    {
        private string _nextPageToken;
        private List<WorkflowTypeInfo> _typeInfos = new List<WorkflowTypeInfo>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next page of type information. If set then the list consists of
        /// more than one page. You can retrieve the next page by repeating the request (that
        /// returned the structure) with the this token and all other arguments unchanged.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property TypeInfos. 
        /// <para>
        /// The list of workflow type information.
        /// </para>
        /// </summary>
        public List<WorkflowTypeInfo> TypeInfos
        {
            get { return this._typeInfos; }
            set { this._typeInfos = value; }
        }

        // Check to see if TypeInfos property is set
        internal bool IsSetTypeInfos()
        {
            return this._typeInfos != null && this._typeInfos.Count > 0; 
        }

    }
}