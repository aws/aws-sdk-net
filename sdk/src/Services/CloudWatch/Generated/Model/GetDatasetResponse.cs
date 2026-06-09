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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// This is the response object from the GetDataset operation.
    /// </summary>
    public partial class GetDatasetResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _datasetId;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Returns the Amazon Resource Name (ARN) of the dataset, in the format <c>arn:aws:cloudwatch:<i>Region</i>:<i>account-id</i>:dataset/<i>dataset-id</i>
        /// </c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// Returns the identifier of the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=7)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// Returns the Amazon Resource Name (ARN) of the customer managed Amazon Web Services
        /// KMS key that is currently associated with the dataset, if any. If the dataset is not
        /// associated with a customer managed KMS key, this field is not included in the response
        /// and the dataset is encrypted at rest using an Amazon Web Services owned key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}