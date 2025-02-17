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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// This is the response object from the GetLineageEvent operation.
    /// </summary>
    public partial class GetLineageEventResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _createdBy;
        private string _domainId;
        private MemoryStream _event;
        private DateTime? _eventTime;
        private string _id;
        private LineageEventProcessingStatus _processingStatus;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the lineage event was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the lineage event.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return !string.IsNullOrEmpty(this._createdBy);
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The ID of the domain.
        /// </para>
        /// </summary>
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return !string.IsNullOrEmpty(this._domainId);
        }

        /// <summary>
        /// Gets and sets the property Event. 
        /// <para>
        /// The lineage event details.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=300000)]
        public MemoryStream Event
        {
            get { return this._event; }
            set { this._event = value; }
        }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this._event != null;
        }

        /// <summary>
        /// Gets and sets the property EventTime. 
        /// <para>
        /// The time of the lineage event.
        /// </para>
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime.GetValueOrDefault(); }
            set { this._eventTime = value; }
        }

        // Check to see if EventTime property is set
        internal bool IsSetEventTime()
        {
            return this._eventTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the lineage event.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return !string.IsNullOrEmpty(this._id);
        }

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// The progressing status of the lineage event.
        /// </para>
        /// </summary>
        public LineageEventProcessingStatus ProcessingStatus
        {
            get { return this._processingStatus; }
            set { this._processingStatus = value; }
        }

        // Check to see if ProcessingStatus property is set
        internal bool IsSetProcessingStatus()
        {
            return !string.IsNullOrEmpty(this._processingStatus);
        }

    }
}