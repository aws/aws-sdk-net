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
    /// Container for the parameters to the StartTableDataImportJob operation.
    /// The StartTableDataImportJob API allows you to start an import job on a table. This
    /// API will only return the id of the job that was started. To find out the status of
    /// the import request, you need to call the DescribeTableDataImportJob API.
    /// </summary>
    public partial class StartTableDataImportJobRequest : AmazonHoneycodeRequest
    {
        private string _clientRequestToken;
        private ImportSourceDataFormat _dataFormat;
        private ImportDataSource _dataSource;
        private string _destinationTableId;
        private ImportOptions _importOptions;
        private string _workbookId;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        ///  The request token for performing the update action. Request tokens help to identify
        /// duplicate requests. If a call times out or fails due to a transient error like a failed
        /// network connection, you can retry the call with the same request token. The service
        /// ensures that if the first call using that request token is successfully performed,
        /// the second call will not perform the action again. 
        /// </para>
        ///  
        /// <para>
        ///  Note that request tokens are valid only for a few minutes. You cannot use request
        /// tokens to dedupe requests spanning hours or days. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property DataFormat. 
        /// <para>
        ///  The format of the data that is being imported. Currently the only option supported
        /// is "DELIMITED_TEXT". 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportSourceDataFormat DataFormat
        {
            get { return this._dataFormat; }
            set { this._dataFormat = value; }
        }

        // Check to see if DataFormat property is set
        internal bool IsSetDataFormat()
        {
            return this._dataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property DataSource. 
        /// <para>
        ///  The source of the data that is being imported. The size of source must be no larger
        /// than 100 MB. Source must have no more than 100,000 cells and no more than 1,000 rows.
        /// 
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
        /// Gets and sets the property DestinationTableId. 
        /// <para>
        /// The ID of the table where the rows are being imported.
        /// </para>
        ///  
        /// <para>
        ///  If a table with the specified id could not be found, this API throws ResourceNotFoundException.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string DestinationTableId
        {
            get { return this._destinationTableId; }
            set { this._destinationTableId = value; }
        }

        // Check to see if DestinationTableId property is set
        internal bool IsSetDestinationTableId()
        {
            return this._destinationTableId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportOptions. 
        /// <para>
        ///  The options for customizing this import request. 
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
        /// Gets and sets the property WorkbookId. 
        /// <para>
        /// The ID of the workbook where the rows are being imported.
        /// </para>
        ///  
        /// <para>
        ///  If a workbook with the specified id could not be found, this API throws ResourceNotFoundException.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WorkbookId
        {
            get { return this._workbookId; }
            set { this._workbookId = value; }
        }

        // Check to see if WorkbookId property is set
        internal bool IsSetWorkbookId()
        {
            return this._workbookId != null;
        }

    }
}