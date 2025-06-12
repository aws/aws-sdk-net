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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The details of an enhanced image scan. This is returned when enhanced scanning is
    /// enabled for your private registry.
    /// </summary>
    public partial class EnhancedImageScanFinding
    {
        private string _awsAccountId;
        private string _description;
        private string _exploitAvailable;
        private string _findingArn;
        private DateTime? _firstObservedAt;
        private string _fixAvailable;
        private DateTime? _lastObservedAt;
        private PackageVulnerabilityDetails _packageVulnerabilityDetails;
        private Remediation _remediation;
        private List<Resource> _resources = AWSConfigs.InitializeCollections ? new List<Resource>() : null;
        private double? _score;
        private ScoreDetails _scoreDetails;
        private string _severity;
        private string _status;
        private string _title;
        private string _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the image.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExploitAvailable. 
        /// <para>
        /// If a finding discovered in your environment has an exploit available.
        /// </para>
        /// </summary>
        public string ExploitAvailable
        {
            get { return this._exploitAvailable; }
            set { this._exploitAvailable = value; }
        }

        // Check to see if ExploitAvailable property is set
        internal bool IsSetExploitAvailable()
        {
            return this._exploitAvailable != null;
        }

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the finding.
        /// </para>
        /// </summary>
        public string FindingArn
        {
            get { return this._findingArn; }
            set { this._findingArn = value; }
        }

        // Check to see if FindingArn property is set
        internal bool IsSetFindingArn()
        {
            return this._findingArn != null;
        }

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// The date and time that the finding was first observed.
        /// </para>
        /// </summary>
        public DateTime? FirstObservedAt
        {
            get { return this._firstObservedAt; }
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
        /// Details on whether a fix is available through a version update. This value can be
        /// <c>YES</c>, <c>NO</c>, or <c>PARTIAL</c>. A <c>PARTIAL</c> fix means that some, but
        /// not all, of the packages identified in the finding have fixes available through updated
        /// versions.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// The date and time that the finding was last observed.
        /// </para>
        /// </summary>
        public DateTime? LastObservedAt
        {
            get { return this._lastObservedAt; }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt.HasValue; 
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
        /// An object that contains the details about how to remediate a finding.
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
        /// Gets and sets the property Resources. 
        /// <para>
        /// Contains information on the resources involved in a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && (this._resources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The Amazon Inspector score given to the finding.
        /// </para>
        /// </summary>
        public double? Score
        {
            get { return this._score; }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScoreDetails. 
        /// <para>
        /// An object that contains details of the Amazon Inspector score.
        /// </para>
        /// </summary>
        public ScoreDetails ScoreDetails
        {
            get { return this._scoreDetails; }
            set { this._scoreDetails = value; }
        }

        // Check to see if ScoreDetails property is set
        internal bool IsSetScoreDetails()
        {
            return this._scoreDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
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
        /// The type of the finding.
        /// </para>
        /// </summary>
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
        /// The date and time the finding was last updated at.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}