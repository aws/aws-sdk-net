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
    /// Container for the parameters to the RemoveIpRoutes operation.
    /// Removes IP address blocks from a directory.
    /// </summary>
    public partial class RemoveIpRoutesRequest : AmazonDirectoryServiceRequest
    {
        private List<string> _cidrIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _cidrIpv6s = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _directoryId;

        /// <summary>
        /// Gets and sets the property CidrIps. 
        /// <para>
        /// IP address blocks that you want to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrIps
        {
            get { return this._cidrIps; }
            set { this._cidrIps = value; }
        }

        // Check to see if CidrIps property is set
        internal bool IsSetCidrIps()
        {
            return this._cidrIps != null && (this._cidrIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CidrIpv6s. 
        /// <para>
        /// IPv6 address blocks that you want to remove.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrIpv6s
        {
            get { return this._cidrIpv6s; }
            set { this._cidrIpv6s = value; }
        }

        // Check to see if CidrIpv6s property is set
        internal bool IsSetCidrIpv6s()
        {
            return this._cidrIpv6s != null && (this._cidrIpv6s.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// Identifier (ID) of the directory from which you want to remove the IP addresses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

    }
}