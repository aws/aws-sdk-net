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
    /// This is the response object from the GetChannel operation.
    /// </summary>
    public partial class GetChannelResponse : AmazonWebServiceResponse
    {
        private string _channelArn;
        private List<Destination> _destinations = new List<Destination>();
        private IngestionStatus _ingestionStatus;
        private string _name;
        private string _source;
        private SourceConfig _sourceConfig;

        /// <summary>
        /// Gets and sets the property ChannelArn. 
        /// <para>
        /// The ARN of an channel returned by a <code>GetChannel</code> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=256)]
        public string ChannelArn
        {
            get { return this._channelArn; }
            set { this._channelArn = value; }
        }

        // Check to see if ChannelArn property is set
        internal bool IsSetChannelArn()
        {
            return this._channelArn != null;
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destinations for the channel. For channels created for integrations, the destinations
        /// are the event data stores that log events arriving through the channel. For service-linked
        /// channels, the destination is the Amazon Web Services service that created the service-linked
        /// channel to receive events.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public List<Destination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        /// A table showing information about the most recent successful and failed attempts to
        /// ingest events.
        /// </para>
        /// </summary>
        public IngestionStatus IngestionStatus
        {
            get { return this._ingestionStatus; }
            set { this._ingestionStatus = value; }
        }

        // Check to see if IngestionStatus property is set
        internal bool IsSetIngestionStatus()
        {
            return this._ingestionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the CloudTrail channel. For service-linked channels, the name is <code>aws-service-channel/service-name/custom-suffix</code>
        /// where <code>service-name</code> represents the name of the Amazon Web Services service
        /// that created the channel and <code>custom-suffix</code> represents the suffix generated
        /// by the Amazon Web Services service. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source for the CloudTrail channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property SourceConfig. 
        /// <para>
        ///  Provides information about the advanced event selectors configured for the channel,
        /// and whether the channel applies to all regions or a single region. 
        /// </para>
        /// </summary>
        public SourceConfig SourceConfig
        {
            get { return this._sourceConfig; }
            set { this._sourceConfig = value; }
        }

        // Check to see if SourceConfig property is set
        internal bool IsSetSourceConfig()
        {
            return this._sourceConfig != null;
        }

    }
}