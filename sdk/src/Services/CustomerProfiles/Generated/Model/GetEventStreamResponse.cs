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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// This is the response object from the GetEventStream operation.
    /// </summary>
    public partial class GetEventStreamResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private EventStreamDestinationDetails _destinationDetails;
        private string _domainName;
        private string _eventStreamArn;
        private EventStreamState _state;
        private DateTime? _stoppedSince;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp of when the export was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationDetails. 
        /// <para>
        /// Details regarding the Kinesis stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventStreamDestinationDetails DestinationDetails
        {
            get { return this._destinationDetails; }
            set { this._destinationDetails = value; }
        }

        // Check to see if DestinationDetails property is set
        internal bool IsSetDestinationDetails()
        {
            return this._destinationDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property EventStreamArn. 
        /// <para>
        /// A unique identifier for the event stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string EventStreamArn
        {
            get { return this._eventStreamArn; }
            set { this._eventStreamArn = value; }
        }

        // Check to see if EventStreamArn property is set
        internal bool IsSetEventStreamArn()
        {
            return this._eventStreamArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The operational state of destination stream for export.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EventStreamState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StoppedSince. 
        /// <para>
        /// The timestamp when the <c>State</c> changed to <c>STOPPED</c>.
        /// </para>
        /// </summary>
        public DateTime? StoppedSince
        {
            get { return this._stoppedSince; }
            set { this._stoppedSince = value; }
        }

        // Check to see if StoppedSince property is set
        internal bool IsSetStoppedSince()
        {
            return this._stoppedSince.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}