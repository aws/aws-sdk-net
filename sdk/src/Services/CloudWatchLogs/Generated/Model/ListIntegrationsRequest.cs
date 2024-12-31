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
    /// Container for the parameters to the ListIntegrations operation.
    /// Returns a list of integrations between CloudWatch Logs and other services in this
    /// account. Currently, only one integration can be created in an account, and this integration
    /// must be with OpenSearch Service.
    /// </summary>
    public partial class ListIntegrationsRequest : AmazonCloudWatchLogsRequest
    {
        private string _integrationNamePrefix;
        private IntegrationStatus _integrationStatus;
        private IntegrationType _integrationType;

        /// <summary>
        /// Gets and sets the property IntegrationNamePrefix. 
        /// <para>
        /// To limit the results to integrations that start with a certain name prefix, specify
        /// that name prefix here.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string IntegrationNamePrefix
        {
            get { return this._integrationNamePrefix; }
            set { this._integrationNamePrefix = value; }
        }

        // Check to see if IntegrationNamePrefix property is set
        internal bool IsSetIntegrationNamePrefix()
        {
            return this._integrationNamePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationStatus. 
        /// <para>
        /// To limit the results to integrations with a certain status, specify that status here.
        /// </para>
        /// </summary>
        public IntegrationStatus IntegrationStatus
        {
            get { return this._integrationStatus; }
            set { this._integrationStatus = value; }
        }

        // Check to see if IntegrationStatus property is set
        internal bool IsSetIntegrationStatus()
        {
            return this._integrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// To limit the results to integrations of a certain type, specify that type here.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType
        {
            get { return this._integrationType; }
            set { this._integrationType = value; }
        }

        // Check to see if IntegrationType property is set
        internal bool IsSetIntegrationType()
        {
            return this._integrationType != null;
        }

    }
}