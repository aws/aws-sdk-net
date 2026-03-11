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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// FIPS-compliant endpoint URLs for an OpenSearch Serverless collection. These endpoints
    /// ensure all data transmission uses FIPS 140-3 validated cryptographic implementations,
    /// meeting federal security requirements for government workloads.
    /// </summary>
    public partial class FipsEndpoints
    {
        private string _collectionEndpoint;
        private string _dashboardEndpoint;

        /// <summary>
        /// Gets and sets the property CollectionEndpoint. 
        /// <para>
        /// FIPS-compliant collection endpoint used to submit index, search, and data upload requests
        /// to an OpenSearch Serverless collection. This endpoint uses FIPS 140-3 validated cryptography
        /// and is required for federal government workloads.
        /// </para>
        /// </summary>
        public string CollectionEndpoint
        {
            get { return this._collectionEndpoint; }
            set { this._collectionEndpoint = value; }
        }

        // Check to see if CollectionEndpoint property is set
        internal bool IsSetCollectionEndpoint()
        {
            return this._collectionEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property DashboardEndpoint. 
        /// <para>
        /// FIPS-compliant endpoint used to access OpenSearch Dashboards. This endpoint uses FIPS
        /// 140-3 validated cryptography and is required for federal government workloads that
        /// need dashboard visualization capabilities.
        /// </para>
        /// </summary>
        public string DashboardEndpoint
        {
            get { return this._dashboardEndpoint; }
            set { this._dashboardEndpoint = value; }
        }

        // Check to see if DashboardEndpoint property is set
        internal bool IsSetDashboardEndpoint()
        {
            return this._dashboardEndpoint != null;
        }

    }
}