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
    /// Describes a packet header statement.
    /// </summary>
    public partial class PacketHeaderStatementRequest
    {
        private List<string> _destinationAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _destinationPorts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _destinationPrefixLists = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _protocols = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourceAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourcePorts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sourcePrefixLists = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// The destination ports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationPorts
        {
            get { return this._destinationPorts; }
            set { this._destinationPorts = value; }
        }

        // Check to see if DestinationPorts property is set
        internal bool IsSetDestinationPorts()
        {
            return this._destinationPorts != null && (this._destinationPorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DestinationPrefixLists. 
        /// <para>
        /// The destination prefix lists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DestinationPrefixLists
        {
            get { return this._destinationPrefixLists; }
            set { this._destinationPrefixLists = value; }
        }

        // Check to see if DestinationPrefixLists property is set
        internal bool IsSetDestinationPrefixLists()
        {
            return this._destinationPrefixLists != null && (this._destinationPrefixLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source ports.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourcePorts
        {
            get { return this._sourcePorts; }
            set { this._sourcePorts = value; }
        }

        // Check to see if SourcePorts property is set
        internal bool IsSetSourcePorts()
        {
            return this._sourcePorts != null && (this._sourcePorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePrefixLists. 
        /// <para>
        /// The source prefix lists.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SourcePrefixLists
        {
            get { return this._sourcePrefixLists; }
            set { this._sourcePrefixLists = value; }
        }

        // Check to see if SourcePrefixLists property is set
        internal bool IsSetSourcePrefixLists()
        {
            return this._sourcePrefixLists != null && (this._sourcePrefixLists.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}