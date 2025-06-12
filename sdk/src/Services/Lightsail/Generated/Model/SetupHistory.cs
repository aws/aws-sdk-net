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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Returns a list of the commands that were ran on the target resource.
    /// 
    ///  
    /// <para>
    /// The status of each command is also returned.
    /// </para>
    /// </summary>
    public partial class SetupHistory
    {
        private List<SetupExecutionDetails> _executionDetails = AWSConfigs.InitializeCollections ? new List<SetupExecutionDetails>() : null;
        private string _operationId;
        private SetupRequest _request;
        private SetupHistoryResource _resource;
        private SetupStatus _status;

        /// <summary>
        /// Gets and sets the property ExecutionDetails. 
        /// <para>
        /// Describes the full details of the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SetupExecutionDetails> ExecutionDetails
        {
            get { return this._executionDetails; }
            set { this._executionDetails = value; }
        }

        // Check to see if ExecutionDetails property is set
        internal bool IsSetExecutionDetails()
        {
            return this._executionDetails != null && (this._executionDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OperationId. 
        /// <para>
        /// A GUID that's used to identify the operation.
        /// </para>
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        // Check to see if OperationId property is set
        internal bool IsSetOperationId()
        {
            return this._operationId != null;
        }

        /// <summary>
        /// Gets and sets the property Request. 
        /// <para>
        /// Information about the specified request.
        /// </para>
        /// </summary>
        public SetupRequest Request
        {
            get { return this._request; }
            set { this._request = value; }
        }

        // Check to see if Request property is set
        internal bool IsSetRequest()
        {
            return this._request != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The target resource name for the request.
        /// </para>
        /// </summary>
        public SetupHistoryResource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        public SetupStatus Status
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