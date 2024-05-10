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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Information about a provisioning artifact (also known as a version) for a product.
    /// </summary>
    public partial class ProvisioningArtifactDetail
    {
        private bool? _active;
        private DateTime? _createdTime;
        private string _description;
        private ProvisioningArtifactGuidance _guidance;
        private string _id;
        private string _name;
        private string _sourceRevision;
        private ProvisioningArtifactType _type;

        /// <summary>
        /// Gets and sets the property Active. 
        /// <para>
        /// Indicates whether the product version is active.
        /// </para>
        /// </summary>
        public bool? Active
        {
            get { return this._active; }
            set { this._active = value; }
        }

        // Check to see if Active property is set
        internal bool IsSetActive()
        {
            return this._active.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Guidance. 
        /// <para>
        /// Information set by the administrator to provide guidance to end users about which
        /// provisioning artifacts to use.
        /// </para>
        /// </summary>
        public ProvisioningArtifactGuidance Guidance
        {
            get { return this._guidance; }
            set { this._guidance = value; }
        }

        // Check to see if Guidance property is set
        internal bool IsSetGuidance()
        {
            return this._guidance != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the provisioning artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Max=8192)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRevision. 
        /// <para>
        /// Specifies the revision of the external artifact that was used to automatically sync
        /// the Service Catalog product and create the provisioning artifact. Service Catalog
        /// includes this response parameter as a high level field to the existing <c>ProvisioningArtifactDetail</c>
        /// type, which is returned as part of the response for <c>CreateProduct</c>, <c>UpdateProduct</c>,
        /// <c>DescribeProductAsAdmin</c>, <c>DescribeProvisioningArtifact</c>, <c>ListProvisioningArtifact</c>,
        /// and <c>UpdateProvisioningArticat</c> APIs. 
        /// </para>
        ///  
        /// <para>
        /// This field only exists for Repo-Synced products. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string SourceRevision
        {
            get { return this._sourceRevision; }
            set { this._sourceRevision = value; }
        }

        // Check to see if SourceRevision property is set
        internal bool IsSetSourceRevision()
        {
            return this._sourceRevision != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of provisioning artifact.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLOUD_FORMATION_TEMPLATE</c> - CloudFormation template
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERRAFORM_OPEN_SOURCE</c> - Terraform Open Source configuration file
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERRAFORM_CLOUD</c> - Terraform Cloud configuration file
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXTERNAL</c> - External configuration file
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProvisioningArtifactType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}