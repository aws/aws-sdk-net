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
    /// This is the response object from the BatchAssociateDataSegmentsToDataset operation.
    /// </summary>
    public partial class BatchAssociateDataSegmentsToDatasetResponse : AmazonWebServiceResponse
    {
        private string _datasetId;
        private string _datasetVersion;
        private List<FailedDataSegmentAssociation> _failedAssociations = AWSConfigs.InitializeCollections ? new List<FailedDataSegmentAssociation>() : null;

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The ID of the dataset.
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
        /// Gets and sets the property DatasetVersion. 
        /// <para>
        /// The version of the dataset after association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property FailedAssociations. 
        /// <para>
        /// A list of data segment associations that failed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<FailedDataSegmentAssociation> FailedAssociations
        {
            get { return this._failedAssociations; }
            set { this._failedAssociations = value; }
        }

        // Check to see if FailedAssociations property is set
        internal bool IsSetFailedAssociations()
        {
            return this._failedAssociations != null && (this._failedAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}