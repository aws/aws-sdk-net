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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Describes the current hybrid directory configuration settings for a directory.
    /// </summary>
    public partial class HybridSettingsDescription
    {
        private List<string> _selfManagedDnsIpAddrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _selfManagedInstanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SelfManagedDnsIpAddrs. 
        /// <para>
        /// The IP addresses of the DNS servers in your self-managed AD environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SelfManagedDnsIpAddrs
        {
            get { return this._selfManagedDnsIpAddrs; }
            set { this._selfManagedDnsIpAddrs = value; }
        }

        // Check to see if SelfManagedDnsIpAddrs property is set
        internal bool IsSetSelfManagedDnsIpAddrs()
        {
            return this._selfManagedDnsIpAddrs != null && (this._selfManagedDnsIpAddrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfManagedInstanceIds. 
        /// <para>
        /// The identifiers of the self-managed instances with SSM used for hybrid directory operations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<string> SelfManagedInstanceIds
        {
            get { return this._selfManagedInstanceIds; }
            set { this._selfManagedInstanceIds = value; }
        }

        // Check to see if SelfManagedInstanceIds property is set
        internal bool IsSetSelfManagedInstanceIds()
        {
            return this._selfManagedInstanceIds != null && (this._selfManagedInstanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}