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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetGroup operation.
    /// </summary>
    public partial class GetGroupResponse : AmazonWebServiceResponse
    {
        private GroupStatusDetail _status;
        private List<GroupStatusDetail> _statusHistory = AWSConfigs.InitializeCollections ? new List<GroupStatusDetail>() : null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the group.
        /// </para>
        /// </summary>
        public GroupStatusDetail Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusHistory. 
        /// <para>
        /// The status history of the group.
        /// </para>
        /// </summary>
        public List<GroupStatusDetail> StatusHistory
        {
            get { return this._statusHistory; }
            set { this._statusHistory = value; }
        }

        // Check to see if StatusHistory property is set
        internal bool IsSetStatusHistory()
        {
            return this._statusHistory != null && (this._statusHistory.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}