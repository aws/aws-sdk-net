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
    /// Container for the parameters to the CreateNetworkInsightsPath operation.
    /// Creates a path to analyze for reachability.
    /// 
    ///  
    /// <para>
    /// Reachability Analyzer enables you to analyze and debug network reachability between
    /// two resources in your virtual private cloud (VPC). For more information, see the <a
    /// href="https://docs.aws.amazon.com/vpc/latest/reachability/">Reachability Analyzer
    /// Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateNetworkInsightsPathRequest : AmazonEC2Request
    {
        private string _clientToken;
        private string _destination;
        private string _destinationIp;
        private int? _destinationPort;
        private PathRequestFilter _filterAtDestination;
        private PathRequestFilter _filterAtSource;
        private Protocol _protocol;
        private string _source;
        private string _sourceIp;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">How
        /// to ensure idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The ID or ARN of the destination. If the resource is in another account, you must
        /// specify an ARN.
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
        /// Gets and sets the property DestinationIp. 
        /// <para>
        /// The IP address of the destination.
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
        [AWSProperty(Min=0, Max=65535)]
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
        /// Gets and sets the property FilterAtDestination. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the destination.
        /// If you specify this parameter, you can't specify the parameter for the destination
        /// IP address.
        /// </para>
        /// </summary>
        public PathRequestFilter FilterAtDestination
        {
            get { return this._filterAtDestination; }
            set { this._filterAtDestination = value; }
        }

        // Check to see if FilterAtDestination property is set
        internal bool IsSetFilterAtDestination()
        {
            return this._filterAtDestination != null;
        }

        /// <summary>
        /// Gets and sets the property FilterAtSource. 
        /// <para>
        /// Scopes the analysis to network paths that match specific filters at the source. If
        /// you specify this parameter, you can't specify the parameters for the source IP address
        /// or the destination port.
        /// </para>
        /// </summary>
        public PathRequestFilter FilterAtSource
        {
            get { return this._filterAtSource; }
            set { this._filterAtSource = value; }
        }

        // Check to see if FilterAtSource property is set
        internal bool IsSetFilterAtSource()
        {
            return this._filterAtSource != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The ID or ARN of the source. If the resource is in another account, you must specify
        /// an ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SourceIp. 
        /// <para>
        /// The IP address of the source.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to add to the path.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

    }
}