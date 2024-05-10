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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DescribeReplaceRootVolumeTasks operation.
    /// </summary>
    public partial class DescribeReplaceRootVolumeTasksResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReplaceRootVolumeTask> _replaceRootVolumeTasks = AWSConfigs.InitializeCollections ? new List<ReplaceRootVolumeTask>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to include in another request to get the next page of items. This value
        /// is <c>null</c> when there are no more items to return.
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
        /// Gets and sets the property ReplaceRootVolumeTasks. 
        /// <para>
        /// Information about the root volume replacement task.
        /// </para>
        /// </summary>
        public List<ReplaceRootVolumeTask> ReplaceRootVolumeTasks
        {
            get { return this._replaceRootVolumeTasks; }
            set { this._replaceRootVolumeTasks = value; }
        }

        // Check to see if ReplaceRootVolumeTasks property is set
        internal bool IsSetReplaceRootVolumeTasks()
        {
            return this._replaceRootVolumeTasks != null && (this._replaceRootVolumeTasks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}