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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A filter that can be used to retrieve a list of router outputs.
    /// </summary>
    public partial class RouterOutputFilter
    {
        private List<string> _nameContains = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _networkInterfaceArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _outputTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _regionNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _routedInputArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _routingScopes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// The names of the router outputs to include in the filter.
        /// </para>
        /// </summary>
        public List<string> NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null && (this._nameContains.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the network interfaces associated with the router
        /// outputs to include in the filter.
        /// </para>
        /// </summary>
        public List<string> NetworkInterfaceArns
        {
            get { return this._networkInterfaceArns; }
            set { this._networkInterfaceArns = value; }
        }

        // Check to see if NetworkInterfaceArns property is set
        internal bool IsSetNetworkInterfaceArns()
        {
            return this._networkInterfaceArns != null && (this._networkInterfaceArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputTypes. 
        /// <para>
        /// The types of router outputs to include in the filter.
        /// </para>
        /// </summary>
        public List<string> OutputTypes
        {
            get { return this._outputTypes; }
            set { this._outputTypes = value; }
        }

        // Check to see if OutputTypes property is set
        internal bool IsSetOutputTypes()
        {
            return this._outputTypes != null && (this._outputTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionNames. 
        /// <para>
        /// The AWS Regions of the router outputs to include in the filter.
        /// </para>
        /// </summary>
        public List<string> RegionNames
        {
            get { return this._regionNames; }
            set { this._regionNames = value; }
        }

        // Check to see if RegionNames property is set
        internal bool IsSetRegionNames()
        {
            return this._regionNames != null && (this._regionNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutedInputArns. 
        /// <para>
        /// The ARNs of the router inputs associated with the router outputs to include in the
        /// filter.
        /// </para>
        /// </summary>
        public List<string> RoutedInputArns
        {
            get { return this._routedInputArns; }
            set { this._routedInputArns = value; }
        }

        // Check to see if RoutedInputArns property is set
        internal bool IsSetRoutedInputArns()
        {
            return this._routedInputArns != null && (this._routedInputArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoutingScopes. 
        /// <para>
        /// Filter criteria to list router outputs based on their routing scope.
        /// </para>
        /// </summary>
        public List<string> RoutingScopes
        {
            get { return this._routingScopes; }
            set { this._routingScopes = value; }
        }

        // Check to see if RoutingScopes property is set
        internal bool IsSetRoutingScopes()
        {
            return this._routingScopes != null && (this._routingScopes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}