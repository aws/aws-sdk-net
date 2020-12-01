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
 * Do not modify this file. This file is generated from the honeycode-2020-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Honeycode.Model
{
    /// <summary>
    /// The metadata associated with the table data import job that was submitted.
    /// </summary>
    public partial class TableDataImportJobMetadata
    {
        private ImportDataSource _dataSource;
        private ImportOptions _importOptions;
        private ImportJobSubmitter _submitter;
        private DateTime? _submitTime;

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        /// The source of the data that was submitted for import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportDataSource DataSource
        {
            get { return this._dataSource; }
            set { this._dataSource = value; }
        }

        // Check to see if DataSource property is set
        internal bool IsSetDataSource()
        {
            return this._dataSource != null;
        }

        /// <summary>
        /// Gets and sets the property ImportOptions. 
        /// <para>
        /// The options that was specified at the time of submitting the import request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportOptions ImportOptions
        {
            get { return this._importOptions; }
            set { this._importOptions = value; }
        }

        // Check to see if ImportOptions property is set
        internal bool IsSetImportOptions()
        {
            return this._importOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Submitter. 
        /// <para>
        /// Details about the submitter of the import request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobSubmitter Submitter
        {
            get { return this._submitter; }
            set { this._submitter = value; }
        }

        // Check to see if Submitter property is set
        internal bool IsSetSubmitter()
        {
            return this._submitter != null;
        }

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The timestamp when the job was submitted for import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime SubmitTime
        {
            get { return this._submitTime.GetValueOrDefault(); }
            set { this._submitTime = value; }
        }

        // Check to see if SubmitTime property is set
        internal bool IsSetSubmitTime()
        {
            return this._submitTime.HasValue; 
        }

    }
}