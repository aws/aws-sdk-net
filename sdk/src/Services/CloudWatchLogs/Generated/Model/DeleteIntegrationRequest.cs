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
    /// Container for the parameters to the DeleteIntegration operation.
    /// Deletes the integration between CloudWatch Logs and OpenSearch Service. If your integration
    /// has active vended logs dashboards, you must specify <c>true</c> for the <c>force</c>
    /// parameter, otherwise the operation will fail. If you delete the integration by setting
    /// <c>force</c> to <c>true</c>, all your vended logs dashboards powered by OpenSearch
    /// Service will be deleted and the data that was on them will no longer be accessible.
    /// </summary>
    public partial class DeleteIntegrationRequest : AmazonCloudWatchLogsRequest
    {
        private bool? _force;
        private string _integrationName;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// Specify <c>true</c> to force the deletion of the integration even if vended logs dashboards
        /// currently exist.
        /// </para>
        ///  
        /// <para>
        /// The default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// The name of the integration to delete. To find the name of your integration, use <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListIntegrations.html">ListIntegrations</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string IntegrationName
        {
            get { return this._integrationName; }
            set { this._integrationName = value; }
        }

        // Check to see if IntegrationName property is set
        internal bool IsSetIntegrationName()
        {
            return this._integrationName != null;
        }

    }
}