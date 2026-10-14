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
    /// This is the response object from the DescribeTrial operation.
    /// </summary>
    public partial class DescribeTrialResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Who created the trial.
        /// </para>
        /// </summary>
        public UserContext CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the trial was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the trial as displayed. If <c>DisplayName</c> isn't specified, <c>TrialName</c>
        /// is displayed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property ExperimentName. 
        /// <para>
        /// The name of the experiment the trial is part of.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string ExperimentName { get; set; }

        /// <summary>
        /// Checks to see if the ExperimentName property is set.
        /// </summary>
        internal bool IsSetExperimentName() => this.ExperimentName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who last modified the trial.
        /// </para>
        /// </summary>
        public UserContext LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the trial was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property MetadataProperties.
        /// </summary>
        public MetadataProperties MetadataProperties { get; set; }

        /// <summary>
        /// Checks to see if the MetadataProperties property is set.
        /// </summary>
        internal bool IsSetMetadataProperties() => this.MetadataProperties != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source and, optionally, the job type.
        /// </para>
        /// </summary>
        public TrialSource Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property TrialArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trial.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TrialArn { get; set; }

        /// <summary>
        /// Checks to see if the TrialArn property is set.
        /// </summary>
        internal bool IsSetTrialArn() => this.TrialArn != null;

        /// <summary>
        /// Gets and sets the property TrialName. 
        /// <para>
        /// The name of the trial.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 120)]
        public string TrialName { get; set; }

        /// <summary>
        /// Checks to see if the TrialName property is set.
        /// </summary>
        internal bool IsSetTrialName() => this.TrialName != null;
    }
}
