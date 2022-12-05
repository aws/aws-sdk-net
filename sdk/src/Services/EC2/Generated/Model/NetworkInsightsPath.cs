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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a path.
    /// </summary>
    public partial class NetworkInsightsPath
    {
        private DateTime? _createdDate;
        private string _destination;
        private string _destinationArn;
        private string _destinationIp;
        private int? _destinationPort;
        private string _networkInsightsPathArn;
        private string _networkInsightsPathId;
        private Protocol _protocol;
        private string _source;
        private string _sourceArn;
        private string _sourceIp;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The time stamp when the path was created.
        /// </para>
        /// </summary>
        public DateTime CreatedDate
        {
            get { return this._createdDate.GetValueOrDefault(); }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The Amazon Web Services resource that is the destination of the path.
        /// </para>
        /// </summary>
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationIp. 
        /// <para>
        /// The IP address of the Amazon Web Services resource that is the destination of the
        /// path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string DestinationIp
        {
            get { return this._destinationIp; }
            set { this._destinationIp = value; }
        }

        // Check to see if DestinationIp property is set
        internal bool IsSetDestinationIp()
        {
            return this._destinationIp != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port.
        /// </para>
        /// </summary>
        public int DestinationPort
        {
            get { return this._destinationPort.GetValueOrDefault(); }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string NetworkInsightsPathArn
        {
            get { return this._networkInsightsPathArn; }
            set { this._networkInsightsPathArn = value; }
        }

        // Check to see if NetworkInsightsPathArn property is set
        internal bool IsSetNetworkInsightsPathArn()
        {
            return this._networkInsightsPathArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInsightsPathId. 
        /// <para>
        /// The ID of the path.
        /// </para>
        /// </summary>
        public string NetworkInsightsPathId
        {
            get { return this._networkInsightsPathId; }
            set { this._networkInsightsPathId = value; }
        }

        // Check to see if NetworkInsightsPathId property is set
        internal bool IsSetNetworkInsightsPathId()
        {
            return this._networkInsightsPathId != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Web Services resource that is the source of the path.
        /// </para>
        /// </summary>
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the Amazon Web Services resource that is the source of the path.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=15)]
        public string SourceIp
        {
            get { return this._sourceIp; }
            set { this._sourceIp = value; }
        }

        // Check to see if SourceIp property is set
        internal bool IsSetSourceIp()
        {
            return this._sourceIp != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the path.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}