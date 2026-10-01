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
    /// Container for the parameters to the CreateService operation. Creates an Amazon Web
    /// Services Migration Hub Refactor Spaces service. The account owner of the service is
    /// always the environment owner, regardless of which account in the environment creates
    /// the service. Services have either a URL endpoint in a virtual private cloud (VPC),
    /// or a Lambda function endpoint. <important> <para> If an Amazon Web Services resource
    /// is launched in a service VPC, and you want it to be accessible to all of an environment’s
    /// services with VPCs and routes, apply the <c>RefactorSpacesSecurityGroup</c> to the
    /// resource. Alternatively, to add more cross-account constraints, apply your own security
    /// group. </para> </important>
    /// </summary>
    public partial class CreateServiceRequest : AmazonMigrationHubRefactorSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationIdentifier. 
        /// <para>
        /// The ID of the application which the service is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string ApplicationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationIdentifier property is set.
        /// </summary>
        internal bool IsSetApplicationIdentifier() => this.ApplicationIdentifier != null;

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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint to use for the service. The type can be a URL in a VPC or an
        /// Lambda function.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceEndpointType EndpointType { get; set; }

        /// <summary>
        /// Checks to see if the EndpointType property is set.
        /// </summary>
        internal bool IsSetEndpointType() => this.EndpointType != null;

        /// <summary>
        /// Gets and sets the property EnvironmentIdentifier. 
        /// <para>
        /// The ID of the environment in which the service is created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 14, Max = 14)]
        public string EnvironmentIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentIdentifier property is set.
        /// </summary>
        internal bool IsSetEnvironmentIdentifier() => this.EnvironmentIdentifier != null;

        /// <summary>
        /// Gets and sets the property LambdaEndpoint. 
        /// <para>
        /// The configuration for the Lambda endpoint type.
        /// </para>
        /// </summary>
        public LambdaEndpointInput LambdaEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the LambdaEndpoint property is set.
        /// </summary>
        internal bool IsSetLambdaEndpoint() => this.LambdaEndpoint != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to assign to the service. A tag is a label that you assign to an Amazon Web
        /// Services resource. Each tag consists of a key-value pair.. 
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
        /// Gets and sets the property UrlEndpoint. 
        /// <para>
        /// The configuration for the URL endpoint type. When creating a route to a service, Refactor
        /// Spaces automatically resolves the address in the <c>UrlEndpointInput</c> object URL
        /// when the Domain Name System (DNS) time-to-live (TTL) expires, or every 60 seconds
        /// for TTLs less than 60 seconds.
        /// </para>
        /// </summary>
        public UrlEndpointInput UrlEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the UrlEndpoint property is set.
        /// </summary>
        internal bool IsSetUrlEndpoint() => this.UrlEndpoint != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
