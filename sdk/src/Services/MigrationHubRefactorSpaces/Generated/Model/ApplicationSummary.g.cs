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
    /// The list of <c>ApplicationSummary</c> objects.
    /// </summary>
    public partial class ApplicationSummary
    {
        /// <summary>
        /// Gets and sets the property ApiGatewayProxy. 
        /// <para>
        /// The endpoint URL of the Amazon API Gateway proxy. 
        /// </para>
        /// </summary>
        public ApiGatewayProxySummary ApiGatewayProxy { get; set; }

        /// <summary>
        /// Checks to see if the ApiGatewayProxy property is set.
        /// </summary>
        internal bool IsSetApiGatewayProxy() => this.ApiGatewayProxy != null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedByAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the application creator. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string CreatedByAccountId { get; set; }

        /// <summary>
        /// Checks to see if the CreatedByAccountId property is set.
        /// </summary>
        internal bool IsSetCreatedByAccountId() => this.CreatedByAccountId != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// A timestamp that indicates when the application is created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier of the environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 14, Max = 14)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentId property is set.
        /// </summary>
        internal bool IsSetEnvironmentId() => this.EnvironmentId != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Any error associated with the application resource. 
        /// </para>
        /// </summary>
        public ErrorResponse Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// A timestamp that indicates when the application was last updated. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the application. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OwnerAccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the application owner (which is always the same
        /// as the environment owner account ID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OwnerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerAccountId property is set.
        /// </summary>
        internal bool IsSetOwnerAccountId() => this.OwnerAccountId != null;

        /// <summary>
        /// Gets and sets the property ProxyType. 
        /// <para>
        /// The proxy type of the proxy created within the application. 
        /// </para>
        /// </summary>
        public ProxyType ProxyType { get; set; }

        /// <summary>
        /// Checks to see if the ProxyType property is set.
        /// </summary>
        internal bool IsSetProxyType() => this.ProxyType != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the application. 
        /// </para>
        /// </summary>
        public ApplicationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the application. 
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
        [AWSProperty(Min = 12, Max = 21)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
