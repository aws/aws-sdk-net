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
    /// A versioned model that can be deployed for SageMaker inference.
    /// </summary>
    public partial class ModelPackage
    {
        private string _approvalDescription;
        private bool? _certifyForMarketplace;
        private UserContext _createdBy;
        private DateTime? _creationTime;
        private InferenceSpecification _inferenceSpecification;
        private UserContext _lastModifiedBy;
        private DateTime? _lastModifiedTime;
        private MetadataProperties _metadataProperties;
        private ModelApprovalStatus _modelApprovalStatus;
        private ModelMetrics _modelMetrics;
        private string _modelPackageArn;
        private string _modelPackageDescription;
        private string _modelPackageGroupName;
        private string _modelPackageName;
        private ModelPackageStatus _modelPackageStatus;
        private ModelPackageStatusDetails _modelPackageStatusDetails;
        private int? _modelPackageVersion;
        private SourceAlgorithmSpecification _sourceAlgorithmSpecification;
        private List<Tag> _tags = new List<Tag>();
        private ModelPackageValidationSpecification _validationSpecification;

        /// <summary>
        /// Gets and sets the property ApprovalDescription. 
        /// <para>
        /// A description provided when the model approval is set.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ApprovalDescription
        {
            get { return this._approvalDescription; }
            set { this._approvalDescription = value; }
        }

        // Check to see if ApprovalDescription property is set
        internal bool IsSetApprovalDescription()
        {
            return this._approvalDescription != null;
        }

        /// <summary>
        /// Gets and sets the property CertifyForMarketplace. 
        /// <para>
        /// Whether the model package is to be certified to be listed on AWS Marketplace. For
        /// information about listing model packages on AWS Marketplace, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-mkt-list.html">List
        /// Your Algorithm or Model Package on AWS Marketplace</a>.
        /// </para>
        /// </summary>
        public bool CertifyForMarketplace
        {
            get { return this._certifyForMarketplace.GetValueOrDefault(); }
            set { this._certifyForMarketplace = value; }
        }

        // Check to see if CertifyForMarketplace property is set
        internal bool IsSetCertifyForMarketplace()
        {
            return this._certifyForMarketplace.HasValue; 
        }

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
        /// The time that the model package was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property InferenceSpecification.
        /// </summary>
        public InferenceSpecification InferenceSpecification
        {
            get { return this._inferenceSpecification; }
            set { this._inferenceSpecification = value; }
        }

        // Check to see if InferenceSpecification property is set
        internal bool IsSetInferenceSpecification()
        {
            return this._inferenceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedBy.
        /// </summary>
        public UserContext LastModifiedBy
        {
            get { return this._lastModifiedBy; }
            set { this._lastModifiedBy = value; }
        }

        // Check to see if LastModifiedBy property is set
        internal bool IsSetLastModifiedBy()
        {
            return this._lastModifiedBy != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time the model package was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties
        {
            get { return this._metadataProperties; }
            set { this._metadataProperties = value; }
        }

        // Check to see if MetadataProperties property is set
        internal bool IsSetMetadataProperties()
        {
            return this._metadataProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>APPROVED</code> - The model is approved
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REJECTED</code> - The model is rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING_MANUAL_APPROVAL</code> - The model is waiting for manual approval.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus
        {
            get { return this._modelApprovalStatus; }
            set { this._modelApprovalStatus = value; }
        }

        // Check to see if ModelApprovalStatus property is set
        internal bool IsSetModelApprovalStatus()
        {
            return this._modelApprovalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Metrics for the model.
        /// </para>
        /// </summary>
        public ModelMetrics ModelMetrics
        {
            get { return this._modelMetrics; }
            set { this._modelMetrics = value; }
        }

        // Check to see if ModelMetrics property is set
        internal bool IsSetModelMetrics()
        {
            return this._modelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelPackageArn
        {
            get { return this._modelPackageArn; }
            set { this._modelPackageArn = value; }
        }

        // Check to see if ModelPackageArn property is set
        internal bool IsSetModelPackageArn()
        {
            return this._modelPackageArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// The description of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string ModelPackageDescription
        {
            get { return this._modelPackageDescription; }
            set { this._modelPackageDescription = value; }
        }

        // Check to see if ModelPackageDescription property is set
        internal bool IsSetModelPackageDescription()
        {
            return this._modelPackageDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The model group to which the model belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageName. 
        /// <para>
        /// The name of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ModelPackageName
        {
            get { return this._modelPackageName; }
            set { this._modelPackageName = value; }
        }

        // Check to see if ModelPackageName property is set
        internal bool IsSetModelPackageName()
        {
            return this._modelPackageName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageStatus. 
        /// <para>
        /// The status of the model package. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> - The model package is pending being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> - The model package is in the process of being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>COMPLETED</code> - The model package was successfully created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - The model package failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - The model package is in the process of being deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelPackageStatus ModelPackageStatus
        {
            get { return this._modelPackageStatus; }
            set { this._modelPackageStatus = value; }
        }

        // Check to see if ModelPackageStatus property is set
        internal bool IsSetModelPackageStatus()
        {
            return this._modelPackageStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageStatusDetails.
        /// </summary>
        public ModelPackageStatusDetails ModelPackageStatusDetails
        {
            get { return this._modelPackageStatusDetails; }
            set { this._modelPackageStatusDetails = value; }
        }

        // Check to see if ModelPackageStatusDetails property is set
        internal bool IsSetModelPackageStatusDetails()
        {
            return this._modelPackageStatusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// The version number of a versioned model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int ModelPackageVersion
        {
            get { return this._modelPackageVersion.GetValueOrDefault(); }
            set { this._modelPackageVersion = value; }
        }

        // Check to see if ModelPackageVersion property is set
        internal bool IsSetModelPackageVersion()
        {
            return this._modelPackageVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceAlgorithmSpecification.
        /// </summary>
        public SourceAlgorithmSpecification SourceAlgorithmSpecification
        {
            get { return this._sourceAlgorithmSpecification; }
            set { this._sourceAlgorithmSpecification = value; }
        }

        // Check to see if SourceAlgorithmSpecification property is set
        internal bool IsSetSourceAlgorithmSpecification()
        {
            return this._sourceAlgorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of the tags associated with the model package. For more information, see <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging AWS
        /// resources</a> in the <i>AWS General Reference Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ValidationSpecification.
        /// </summary>
        public ModelPackageValidationSpecification ValidationSpecification
        {
            get { return this._validationSpecification; }
            set { this._validationSpecification = value; }
        }

        // Check to see if ValidationSpecification property is set
        internal bool IsSetValidationSpecification()
        {
            return this._validationSpecification != null;
        }

    }
}