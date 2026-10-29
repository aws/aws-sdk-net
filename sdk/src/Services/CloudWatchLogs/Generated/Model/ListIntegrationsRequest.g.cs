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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the ListIntegrations operation. Returns a list of
    /// integrations between CloudWatch Logs and other services in this account. Currently,
    /// only one integration can be created in an account, and this integration must be with
    /// OpenSearch Service.
    /// </summary>
    public partial class ListIntegrationsRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property IntegrationNamePrefix. 
        /// <para>
        /// To limit the results to integrations that start with a certain name prefix, specify
        /// that name prefix here.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string IntegrationNamePrefix { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationNamePrefix property is set.
        /// </summary>
        internal bool IsSetIntegrationNamePrefix() => this.IntegrationNamePrefix != null;

        /// <summary>
        /// Gets and sets the property IntegrationStatus. 
        /// <para>
        /// To limit the results to integrations with a certain status, specify that status here.
        /// </para>
        /// </summary>
        public IntegrationStatus IntegrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationStatus property is set.
        /// </summary>
        internal bool IsSetIntegrationStatus() => this.IntegrationStatus != null;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// To limit the results to integrations of a certain type, specify that type here.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;
    }
}
