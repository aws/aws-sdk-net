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
    /// This is the response object from the GetIntegration operation.
    /// </summary>
    public partial class GetIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IntegrationDetails. 
        /// <para>
        /// A structure that contains information about the integration configuration. For an
        /// integration with OpenSearch Service, this includes information about OpenSearch Service
        /// resources such as the collection, the workspace, and policies.
        /// </para>
        /// </summary>
        public IntegrationDetails IntegrationDetails { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationDetails property is set.
        /// </summary>
        internal bool IsSetIntegrationDetails() => this.IntegrationDetails != null;

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// The name of the integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public string IntegrationName { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationName property is set.
        /// </summary>
        internal bool IsSetIntegrationName() => this.IntegrationName != null;

        /// <summary>
        /// Gets and sets the property IntegrationStatus. 
        /// <para>
        /// The current status of this integration.
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
        /// The type of integration. Integrations with OpenSearch Service have the type <c>OPENSEARCH</c>.
        /// </para>
        /// </summary>
        public IntegrationType IntegrationType { get; set; }

        /// <summary>
        /// Checks to see if the IntegrationType property is set.
        /// </summary>
        internal bool IsSetIntegrationType() => this.IntegrationType != null;
    }
}
