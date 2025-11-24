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
    /// Configuration settings for a merge router input that combines two input sources.
    /// </summary>
    public partial class MergeRouterInputConfiguration
    {
        private long? _mergeRecoveryWindowMilliseconds;
        private string _networkInterfaceArn;
        private List<MergeRouterInputProtocolConfiguration> _protocolConfigurations = AWSConfigs.InitializeCollections ? new List<MergeRouterInputProtocolConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property MergeRecoveryWindowMilliseconds. 
        /// <para>
        /// The time window in milliseconds for merging the two input sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? MergeRecoveryWindowMilliseconds
        {
            get { return this._mergeRecoveryWindowMilliseconds; }
            set { this._mergeRecoveryWindowMilliseconds = value; }
        }

        // Check to see if MergeRecoveryWindowMilliseconds property is set
        internal bool IsSetMergeRecoveryWindowMilliseconds()
        {
            return this._mergeRecoveryWindowMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaceArn. 
        /// <para>
        /// The ARN of the network interface to use for this merge router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NetworkInterfaceArn
        {
            get { return this._networkInterfaceArn; }
            set { this._networkInterfaceArn = value; }
        }

        // Check to see if NetworkInterfaceArn property is set
        internal bool IsSetNetworkInterfaceArn()
        {
            return this._networkInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolConfigurations. 
        /// <para>
        /// A list of exactly two protocol configurations for the merge input sources. Both must
        /// use the same protocol type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<MergeRouterInputProtocolConfiguration> ProtocolConfigurations
        {
            get { return this._protocolConfigurations; }
            set { this._protocolConfigurations = value; }
        }

        // Check to see if ProtocolConfigurations property is set
        internal bool IsSetProtocolConfigurations()
        {
            return this._protocolConfigurations != null && (this._protocolConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}