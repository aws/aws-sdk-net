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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
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
namespace Amazon.AppFabric.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetUserAccessTasks operation.
    /// Gets user access details in a batch request.
    /// 
    ///  
    /// <para>
    /// This action polls data from the tasks that are kicked off by the <c>StartUserAccessTasks</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class BatchGetUserAccessTasksRequest : AmazonAppFabricRequest
    {
        private string _appBundleIdentifier;
        private List<string> _taskIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AppBundleIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) or Universal Unique Identifier (UUID) of the app bundle
        /// to use for the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string AppBundleIdentifier
        {
            get { return this._appBundleIdentifier; }
            set { this._appBundleIdentifier = value; }
        }

        // Check to see if AppBundleIdentifier property is set
        internal bool IsSetAppBundleIdentifier()
        {
            return this._appBundleIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TaskIdList. 
        /// <para>
        /// The tasks IDs to use for the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> TaskIdList
        {
            get { return this._taskIdList; }
            set { this._taskIdList = value; }
        }

        // Check to see if TaskIdList property is set
        internal bool IsSetTaskIdList()
        {
            return this._taskIdList != null && (this._taskIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}