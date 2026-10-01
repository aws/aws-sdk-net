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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterService operation. This operation registers
    /// the specified service
    /// </summary>
    public partial class RegisterServiceRequest : AmazonDevOpsAgentRequest
    {
        /// <summary>
        /// Gets and sets the property ExchangeUrlPrivateConnectionName. 
        /// <para>
        /// The name of the private connection to use for OAuth token exchange requests only.
        /// Cannot be specified when privateConnectionName is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 30)]
        public string ExchangeUrlPrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the ExchangeUrlPrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetExchangeUrlPrivateConnectionName() => this.ExchangeUrlPrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the AWS Key Management Service (AWS KMS) customer managed key that's used
        /// to encrypt resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The display name for the service registration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of the private connection to use for VPC connectivity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 30)]
        public string PrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the PrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetPrivateConnectionName() => this.PrivateConnectionName != null;

        /// <summary>
        /// Gets and sets the property Service.
        /// </summary>
        [AWSProperty(Required = true)]
        public PostRegisterServiceSupportedService Service { get; set; }

        /// <summary>
        /// Checks to see if the Service property is set.
        /// </summary>
        internal bool IsSetService() => this.Service != null;

        /// <summary>
        /// Gets and sets the property ServiceDetails. 
        /// <para>
        /// Service-specific authorization configuration parameters
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceDetails ServiceDetails { get; set; }

        /// <summary>
        /// Checks to see if the ServiceDetails property is set.
        /// </summary>
        internal bool IsSetServiceDetails() => this.ServiceDetails != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags to add to the Service at registration time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetUrlPrivateConnectionName. 
        /// <para>
        /// The name of the private connection to use for API calls (target URL) only. Cannot
        /// be specified when privateConnectionName is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 30)]
        public string TargetUrlPrivateConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the TargetUrlPrivateConnectionName property is set.
        /// </summary>
        internal bool IsSetTargetUrlPrivateConnectionName() => this.TargetUrlPrivateConnectionName != null;
    }
}
