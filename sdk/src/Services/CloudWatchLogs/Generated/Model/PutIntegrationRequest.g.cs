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
    /// Container for the parameters to the PutIntegration operation. Creates an integration
    /// between CloudWatch Logs and another service in this account. Currently, only integrations
    /// with OpenSearch Service are supported, and currently you can have only one integration
    /// in your account. <para> Integrating with OpenSearch Service makes it possible for
    /// you to create curated vended logs dashboards, powered by OpenSearch Service analytics.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-OpenSearch-Dashboards.html">Vended
    /// log dashboards powered by Amazon OpenSearch Service</a>. </para> <para> You can use
    /// this operation only to create a new integration. You can't modify an existing integration.
    /// </para>
    /// </summary>
    public partial class PutIntegrationRequest : AmazonCloudWatchLogsRequest
    {
        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// A name for the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationName property is set.
        /// </summary>
        internal bool IsSetIntegrationName() => this.IntegrationName != null;

        /// <summary>
        /// Gets and sets the property IntegrationType. 
        /// <para>
        /// The type of integration. Currently, the only supported type is <c>OPENSEARCH</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;

        /// <summary>
        /// Gets and sets the property ResourceConfig. 
        /// <para>
        /// A structure that contains configuration information for the integration that you are
        /// creating.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceConfig ResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResourceConfig property is set.
        /// </summary>
        internal bool IsSetResourceConfig() => this.ResourceConfig != null;
    }
}
