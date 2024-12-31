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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This structure contains information about the integration configuration. For an integration
    /// with OpenSearch Service, this includes information about OpenSearch Service resources
    /// such as the collection, the workspace, and policies.
    /// 
    ///  
    /// <para>
    /// This structure is returned by a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetIntegration.html">GetIntegration</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class IntegrationDetails
    {
        private OpenSearchIntegrationDetails _openSearchIntegrationDetails;

        /// <summary>
        /// Gets and sets the property OpenSearchIntegrationDetails. 
        /// <para>
        /// This structure contains complete information about one integration between CloudWatch
        /// Logs and OpenSearch Service.
        /// </para>
        /// </summary>
        public OpenSearchIntegrationDetails OpenSearchIntegrationDetails
        {
            get { return this._openSearchIntegrationDetails; }
            set { this._openSearchIntegrationDetails = value; }
        }

        // Check to see if OpenSearchIntegrationDetails property is set
        internal bool IsSetOpenSearchIntegrationDetails()
        {
            return this._openSearchIntegrationDetails != null;
        }

    }
}