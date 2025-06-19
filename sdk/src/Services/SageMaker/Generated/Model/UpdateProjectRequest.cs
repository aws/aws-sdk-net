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
    /// Container for the parameters to the UpdateProject operation.
    /// Updates a machine learning (ML) project that is created from a template that sets
    /// up an ML pipeline from training to deploying an approved model.
    /// 
    ///  <note> 
    /// <para>
    /// You must not update a project that is in use. If you update the <c>ServiceCatalogProvisioningUpdateDetails</c>
    /// of a project that is active or being created, or updated, you may lose resources already
    /// created by the project.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateProjectRequest : AmazonSageMakerRequest
    {
        private string _projectDescription;
        private string _projectName;
        private ServiceCatalogProvisioningUpdateDetails _serviceCatalogProvisioningUpdateDetails;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<UpdateTemplateProvider> _templateProvidersToUpdate = AWSConfigs.InitializeCollections ? new List<UpdateTemplateProvider>() : null;

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// The description for the project.
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
        /// Gets and sets the property ServiceCatalogProvisioningUpdateDetails. 
        /// <para>
        /// The product ID and provisioning artifact ID to provision a service catalog. The provisioning
        /// artifact ID will default to the latest provisioning artifact ID of the product, if
        /// you don't provide the provisioning artifact ID. For more information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">What
        /// is Amazon Web Services Service Catalog</a>. 
        /// </para>
        /// </summary>
        public ServiceCatalogProvisioningUpdateDetails ServiceCatalogProvisioningUpdateDetails
        {
            get { return this._serviceCatalogProvisioningUpdateDetails; }
            set { this._serviceCatalogProvisioningUpdateDetails = value; }
        }

        // Check to see if ServiceCatalogProvisioningUpdateDetails property is set
        internal bool IsSetServiceCatalogProvisioningUpdateDetails()
        {
            return this._serviceCatalogProvisioningUpdateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs. You can use tags to categorize your Amazon Web Services
        /// resources in different ways, for example, by purpose, owner, or environment. For more
        /// information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// Amazon Web Services Resources</a>. In addition, the project must have tag update constraints
        /// set in order to include this parameter in the request. For more information, see <a
        /// href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/constraints-resourceupdate.html">Amazon
        /// Web Services Service Catalog Tag Update Constraints</a>.
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
        /// Gets and sets the property TemplateProvidersToUpdate. 
        /// <para>
        ///  The template providers to update in the project. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<UpdateTemplateProvider> TemplateProvidersToUpdate
        {
            get { return this._templateProvidersToUpdate; }
            set { this._templateProvidersToUpdate = value; }
        }

        // Check to see if TemplateProvidersToUpdate property is set
        internal bool IsSetTemplateProvidersToUpdate()
        {
            return this._templateProvidersToUpdate != null && (this._templateProvidersToUpdate.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}