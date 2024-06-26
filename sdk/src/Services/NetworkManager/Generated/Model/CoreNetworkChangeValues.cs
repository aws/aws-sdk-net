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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network change.
    /// </summary>
    public partial class CoreNetworkChangeValues
    {
        private long? _asn;
        private string _cidr;
        private string _destinationIdentifier;
        private List<string> _edgeLocations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _insideCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _networkFunctionGroupName;
        private string _segmentName;
        private List<ServiceInsertionAction> _serviceInsertionActions = AWSConfigs.InitializeCollections ? new List<ServiceInsertionAction>() : null;
        private List<string> _sharedSegments = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The ASN of a core network.
        /// </para>
        /// </summary>
        public long Asn
        {
            get { return this._asn.GetValueOrDefault(); }
            set { this._asn = value; }
        }

        // Check to see if Asn property is set
        internal bool IsSetAsn()
        {
            return this._asn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP addresses used for a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Cidr
        {
            get { return this._cidr; }
            set { this._cidr = value; }
        }

        // Check to see if Cidr property is set
        internal bool IsSetCidr()
        {
            return this._cidr != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationIdentifier. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string DestinationIdentifier
        {
            get { return this._destinationIdentifier; }
            set { this._destinationIdentifier = value; }
        }

        // Check to see if DestinationIdentifier property is set
        internal bool IsSetDestinationIdentifier()
        {
            return this._destinationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeLocations. 
        /// <para>
        /// The Regions where edges are located in a core network. 
        /// </para>
        /// </summary>
        public List<string> EdgeLocations
        {
            get { return this._edgeLocations; }
            set { this._edgeLocations = value; }
        }

        // Check to see if EdgeLocations property is set
        internal bool IsSetEdgeLocations()
        {
            return this._edgeLocations != null && (this._edgeLocations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The inside IP addresses used for core network change values.
        /// </para>
        /// </summary>
        public List<string> InsideCidrBlocks
        {
            get { return this._insideCidrBlocks; }
            set { this._insideCidrBlocks = value; }
        }

        // Check to see if InsideCidrBlocks property is set
        internal bool IsSetInsideCidrBlocks()
        {
            return this._insideCidrBlocks != null && (this._insideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The network function group name if the change event is associated with a network function
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string NetworkFunctionGroupName
        {
            get { return this._networkFunctionGroupName; }
            set { this._networkFunctionGroupName = value; }
        }

        // Check to see if NetworkFunctionGroupName property is set
        internal bool IsSetNetworkFunctionGroupName()
        {
            return this._networkFunctionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The names of the segments in a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SegmentName
        {
            get { return this._segmentName; }
            set { this._segmentName = value; }
        }

        // Check to see if SegmentName property is set
        internal bool IsSetSegmentName()
        {
            return this._segmentName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceInsertionActions. 
        /// <para>
        /// Describes the service insertion action. 
        /// </para>
        /// </summary>
        public List<ServiceInsertionAction> ServiceInsertionActions
        {
            get { return this._serviceInsertionActions; }
            set { this._serviceInsertionActions = value; }
        }

        // Check to see if ServiceInsertionActions property is set
        internal bool IsSetServiceInsertionActions()
        {
            return this._serviceInsertionActions != null && (this._serviceInsertionActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SharedSegments. 
        /// <para>
        /// The shared segments for a core network change value. 
        /// </para>
        /// </summary>
        public List<string> SharedSegments
        {
            get { return this._sharedSegments; }
            set { this._sharedSegments = value; }
        }

        // Check to see if SharedSegments property is set
        internal bool IsSetSharedSegments()
        {
            return this._sharedSegments != null && (this._sharedSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}