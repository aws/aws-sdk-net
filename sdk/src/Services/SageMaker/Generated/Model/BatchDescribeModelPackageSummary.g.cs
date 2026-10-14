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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides summary information about the model package.
    /// </summary>
    public partial class BatchDescribeModelPackageSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the mortgage package summary.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property InferenceSpecification.
        /// </summary>
        [AWSProperty(Required = true)]
        public InferenceSpecification InferenceSpecification { get; set; }

        /// <summary>
        /// Checks to see if the InferenceSpecification property is set.
        /// </summary>
        internal bool IsSetInferenceSpecification() => this.InferenceSpecification != null;

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// The approval status of the model.
        /// </para>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelApprovalStatus property is set.
        /// </summary>
        internal bool IsSetModelApprovalStatus() => this.ModelApprovalStatus != null;

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;

        /// <summary>
        /// Gets and sets the property ModelPackageDescription. 
        /// <para>
        /// The description of the model package.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ModelPackageDescription { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageDescription property is set.
        /// </summary>
        internal bool IsSetModelPackageDescription() => this.ModelPackageDescription != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// The group name for the model package
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

        /// <summary>
        /// Gets and sets the property ModelPackageRegistrationType. 
        /// <para>
        ///  The package registration type of the model package summary. 
        /// </para>
        /// </summary>
        public ModelPackageRegistrationType ModelPackageRegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageRegistrationType property is set.
        /// </summary>
        internal bool IsSetModelPackageRegistrationType() => this.ModelPackageRegistrationType != null;

        /// <summary>
        /// Gets and sets the property ModelPackageStatus. 
        /// <para>
        /// The status of the mortgage package.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelPackageStatus ModelPackageStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageStatus property is set.
        /// </summary>
        internal bool IsSetModelPackageStatus() => this.ModelPackageStatus != null;

        /// <summary>
        /// Gets and sets the property ModelPackageVersion. 
        /// <para>
        /// The version number of a versioned model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public int? ModelPackageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageVersion property is set.
        /// </summary>
        internal bool IsSetModelPackageVersion() => this.ModelPackageVersion.HasValue;
    }
}
