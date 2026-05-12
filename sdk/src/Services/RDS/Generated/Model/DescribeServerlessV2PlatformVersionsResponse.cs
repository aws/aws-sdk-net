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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Contains the result of a successful invocation of the <c>DescribeServerlessV2PlatformVersions</c>
    /// action.
    /// </summary>
    public partial class DescribeServerlessV2PlatformVersionsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<ServerlessV2PlatformVersionInfo> _serverlessV2PlatformVersions = AWSConfigs.InitializeCollections ? new List<ServerlessV2PlatformVersionInfo>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous request. If this parameter is
        /// specified, the response includes only records beyond the marker, up to the value specified
        /// by <c>MaxRecords</c>.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property ServerlessV2PlatformVersions. 
        /// <para>
        /// A list of <c>ServerlessV2PlatformVersionInfo</c> elements.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServerlessV2PlatformVersionInfo> ServerlessV2PlatformVersions
        {
            get { return this._serverlessV2PlatformVersions; }
            set { this._serverlessV2PlatformVersions = value; }
        }

        // Check to see if ServerlessV2PlatformVersions property is set
        internal bool IsSetServerlessV2PlatformVersions()
        {
            return this._serverlessV2PlatformVersions != null && (this._serverlessV2PlatformVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}