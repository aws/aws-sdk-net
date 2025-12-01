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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the AssociateWorkspace operation.
    /// </summary>
    public partial class AssociateWorkspaceResponse : AmazonWebServiceResponse
    {
        private List<FailedBatchAssociationSummary> _failedList = AWSConfigs.InitializeCollections ? new List<FailedBatchAssociationSummary>() : null;
        private List<SuccessfulBatchAssociationSummary> _successfulList = AWSConfigs.InitializeCollections ? new List<SuccessfulBatchAssociationSummary>() : null;

        /// <summary>
        /// Gets and sets the property FailedList. 
        /// <para>
        /// A list of resources that failed to be associated with the workspace, including error
        /// details.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedBatchAssociationSummary> FailedList
        {
            get { return this._failedList; }
            set { this._failedList = value; }
        }

        // Check to see if FailedList property is set
        internal bool IsSetFailedList()
        {
            return this._failedList != null && (this._failedList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulList. 
        /// <para>
        /// A list of resources that were successfully associated with the workspace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuccessfulBatchAssociationSummary> SuccessfulList
        {
            get { return this._successfulList; }
            set { this._successfulList = value; }
        }

        // Check to see if SuccessfulList property is set
        internal bool IsSetSuccessfulList()
        {
            return this._successfulList != null && (this._successfulList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}