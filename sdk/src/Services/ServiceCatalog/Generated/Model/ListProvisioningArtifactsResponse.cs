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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the ListProvisioningArtifacts operation.
    /// </summary>
    public partial class ListProvisioningArtifactsResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private List<ProvisioningArtifactDetail> _provisioningArtifactDetails = new List<ProvisioningArtifactDetail>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2024)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningArtifactDetails. 
        /// <para>
        /// Information about the provisioning artifacts.
        /// </para>
        /// </summary>
        public List<ProvisioningArtifactDetail> ProvisioningArtifactDetails
        {
            get { return this._provisioningArtifactDetails; }
            set { this._provisioningArtifactDetails = value; }
        }

        // Check to see if ProvisioningArtifactDetails property is set
        internal bool IsSetProvisioningArtifactDetails()
        {
            return this._provisioningArtifactDetails != null && this._provisioningArtifactDetails.Count > 0; 
        }

    }
}