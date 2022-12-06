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
 * Do not modify this file. This file is generated from the sagemaker-featurestore-runtime-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerFeatureStoreRuntime.Model
{
    /// <summary>
    /// This is the response object from the BatchGetRecord operation.
    /// </summary>
    public partial class BatchGetRecordResponse : AmazonWebServiceResponse
    {
        private List<BatchGetRecordError> _errors = new List<BatchGetRecordError>();
        private List<BatchGetRecordResultDetail> _records = new List<BatchGetRecordResultDetail>();
        private List<BatchGetRecordIdentifier> _unprocessedIdentifiers = new List<BatchGetRecordIdentifier>();

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of errors that have occurred when retrieving a batch of Records.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<BatchGetRecordError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// A list of Records you requested to be retrieved in batch.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<BatchGetRecordResultDetail> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && this._records.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedIdentifiers. 
        /// <para>
        /// A unprocessed list of <code>FeatureGroup</code> names, with their corresponding <code>RecordIdentifier</code>
        /// value, and Feature name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<BatchGetRecordIdentifier> UnprocessedIdentifiers
        {
            get { return this._unprocessedIdentifiers; }
            set { this._unprocessedIdentifiers = value; }
        }

        // Check to see if UnprocessedIdentifiers property is set
        internal bool IsSetUnprocessedIdentifiers()
        {
            return this._unprocessedIdentifiers != null && this._unprocessedIdentifiers.Count > 0; 
        }

    }
}