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

namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the GetProviderService operation.
    /// </summary>
    public partial class GetProviderServiceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AnonymizedOutput. 
        /// <para>
        /// Specifies whether output data from the provider is anonymized. A value of <c>TRUE</c>
        /// means the output will be anonymized and you can't relate the data that comes back
        /// from the provider to the identifying input. A value of <c>FALSE</c> means the output
        /// won't be anonymized and you can relate the data that comes back from the provider
        /// to your source data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? AnonymizedOutput { get; set; }

        /// <summary>
        /// Checks to see if the AnonymizedOutput property is set.
        /// </summary>
        internal bool IsSetAnonymizedOutput() => this.AnonymizedOutput.HasValue;

        /// <summary>
        /// Gets and sets the property ProviderComponentSchema. 
        /// <para>
        /// Input schema for the provider service.
        /// </para>
        /// </summary>
        public ProviderComponentSchema ProviderComponentSchema { get; set; }

        /// <summary>
        /// Checks to see if the ProviderComponentSchema property is set.
        /// </summary>
        internal bool IsSetProviderComponentSchema() => this.ProviderComponentSchema != null;

        /// <summary>
        /// Gets and sets the property ProviderConfigurationDefinition. 
        /// <para>
        /// The definition of the provider configuration.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderConfigurationDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ProviderConfigurationDefinition property is set.
        /// </summary>
        internal bool IsSetProviderConfigurationDefinition() => !this.ProviderConfigurationDefinition.IsNull();

        /// <summary>
        /// Gets and sets the property ProviderEndpointConfiguration. 
        /// <para>
        /// The required configuration fields to use with the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProviderEndpointConfiguration ProviderEndpointConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderEndpointConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderEndpointConfiguration() => this.ProviderEndpointConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProviderEntityOutputDefinition. 
        /// <para>
        /// The definition of the provider entity output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Amazon.Runtime.Documents.Document ProviderEntityOutputDefinition { get; set; }

        /// <summary>
        /// Checks to see if the ProviderEntityOutputDefinition property is set.
        /// </summary>
        internal bool IsSetProviderEntityOutputDefinition() => !this.ProviderEntityOutputDefinition.IsNull();

        /// <summary>
        /// Gets and sets the property ProviderIdNameSpaceConfiguration. 
        /// <para>
        /// The provider configuration required for different ID namespace types.
        /// </para>
        /// </summary>
        public ProviderIdNameSpaceConfiguration ProviderIdNameSpaceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderIdNameSpaceConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderIdNameSpaceConfiguration() => this.ProviderIdNameSpaceConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProviderIntermediateDataAccessConfiguration. 
        /// <para>
        /// The Amazon Web Services accounts and the S3 permissions that are required by some
        /// providers to create an S3 bucket for intermediate data storage.
        /// </para>
        /// </summary>
        public ProviderIntermediateDataAccessConfiguration ProviderIntermediateDataAccessConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderIntermediateDataAccessConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderIntermediateDataAccessConfiguration() => this.ProviderIntermediateDataAccessConfiguration != null;

        /// <summary>
        /// Gets and sets the property ProviderJobConfiguration. 
        /// <para>
        /// Provider service job configurations.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderJobConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ProviderJobConfiguration property is set.
        /// </summary>
        internal bool IsSetProviderJobConfiguration() => !this.ProviderJobConfiguration.IsNull();

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider. This name is typically the company name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) that Entity Resolution generated for the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 255)]
        public string ProviderServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceArn property is set.
        /// </summary>
        internal bool IsSetProviderServiceArn() => this.ProviderServiceArn != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceDisplayName. 
        /// <para>
        /// The display name of the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 255)]
        public string ProviderServiceDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceDisplayName property is set.
        /// </summary>
        internal bool IsSetProviderServiceDisplayName() => this.ProviderServiceDisplayName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceName. 
        /// <para>
        /// The name of the product that the provider service provides. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ProviderServiceName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceName property is set.
        /// </summary>
        internal bool IsSetProviderServiceName() => this.ProviderServiceName != null;

        /// <summary>
        /// Gets and sets the property ProviderServiceType. 
        /// <para>
        /// The type of provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ServiceType ProviderServiceType { get; set; }

        /// <summary>
        /// Checks to see if the ProviderServiceType property is set.
        /// </summary>
        internal bool IsSetProviderServiceType() => this.ProviderServiceType != null;
    }
}
