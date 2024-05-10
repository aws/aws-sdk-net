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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Summary information for an Amazon Rekognition Custom Labels dataset. For more information,
    /// see <a>ProjectDescription</a>.
    /// </summary>
    public partial class DatasetMetadata
    {
        private DateTime? _creationTimestamp;
        private string _datasetArn;
        private DatasetType _datasetType;
        private DatasetStatus _status;
        private string _statusMessage;
        private DatasetStatusMessageCode _statusMessageCode;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        ///  The Unix timestamp for the date and time that the dataset was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for the dataset. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetType. 
        /// <para>
        ///  The type of the dataset. 
        /// </para>
        /// </summary>
        public DatasetType DatasetType
        {
            get { return this._datasetType; }
            set { this._datasetType = value; }
        }

        // Check to see if DatasetType property is set
        internal bool IsSetDatasetType()
        {
            return this._datasetType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status for the dataset. 
        /// </para>
        /// </summary>
        public DatasetStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  The status message for the dataset. 
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessageCode. 
        /// <para>
        ///  The status message code for the dataset operation. If a service error occurs, try
        /// the API call again later. If a client error occurs, check the input parameters to
        /// the dataset API call that failed. 
        /// </para>
        /// </summary>
        public DatasetStatusMessageCode StatusMessageCode
        {
            get { return this._statusMessageCode; }
            set { this._statusMessageCode = value; }
        }

        // Check to see if StatusMessageCode property is set
        internal bool IsSetStatusMessageCode()
        {
            return this._statusMessageCode != null;
        }

    }
}