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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details of the operation to be performed by the job.
    /// </summary>
    public partial class ExportRevisionsToS3RequestDetails
    {
        private string _dataSetId;
        private ExportServerSideEncryption _encryption;
        private List<RevisionDestinationEntry> _revisionDestinations = AWSConfigs.InitializeCollections ? new List<RevisionDestinationEntry>() : null;

        /// <summary>
        /// Gets and sets the property DataSetId. 
        /// <para>
        /// The unique identifier for the data set associated with this export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Encryption. 
        /// <para>
        /// Encryption configuration for the export job.
        /// </para>
        /// </summary>
        public ExportServerSideEncryption Encryption
        {
            get { return this._encryption; }
            set { this._encryption = value; }
        }

        // Check to see if Encryption property is set
        internal bool IsSetEncryption()
        {
            return this._encryption != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionDestinations. 
        /// <para>
        /// The destination for the revision.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<RevisionDestinationEntry> RevisionDestinations
        {
            get { return this._revisionDestinations; }
            set { this._revisionDestinations = value; }
        }

        // Check to see if RevisionDestinations property is set
        internal bool IsSetRevisionDestinations()
        {
            return this._revisionDestinations != null && (this._revisionDestinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}