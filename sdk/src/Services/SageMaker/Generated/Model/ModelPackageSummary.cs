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
    /// Provides summary information about a model package.
    /// </summary>
    public partial class ModelPackageSummary
    {
        private DateTime? _creationTime;
        private ModelApprovalStatus _modelApprovalStatus;
        private ModelLifeCycle _modelLifeCycle;
        private string _modelPackageArn;
        private string _modelPackageDescription;
        private string _modelPackageGroupName;
        private string _modelPackageName;
        private ModelPackageStatus _modelPackageStatus;
        private int? _modelPackageVersion;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the model package was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model. This can be one of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPROVED</c> - The model is approved
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The model is rejected.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING_MANUAL_APPROVAL</c> - The model is waiting for manual approval.
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
        /// Gets and sets the property ModelLifeCycle.
        /// </summary>
        public ModelLifeCycle ModelLifeCycle
        {
            get { return this._modelLifeCycle; }
            set { this._modelLifeCycle = value; }
        }

        // Check to see if ModelLifeCycle property is set
        internal bool IsSetModelLifeCycle()
        {
            return this._modelLifeCycle != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// A brief description of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// If the model package is a versioned model, the model group that the versioned model
        /// belongs to.
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
        /// The name of the model package.
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
        /// The overall status of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// If the model package is a versioned model, the version of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? ModelPackageVersion
        {
            get { return this._modelPackageVersion; }
            set { this._modelPackageVersion = value; }
        }

        // Check to see if ModelPackageVersion property is set
        internal bool IsSetModelPackageVersion()
        {
            return this._modelPackageVersion.HasValue; 
        }

    }
}