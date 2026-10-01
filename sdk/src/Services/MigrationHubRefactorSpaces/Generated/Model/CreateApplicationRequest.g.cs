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

namespace Amazon.MigrationHubRefactorSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplication operation. Creates an Amazon
    /// Web Services Migration Hub Refactor Spaces application. The account that owns the
    /// environment also owns the applications created inside the environment, regardless
    /// of the account that creates the application. Refactor Spaces provisions an Amazon
    /// API Gateway, API Gateway VPC link, and Network Load Balancer for the application proxy
    /// inside your account. <para> In environments created with a <a href="https://docs.aws.amazon.com/migrationhub-refactor-spaces/latest/APIReference/API_CreateEnvironment.html#migrationhubrefactorspaces-CreateEnvironment-request-NetworkFabricType">CreateEnvironment:NetworkFabricType</a>
    /// of <c>NONE</c> you need to configure <a href="https://docs.aws.amazon.com/whitepapers/latest/aws-vpc-connectivity-options/amazon-vpc-to-amazon-vpc-connectivity-options.html">
    /// VPC to VPC connectivity</a> between your service VPC and the application proxy VPC
    /// to route traffic through the application proxy to a service with a private URL endpoint.
    /// For more information, see <a href="https://docs.aws.amazon.com/migrationhub-refactor-spaces/latest/userguide/getting-started-create-application.html">
    /// Create an application</a> in the <i>Refactor Spaces User Guide</i>. </para>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayProxy. 
        /// <para>
        /// A wrapper object holding the API Gateway endpoint type and stage name for the proxy.
        /// 
        /// </para>
        /// </summary>
        public ApiGatewayProxyInput ApiGatewayProxy { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayProxy property is set.
        /// </summary>
        internal bool IsSetApiGatewayProxy() => this.ApiGatewayProxy != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The unique identifier of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name to use for the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProxyType. 
        /// <para>
        /// The proxy type of the proxy created within the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProxyType ProxyType { get; set; }

        /// <summary>
        /// Checks to see if the ProxyType property is set.
        /// </summary>
        internal bool IsSetProxyType() => this.ProxyType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the application. A tag is a label that you assign to an Amazon
        /// Web Services resource. Each tag consists of a key-value pair.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
