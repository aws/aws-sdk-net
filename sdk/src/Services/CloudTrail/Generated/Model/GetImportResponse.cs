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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// This is the response object from the GetImport operation.
    /// </summary>
    public partial class GetImportResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private List<string> _destinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endEventTime;
        private string _importId;
        private ImportSource _importSource;
        private ImportStatistics _importStatistics;
        private ImportStatus _importStatus;
        private DateTime? _startEventTime;
        private DateTime? _updatedTimestamp;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp of the import's creation. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        public DateTime? EndEventTime
        {
            get { return this._endEventTime; }
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
        ///  The source S3 bucket. 
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
        /// Gets and sets the property ImportStatistics. 
        /// <para>
        ///  Provides statistics for the import. CloudTrail does not update import statistics
        /// in real-time. Returned values for parameters such as <c>EventsCompleted</c> may be
        /// lower than the actual value, because CloudTrail updates statistics incrementally over
        /// the course of the import. 
        /// </para>
        /// </summary>
        public ImportStatistics ImportStatistics
        {
            get { return this._importStatistics; }
            set { this._importStatistics = value; }
        }

        // Check to see if ImportStatistics property is set
        internal bool IsSetImportStatistics()
        {
            return this._importStatistics != null;
        }

        /// <summary>
        /// Gets and sets the property ImportStatus. 
        /// <para>
        ///  The status of the import. 
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
        public DateTime? StartEventTime
        {
            get { return this._startEventTime; }
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
        ///  The timestamp of when the import was updated. 
        /// </para>
        /// </summary>
        public DateTime? UpdatedTimestamp
        {
            get { return this._updatedTimestamp; }
            set { this._updatedTimestamp = value; }
        }

        // Check to see if UpdatedTimestamp property is set
        internal bool IsSetUpdatedTimestamp()
        {
            return this._updatedTimestamp.HasValue; 
        }

    }
}