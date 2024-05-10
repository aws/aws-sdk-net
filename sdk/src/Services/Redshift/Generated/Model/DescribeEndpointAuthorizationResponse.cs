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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the DescribeEndpointAuthorization operation.
    /// </summary>
    public partial class DescribeEndpointAuthorizationResponse : AmazonWebServiceResponse
    {
        private List<EndpointAuthorization> _endpointAuthorizationList = AWSConfigs.InitializeCollections ? new List<EndpointAuthorization>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property EndpointAuthorizationList. 
        /// <para>
        /// The authorizations to an endpoint.
        /// </para>
        /// </summary>
        public List<EndpointAuthorization> EndpointAuthorizationList
        {
            get { return this._endpointAuthorizationList; }
            set { this._endpointAuthorizationList = value; }
        }

        // Check to see if EndpointAuthorizationList property is set
        internal bool IsSetEndpointAuthorizationList()
        {
            return this._endpointAuthorizationList != null && (this._endpointAuthorizationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// An optional pagination token provided by a previous <c>DescribeEndpointAuthorization</c>
        /// request. If this parameter is specified, the response includes only records beyond
        /// the marker, up to the value specified by the <c>MaxRecords</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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

    }
}