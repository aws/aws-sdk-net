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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeProject operation.
    /// </summary>
    public partial class DescribeProjectResponse : AmazonWebServiceResponse
    {
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private string _projectArn;
        private string _projectDescription;
        private string _projectId;
        private string _projectName;
        private ProjectStatus _projectStatus;
        private ServiceCatalogProvisionedProductDetails _serviceCatalogProvisionedProductDetails;
        private ServiceCatalogProvisioningDetails _serviceCatalogProvisioningDetails;

        /// <summary>
        /// Gets and sets the property CreatedBy.
        /// </summary>
        public UserContext CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the project was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectDescription. 
        /// <para>
        /// The description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property ProjectId. 
        /// <para>
        /// The ID of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string ProjectId
        {
            get { return this._projectId; }
            set { this._projectId = value; }
        }

        // Check to see if ProjectId property is set
        internal bool IsSetProjectId()
        {
            return this._projectId != null;
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
        /// Gets and sets the property ProjectStatus. 
        /// <para>
        /// The status of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProjectStatus ProjectStatus
        {
            get { return this._projectStatus; }
            set { this._projectStatus = value; }
        }

        // Check to see if ProjectStatus property is set
        internal bool IsSetProjectStatus()
        {
            return this._projectStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCatalogProvisionedProductDetails. 
        /// <para>
        /// Information about a provisioned service catalog product.
        /// </para>
        /// </summary>
        public ServiceCatalogProvisionedProductDetails ServiceCatalogProvisionedProductDetails
        {
            get { return this._serviceCatalogProvisionedProductDetails; }
            set { this._serviceCatalogProvisionedProductDetails = value; }
        }

        // Check to see if ServiceCatalogProvisionedProductDetails property is set
        internal bool IsSetServiceCatalogProvisionedProductDetails()
        {
            return this._serviceCatalogProvisionedProductDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceCatalogProvisioningDetails. 
        /// <para>
        /// Information used to provision a service catalog product. For information, see <a href="https://docs.aws.amazon.com/servicecatalog/latest/adminguide/introduction.html">What
        /// is AWS Service Catalog</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}