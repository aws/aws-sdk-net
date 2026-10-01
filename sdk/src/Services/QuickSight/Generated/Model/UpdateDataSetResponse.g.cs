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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The ID for the dataset that you want to update. This ID is unique per Amazon Web Services
        /// Region for each Amazon Web Services account.
        /// </para>
        /// </summary>
        public string DataSetId { get; set; }

        /// <summary>
        /// Checks to see if the DataSetId property is set.
        /// </summary>
        internal bool IsSetDataSetId() => this.DataSetId != null;

        /// <summary>
        /// Gets and sets the property IngestionArn. 
        /// <para>
        /// The ARN for the ingestion, which is triggered as a result of dataset creation if the
        /// import mode is SPICE.
        /// </para>
        /// </summary>
        public string IngestionArn { get; set; }

        /// <summary>
        /// Checks to see if the IngestionArn property is set.
        /// </summary>
        internal bool IsSetIngestionArn() => this.IngestionArn != null;

        /// <summary>
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// The ID of the ingestion, which is triggered as a result of dataset creation if the
        /// import mode is SPICE.
        /// </para>
        /// </summary>
        public string IngestionId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionId property is set.
        /// </summary>
        internal bool IsSetIngestionId() => this.IngestionId != null;

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// Checks to see if the RequestId property is set.
        /// </summary>
        internal bool IsSetRequestId() => this.RequestId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The HTTP status of the request.
        /// </para>
        /// </summary>
        public int? Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status.HasValue;
    }
}
