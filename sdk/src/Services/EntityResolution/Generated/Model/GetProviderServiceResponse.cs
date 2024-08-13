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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
        private bool? _anonymizedOutput;
        private ProviderComponentSchema _providerComponentSchema;
        private Amazon.Runtime.Documents.Document _providerConfigurationDefinition;
        private ProviderEndpointConfiguration _providerEndpointConfiguration;
        private Amazon.Runtime.Documents.Document _providerEntityOutputDefinition;
        private ProviderIdNameSpaceConfiguration _providerIdNameSpaceConfiguration;
        private ProviderIntermediateDataAccessConfiguration _providerIntermediateDataAccessConfiguration;
        private Amazon.Runtime.Documents.Document _providerJobConfiguration;
        private string _providerName;
        private string _providerServiceArn;
        private string _providerServiceDisplayName;
        private string _providerServiceName;
        private ServiceType _providerServiceType;

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
        [AWSProperty(Required=true)]
        public bool? AnonymizedOutput
        {
            get { return this._anonymizedOutput; }
            set { this._anonymizedOutput = value; }
        }

        // Check to see if AnonymizedOutput property is set
        internal bool IsSetAnonymizedOutput()
        {
            return this._anonymizedOutput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProviderComponentSchema. 
        /// <para>
        /// Input schema for the provider service.
        /// </para>
        /// </summary>
        public ProviderComponentSchema ProviderComponentSchema
        {
            get { return this._providerComponentSchema; }
            set { this._providerComponentSchema = value; }
        }

        // Check to see if ProviderComponentSchema property is set
        internal bool IsSetProviderComponentSchema()
        {
            return this._providerComponentSchema != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderConfigurationDefinition. 
        /// <para>
        /// The definition of the provider configuration.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderConfigurationDefinition
        {
            get { return this._providerConfigurationDefinition; }
            set { this._providerConfigurationDefinition = value; }
        }

        // Check to see if ProviderConfigurationDefinition property is set
        internal bool IsSetProviderConfigurationDefinition()
        {
            return !this._providerConfigurationDefinition.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ProviderEndpointConfiguration. 
        /// <para>
        /// The required configuration fields to use with the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProviderEndpointConfiguration ProviderEndpointConfiguration
        {
            get { return this._providerEndpointConfiguration; }
            set { this._providerEndpointConfiguration = value; }
        }

        // Check to see if ProviderEndpointConfiguration property is set
        internal bool IsSetProviderEndpointConfiguration()
        {
            return this._providerEndpointConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderEntityOutputDefinition. 
        /// <para>
        /// The definition of the provider entity output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document ProviderEntityOutputDefinition
        {
            get { return this._providerEntityOutputDefinition; }
            set { this._providerEntityOutputDefinition = value; }
        }

        // Check to see if ProviderEntityOutputDefinition property is set
        internal bool IsSetProviderEntityOutputDefinition()
        {
            return !this._providerEntityOutputDefinition.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ProviderIdNameSpaceConfiguration. 
        /// <para>
        /// The provider configuration required for different ID namespace types.
        /// </para>
        /// </summary>
        public ProviderIdNameSpaceConfiguration ProviderIdNameSpaceConfiguration
        {
            get { return this._providerIdNameSpaceConfiguration; }
            set { this._providerIdNameSpaceConfiguration = value; }
        }

        // Check to see if ProviderIdNameSpaceConfiguration property is set
        internal bool IsSetProviderIdNameSpaceConfiguration()
        {
            return this._providerIdNameSpaceConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderIntermediateDataAccessConfiguration. 
        /// <para>
        /// The Amazon Web Services accounts and the S3 permissions that are required by some
        /// providers to create an S3 bucket for intermediate data storage.
        /// </para>
        /// </summary>
        public ProviderIntermediateDataAccessConfiguration ProviderIntermediateDataAccessConfiguration
        {
            get { return this._providerIntermediateDataAccessConfiguration; }
            set { this._providerIntermediateDataAccessConfiguration = value; }
        }

        // Check to see if ProviderIntermediateDataAccessConfiguration property is set
        internal bool IsSetProviderIntermediateDataAccessConfiguration()
        {
            return this._providerIntermediateDataAccessConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderJobConfiguration. 
        /// <para>
        /// Provider service job configurations.
        /// </para>
        /// </summary>
        public Amazon.Runtime.Documents.Document ProviderJobConfiguration
        {
            get { return this._providerJobConfiguration; }
            set { this._providerJobConfiguration = value; }
        }

        // Check to see if ProviderJobConfiguration property is set
        internal bool IsSetProviderJobConfiguration()
        {
            return !this._providerJobConfiguration.IsNull();
        }

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// The name of the provider. This name is typically the company name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProviderName
        {
            get { return this._providerName; }
            set { this._providerName = value; }
        }

        // Check to see if ProviderName property is set
        internal bool IsSetProviderName()
        {
            return this._providerName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) that Entity Resolution generated for the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=255)]
        public string ProviderServiceArn
        {
            get { return this._providerServiceArn; }
            set { this._providerServiceArn = value; }
        }

        // Check to see if ProviderServiceArn property is set
        internal bool IsSetProviderServiceArn()
        {
            return this._providerServiceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceDisplayName. 
        /// <para>
        /// The display name of the provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=255)]
        public string ProviderServiceDisplayName
        {
            get { return this._providerServiceDisplayName; }
            set { this._providerServiceDisplayName = value; }
        }

        // Check to see if ProviderServiceDisplayName property is set
        internal bool IsSetProviderServiceDisplayName()
        {
            return this._providerServiceDisplayName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceName. 
        /// <para>
        /// The name of the product that the provider service provides. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProviderServiceName
        {
            get { return this._providerServiceName; }
            set { this._providerServiceName = value; }
        }

        // Check to see if ProviderServiceName property is set
        internal bool IsSetProviderServiceName()
        {
            return this._providerServiceName != null;
        }

        /// <summary>
        /// Gets and sets the property ProviderServiceType. 
        /// <para>
        /// The type of provider service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ServiceType ProviderServiceType
        {
            get { return this._providerServiceType; }
            set { this._providerServiceType = value; }
        }

        // Check to see if ProviderServiceType property is set
        internal bool IsSetProviderServiceType()
        {
            return this._providerServiceType != null;
        }

    }
}