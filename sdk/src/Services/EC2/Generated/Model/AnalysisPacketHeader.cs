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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a header. Reflects any changes made by a component as traffic passes through.
    /// The fields of an inbound header are null except for the first component of a path.
    /// </summary>
    public partial class AnalysisPacketHeader
    {
        private List<string> _destinationAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<PortRange> _destinationPortRanges = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;
        private string _protocol;
        private List<string> _sourceAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<PortRange> _sourcePortRanges = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Gets and sets the property DestinationAddresses. 
        /// <para>
        /// The destination addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationAddresses
        {
            get { return this._destinationAddresses; }
            set { this._destinationAddresses = value; }
        }

        // Check to see if DestinationAddresses property is set
        internal bool IsSetDestinationAddresses()
        {
            return this._destinationAddresses != null && (this._destinationAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationPortRanges. 
        /// <para>
        /// The destination port ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> DestinationPortRanges
        {
            get { return this._destinationPortRanges; }
            set { this._destinationPortRanges = value; }
        }

        // Check to see if DestinationPortRanges property is set
        internal bool IsSetDestinationPortRanges()
        {
            return this._destinationPortRanges != null && (this._destinationPortRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol.
        /// </para>
        /// </summary>
        public string Protocol
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
        /// Gets and sets the property SourceAddresses. 
        /// <para>
        /// The source addresses.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourceAddresses
        {
            get { return this._sourceAddresses; }
            set { this._sourceAddresses = value; }
        }

        // Check to see if SourceAddresses property is set
        internal bool IsSetSourceAddresses()
        {
            return this._sourceAddresses != null && (this._sourceAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePortRanges. 
        /// <para>
        /// The source port ranges.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> SourcePortRanges
        {
            get { return this._sourcePortRanges; }
            set { this._sourcePortRanges = value; }
        }

        // Check to see if SourcePortRanges property is set
        internal bool IsSetSourcePortRanges()
        {
            return this._sourcePortRanges != null && (this._sourcePortRanges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}