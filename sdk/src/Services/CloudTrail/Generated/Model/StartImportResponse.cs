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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the StartImport operation.
    /// </summary>
    public partial class StartImportResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private List<string> _destinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endEventTime;
        private string _importId;
        private ImportSource _importSource;
        private ImportStatus _importStatus;
        private DateTime? _startEventTime;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp for the import's creation. 
        /// </para>
        /// </summary>
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        ///  The ARN of the destination event data store. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndEventTime. 
        /// <para>
        ///  Used with <c>StartEventTime</c> to bound a <c>StartImport</c> request, and limit
        /// imported trail events to only those events logged within a specified time period.
        /// 
        /// </para>
        /// </summary>
        public DateTime EndEventTime
        {
            get { return this._endEventTime.GetValueOrDefault(); }
            set { this._endEventTime = value; }
        }

        // Check to see if EndEventTime property is set
        internal bool IsSetEndEventTime()
        {
            return this._endEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportId. 
        /// <para>
        ///  The ID of the import. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ImportId
        {
            get { return this._importId; }
            set { this._importId = value; }
        }

        // Check to see if ImportId property is set
        internal bool IsSetImportId()
        {
            return this._importId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportSource. 
        /// <para>
        ///  The source S3 bucket for the import. 
        /// </para>
        /// </summary>
        public ImportSource ImportSource
        {
            get { return this._importSource; }
            set { this._importSource = value; }
        }

        // Check to see if ImportSource property is set
        internal bool IsSetImportSource()
        {
            return this._importSource != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  Shows the status of the import after a <c>StartImport</c> request. An import finishes
        /// with a status of <c>COMPLETED</c> if there were no failures, or <c>FAILED</c> if there
        /// were failures. 
        /// </para>
        /// </summary>
        public ImportStatus ImportStatus
        {
            get { return this._importStatus; }
            set { this._importStatus = value; }
        }

        // Check to see if ImportStatus property is set
        internal bool IsSetImportStatus()
        {
            return this._importStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StartEventTime. 
        /// <para>
        ///  Used with <c>EndEventTime</c> to bound a <c>StartImport</c> request, and limit imported
        /// trail events to only those events logged within a specified time period. 
        /// </para>
        /// </summary>
        public DateTime StartEventTime
        {
            get { return this._startEventTime.GetValueOrDefault(); }
            set { this._startEventTime = value; }
        }

        // Check to see if StartEventTime property is set
        internal bool IsSetStartEventTime()
        {
            return this._startEventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedTimestamp. 
        /// <para>
        ///  The timestamp of the import's last update, if applicable. 
        /// </para>
        /// </summary>
        public DateTime UpdatedTimestamp
        {
            get { return this._updatedTimestamp.GetValueOrDefault(); }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}