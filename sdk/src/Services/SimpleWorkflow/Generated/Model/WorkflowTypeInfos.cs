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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Contains a paginated list of information structures about workflow types.
    /// </summary>
    public partial class WorkflowTypeInfos
    {
        private string _nextPageToken;
        private List<WorkflowTypeInfo> _typeInfos = AWSConfigs.InitializeCollections ? new List<WorkflowTypeInfo>() : null;

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// If a <c>NextPageToken</c> was returned by a previous call, there are more results
        /// available. To retrieve the next page of results, make the call again using the returned
        /// token in <c>nextPageToken</c>. Keep all other arguments unchanged.
        /// </para>
        ///  
        /// <para>
        /// The configured <c>maximumPageSize</c> determines how many results can be returned
        /// in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<WorkflowTypeInfo> TypeInfos
        {
            get { return this._typeInfos; }
            set { this._typeInfos = value; }
        }

        // Check to see if TypeInfos property is set
        internal bool IsSetTypeInfos()
        {
            return this._typeInfos != null && (this._typeInfos.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}