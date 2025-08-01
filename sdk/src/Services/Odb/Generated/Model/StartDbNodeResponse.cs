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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the StartDbNode operation.
    /// </summary>
    public partial class StartDbNodeResponse : AmazonWebServiceResponse
    {
        private string _dbNodeId;
        private DbNodeResourceStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property DbNodeId. 
        /// <para>
        /// The unique identifier of the DB node that was started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DbNodeId
        {
            get { return this._dbNodeId; }
            set { this._dbNodeId = value; }
        }

        // Check to see if DbNodeId property is set
        internal bool IsSetDbNodeId()
        {
            return this._dbNodeId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the DB node after the start operation.
        /// </para>
        /// </summary>
        public DbNodeResourceStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about the status of the DB node after the start operation.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}