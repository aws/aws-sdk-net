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
    /// This is the response object from the UngroupResources operation.
    /// </summary>
    public partial class UngroupResourcesResponse : AmazonWebServiceResponse
    {
        private List<FailedResource> _failed = AWSConfigs.InitializeCollections ? new List<FailedResource>() : null;
        private List<PendingResource> _pending = AWSConfigs.InitializeCollections ? new List<PendingResource>() : null;
        private List<string> _succeeded = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// A list of any resources that failed to be removed from the group by this operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedResource> Failed
        {
            get { return this._failed; }
            set { this._failed = value; }
        }

        // Check to see if Failed property is set
        internal bool IsSetFailed()
        {
            return this._failed != null && (this._failed.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Pending. 
        /// <para>
        /// A list of any resources that are still in the process of being removed from the group
        /// by this operation. These pending removals continue asynchronously. You can check the
        /// status of pending removals by using the <c> <a>ListGroupResources</a> </c> operation.
        /// After the resource is successfully removed, it no longer appears in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingResource> Pending
        {
            get { return this._pending; }
            set { this._pending = value; }
        }

        // Check to see if Pending property is set
        internal bool IsSetPending()
        {
            return this._pending != null && (this._pending.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Succeeded. 
        /// <para>
        /// A list of resources that were successfully removed from the group by this operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> Succeeded
        {
            get { return this._succeeded; }
            set { this._succeeded = value; }
        }

        // Check to see if Succeeded property is set
        internal bool IsSetSucceeded()
        {
            return this._succeeded != null && (this._succeeded.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}