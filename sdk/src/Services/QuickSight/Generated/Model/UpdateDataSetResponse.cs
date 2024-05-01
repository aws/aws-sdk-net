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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the UpdateDataSet operation.
    /// </summary>
    public partial class UpdateDataSetResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _dataSetId;
        private string _ingestionArn;
        private string _ingestionId;
        private string _requestId;
        private int? _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID for the dataset that you want to create. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        public string DataSetId
        {
            get { return this._dataSetId; }
            set { this._dataSetId = value; }
        }

        // Check to see if DataSetId property is set
        internal bool IsSetDataSetId()
        {
            return this._dataSetId != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionArn. 
        /// <para>
        /// The ARN for the ingestion, which is triggered as a result of dataset creation if the
        /// import mode is SPICE.
        /// </para>
        /// </summary>
        public string IngestionArn
        {
            get { return this._ingestionArn; }
            set { this._ingestionArn = value; }
        }

        // Check to see if IngestionArn property is set
        internal bool IsSetIngestionArn()
        {
            return this._ingestionArn != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// The ID of the ingestion, which is triggered as a result of dataset creation if the
        /// import mode is SPICE.
        /// </para>
        /// </summary>
        public string IngestionId
        {
            get { return this._ingestionId; }
            set { this._ingestionId = value; }
        }

        // Check to see if IngestionId property is set
        internal bool IsSetIngestionId()
        {
            return this._ingestionId != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
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
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status.HasValue; 
        }

    }
}