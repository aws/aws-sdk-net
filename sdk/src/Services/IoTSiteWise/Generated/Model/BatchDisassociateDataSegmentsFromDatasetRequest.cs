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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the BatchDisassociateDataSegmentsFromDataset operation.
    /// Disassociates a batch of data segments from a curated dataset. Disassociating a data
    /// segment doesn't delete the underlying data in the source session dataset.
    /// </summary>
    public partial class BatchDisassociateDataSegmentsFromDatasetRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private string _datasetId;
        private List<DisassociateDataSegmentEntry> _disassociateDataSegmentEntries = AWSConfigs.InitializeCollections ? new List<DisassociateDataSegmentEntry>() : null;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure that the request is
        /// idempotent. If you retry a request that completed successfully using the same client
        /// token, the retry succeeds without performing any further actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the curated dataset to disassociate data segments from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
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
        /// Gets and sets the property DisassociateDataSegmentEntries. 
        /// <para>
        /// The list of data segment entries to disassociate from the dataset.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DisassociateDataSegmentEntry> DisassociateDataSegmentEntries
        {
            get { return this._disassociateDataSegmentEntries; }
            set { this._disassociateDataSegmentEntries = value; }
        }

        // Check to see if DisassociateDataSegmentEntries property is set
        internal bool IsSetDisassociateDataSegmentEntries()
        {
            return this._disassociateDataSegmentEntries != null && (this._disassociateDataSegmentEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}