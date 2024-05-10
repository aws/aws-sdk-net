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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// The status of the last <c>UpdateDataLake</c> or <c>DeleteDataLake</c> API request.
    /// This is set to Completed after the configuration is updated, or removed if deletion
    /// of the data lake is successful.
    /// </summary>
    public partial class DataLakeUpdateStatus
    {
        private DataLakeUpdateException _exception;
        private string _requestId;
        private DataLakeStatus _status;

        /// <summary>
        /// Gets and sets the property Exception. 
        /// <para>
        /// The details of the last <c>UpdateDataLake</c>or <c>DeleteDataLake</c> API request
        /// which failed.
        /// </para>
        /// </summary>
        public DataLakeUpdateException Exception
        {
            get { return this._exception; }
            set { this._exception = value; }
        }

        // Check to see if Exception property is set
        internal bool IsSetException()
        {
            return this._exception != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The unique ID for the last <c>UpdateDataLake</c> or <c>DeleteDataLake</c> API request.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last <c>UpdateDataLake</c> or <c>DeleteDataLake</c> API request
        /// that was requested.
        /// </para>
        /// </summary>
        public DataLakeStatus Status
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