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
    /// Details about the export revisions to Amazon S3 response.
    /// </summary>
    public partial class ExportRevisionsToS3ResponseDetails
    {
        private string _dataSetId;
        private ExportServerSideEncryption _encryption;
        private string _eventActionArn;
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
        /// Encryption configuration of the export job.
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
        /// Gets and sets the property EventActionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the event action.
        /// </para>
        /// </summary>
        public string EventActionArn
        {
            get { return this._eventActionArn; }
            set { this._eventActionArn = value; }
        }

        // Check to see if EventActionArn property is set
        internal bool IsSetEventActionArn()
        {
            return this._eventActionArn != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionDestinations. 
        /// <para>
        /// The destination in Amazon S3 where the revision is exported.
        /// </para>
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