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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
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
namespace Amazon.WorkspacesInstances.Model
{
    /// <summary>
    /// Container for the parameters to the UntagResource operation.
    /// Removes tags from a WorkSpace Instance.
    /// </summary>
    public partial class UntagResourceRequest : AmazonWorkspacesInstancesRequest
    {
        private List<string> _tagKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workspaceInstanceId;

        /// <summary>
        /// Gets and sets the property TagKeys. 
        /// <para>
        /// Keys of tags to be removed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> TagKeys
        {
            get { return this._tagKeys; }
            set { this._tagKeys = value; }
        }

        // Check to see if TagKeys property is set
        internal bool IsSetTagKeys()
        {
            return this._tagKeys != null && (this._tagKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceInstanceId. 
        /// <para>
        /// Unique identifier of the WorkSpace Instance to untag.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=15, Max=70)]
        public string WorkspaceInstanceId
        {
            get { return this._workspaceInstanceId; }
            set { this._workspaceInstanceId = value; }
        }

        // Check to see if WorkspaceInstanceId property is set
        internal bool IsSetWorkspaceInstanceId()
        {
            return this._workspaceInstanceId != null;
        }

    }
}