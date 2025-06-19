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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a machine learning (ML) project that can contain one or more templates that
    /// set up an ML pipeline from training to deploying an approved model.
    /// </summary>
    public partial class CreateProjectRequest : AmazonSageMakerRequest
    {
        private string _projectDescription;
        private string _projectName;
        private ServiceCatalogProvisioningDetails _serviceCatalogProvisioningDetails;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<CreateTemplateProvider> _templateProviders = AWSConfigs.InitializeCollections ? new List<CreateTemplateProvider>() : null;

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// A description for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ProjectDescription
        {
            get { return this._projectDescription; }
            set { this._projectDescription = value; }
        }

        // Check to see if ProjectDescription property is set
        internal bool IsSetProjectDescription()
        {
            return this._projectDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCatalogProvisioningDetails. 
        /// <para>
        /// The product ID and provisioning artifact ID to provision a service catalog. The provisioning
        /// artifact ID will default to the latest provisioning artifact ID of the product, if
        /// you don't provide the provisioning artifact ID. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">What
        /// is Amazon Web Services Service Catalog</a>.
        /// </para>
        /// </summary>
        public ServiceCatalogProvisioningDetails ServiceCatalogProvisioningDetails
        {
            get { return this._serviceCatalogProvisioningDetails; }
            set { this._serviceCatalogProvisioningDetails = value; }
        }

        // Check to see if ServiceCatalogProvisioningDetails property is set
        internal bool IsSetServiceCatalogProvisioningDetails()
        {
            return this._serviceCatalogProvisioningDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs that you want to use to organize and track your Amazon
        /// Web Services resource costs. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services resources</a> in the <i>Amazon Web Services General Reference
        /// Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TemplateProviders. 
        /// <para>
        ///  An array of template provider configurations for creating infrastructure resources
        /// for the project. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<CreateTemplateProvider> TemplateProviders
        {
            get { return this._templateProviders; }
            set { this._templateProviders = value; }
        }

        // Check to see if TemplateProviders property is set
        internal bool IsSetTemplateProviders()
        {
            return this._templateProviders != null && (this._templateProviders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}