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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// This is the response object from the StartOutpostDecommission operation.
    /// </summary>
    public partial class StartOutpostDecommissionResponse : AmazonWebServiceResponse
    {
        private List<string> _blockingResourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DecommissionRequestStatus _status;

        /// <summary>
        /// Gets and sets the property BlockingResourceTypes. 
        /// <para>
        /// The resources still associated with the Outpost that you are decommissioning.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BlockingResourceTypes
        {
            get { return this._blockingResourceTypes; }
            set { this._blockingResourceTypes = value; }
        }

        // Check to see if BlockingResourceTypes property is set
        internal bool IsSetBlockingResourceTypes()
        {
            return this._blockingResourceTypes != null && (this._blockingResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the decommission request.
        /// </para>
        /// </summary>
        public DecommissionRequestStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}