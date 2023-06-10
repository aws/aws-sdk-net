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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Contains details about a vulnerability scan finding.
    /// </summary>
    public partial class ImageScanFinding
    {
        private string _awsAccountId;
        private string _description;
        private DateTime? _firstObservedAt;
        private string _fixAvailable;
        private string _imageBuildVersionArn;
        private string _imagePipelineArn;
        private double? _inspectorScore;
        private InspectorScoreDetails _inspectorScoreDetails;
        private PackageVulnerabilityDetails _packageVulnerabilityDetails;
        private Remediation _remediation;
        private string _severity;
        private string _title;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID that's associated with the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// The date and time when the finding was first observed.
        /// </para>
        /// </summary>
        public DateTime FirstObservedAt
        {
            get { return this._firstObservedAt.GetValueOrDefault(); }
            set { this._firstObservedAt = value; }
        }

        // Check to see if FirstObservedAt property is set
        internal bool IsSetFirstObservedAt()
        {
            return this._firstObservedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FixAvailable. 
        /// <para>
        /// Details about whether a fix is available for any of the packages that are identified
        /// in the finding through a version update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FixAvailable
        {
            get { return this._fixAvailable; }
            set { this._fixAvailable = value; }
        }

        // Check to see if FixAvailable property is set
        internal bool IsSetFixAvailable()
        {
            return this._fixAvailable != null;
        }

        /// <summary>
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image build version that's associated with the
        /// finding.
        /// </para>
        /// </summary>
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImagePipelineArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image pipeline that's associated with the finding.
        /// </para>
        /// </summary>
        public string ImagePipelineArn
        {
            get { return this._imagePipelineArn; }
            set { this._imagePipelineArn = value; }
        }

        // Check to see if ImagePipelineArn property is set
        internal bool IsSetImagePipelineArn()
        {
            return this._imagePipelineArn != null;
        }

        /// <summary>
        /// Gets and sets the property InspectorScore. 
        /// <para>
        /// The score that Amazon Inspector assigned for the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public double InspectorScore
        {
            get { return this._inspectorScore.GetValueOrDefault(); }
            set { this._inspectorScore = value; }
        }

        // Check to see if InspectorScore property is set
        internal bool IsSetInspectorScore()
        {
            return this._inspectorScore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InspectorScoreDetails. 
        /// <para>
        /// An object that contains details of the Amazon Inspector score.
        /// </para>
        /// </summary>
        public InspectorScoreDetails InspectorScoreDetails
        {
            get { return this._inspectorScoreDetails; }
            set { this._inspectorScoreDetails = value; }
        }

        // Check to see if InspectorScoreDetails property is set
        internal bool IsSetInspectorScoreDetails()
        {
            return this._inspectorScoreDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PackageVulnerabilityDetails. 
        /// <para>
        /// An object that contains the details of a package vulnerability finding.
        /// </para>
        /// </summary>
        public PackageVulnerabilityDetails PackageVulnerabilityDetails
        {
            get { return this._packageVulnerabilityDetails; }
            set { this._packageVulnerabilityDetails = value; }
        }

        // Check to see if PackageVulnerabilityDetails property is set
        internal bool IsSetPackageVulnerabilityDetails()
        {
            return this._packageVulnerabilityDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// An object that contains the details about how to remediate the finding.
        /// </para>
        /// </summary>
        public Remediation Remediation
        {
            get { return this._remediation; }
            set { this._remediation = value; }
        }

        // Check to see if Remediation property is set
        internal bool IsSetRemediation()
        {
            return this._remediation != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the finding. Image Builder looks for findings of the type <code>PACKAGE_VULNERABILITY</code>
        /// that apply to output images, and excludes other types.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the finding was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}