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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about a vulnerability scan finding that Amazon Inspector generated
    /// for an image.
    /// </summary>
    public partial class ImageScanFinding
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// The date and time when the finding was first observed.
        /// </para>
        /// </summary>
        public DateTime? FirstObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the FirstObservedAt property is set.
        /// </summary>
        internal bool IsSetFirstObservedAt() => this.FirstObservedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FixAvailable. 
        /// <para>
        /// Details about whether a fix is available for any of the packages that are identified
        /// in the finding through a version update. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YES</c> – A fix is available for all of the packages identified in the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO</c> – No fix is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PARTIAL</c> – A fix is available for some, but not all, of the packages identified
        /// in the finding.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FixAvailable { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailable property is set.
        /// </summary>
        internal bool IsSetFixAvailable() => this.FixAvailable != null;

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version that's associated with the
        /// finding.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildVersionArn property is set.
        /// </summary>
        internal bool IsSetImageBuildVersionArn() => this.ImageBuildVersionArn != null;

        /// <summary>
        /// Gets and sets the property ImagePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline that's associated with the finding.
        /// </para>
        /// </summary>
        public string ImagePipelineArn { get; set; }

        /// <summary>
        /// Checks to see if the ImagePipelineArn property is set.
        /// </summary>
        internal bool IsSetImagePipelineArn() => this.ImagePipelineArn != null;

        /// <summary>
        /// Gets and sets the property InspectorScore. 
        /// <para>
        /// The score that Amazon Inspector assigned for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public double? InspectorScore { get; set; }

        /// <summary>
        /// Checks to see if the InspectorScore property is set.
        /// </summary>
        internal bool IsSetInspectorScore() => this.InspectorScore.HasValue;

        /// <summary>
        /// Gets and sets the property InspectorScoreDetails. 
        /// <para>
        /// An object that contains details of the Amazon Inspector score.
        /// </para>
        /// </summary>
        public InspectorScoreDetails InspectorScoreDetails { get; set; }

        /// <summary>
        /// Checks to see if the InspectorScoreDetails property is set.
        /// </summary>
        internal bool IsSetInspectorScoreDetails() => this.InspectorScoreDetails != null;

        /// <summary>
        /// Gets and sets the property PackageVulnerabilityDetails. 
        /// <para>
        /// An object that contains the details of a package vulnerability finding.
        /// </para>
        /// </summary>
        public PackageVulnerabilityDetails PackageVulnerabilityDetails { get; set; }

        /// <summary>
        /// Checks to see if the PackageVulnerabilityDetails property is set.
        /// </summary>
        internal bool IsSetPackageVulnerabilityDetails() => this.PackageVulnerabilityDetails != null;

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// An object that contains the details about how to remediate the finding.
        /// </para>
        /// </summary>
        public Remediation Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding. For more information, see <a href="https://docs.aws.amazon.com/inspector/latest/user/findings-understanding-severity.html">Severity
        /// levels for Amazon Inspector findings</a> in the <i>Amazon Inspector User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the finding. Image Builder looks for findings of the type <c>PACKAGE_VULNERABILITY</c>
        /// that apply to output images, and excludes other types.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the finding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
