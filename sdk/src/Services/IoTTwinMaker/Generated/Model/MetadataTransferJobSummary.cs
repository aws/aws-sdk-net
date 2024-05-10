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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// The metadata transfer job summary.
    /// </summary>
    public partial class MetadataTransferJobSummary
    {
        private string _arn;
        private DateTime? _creationDateTime;
        private string _metadataTransferJobId;
        private MetadataTransferJobProgress _progress;
        private MetadataTransferJobStatus _status;
        private DateTime? _updateDateTime;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The metadata transfer job summary ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The metadata transfer job summary creation DateTime object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataTransferJobId. 
        /// <para>
        /// The metadata transfer job summary Id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string MetadataTransferJobId
        {
            get { return this._metadataTransferJobId; }
            set { this._metadataTransferJobId = value; }
        }

        // Check to see if MetadataTransferJobId property is set
        internal bool IsSetMetadataTransferJobId()
        {
            return this._metadataTransferJobId != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The metadata transfer job summary progess.
        /// </para>
        /// </summary>
        public MetadataTransferJobProgress Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The metadata transfer job summary status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataTransferJobStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateDateTime. 
        /// <para>
        /// The metadata transfer job summary update DateTime object
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? UpdateDateTime
        {
            get { return this._updateDateTime; }
            set { this._updateDateTime = value; }
        }

        // Check to see if UpdateDateTime property is set
        internal bool IsSetUpdateDateTime()
        {
            return this._updateDateTime.HasValue; 
        }

    }
}