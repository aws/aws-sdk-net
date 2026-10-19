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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The details of an enhanced image scan. This is returned when enhanced scanning is
    /// enabled for your private registry.
    /// </summary>
    public partial class EnhancedImageScanFinding
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the image.
        /// </para>
        /// </summary>
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
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExploitAvailable. 
        /// <para>
        /// If a finding discovered in your environment has an exploit available.
        /// </para>
        /// </summary>
        public string ExploitAvailable { get; set; }

        /// <summary>
        /// Checks to see if the ExploitAvailable property is set.
        /// </summary>
        internal bool IsSetExploitAvailable() => this.ExploitAvailable != null;

        /// <summary>
        /// Gets and sets the property FindingArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the finding.
        /// </para>
        /// </summary>
        public string FindingArn { get; set; }

        /// <summary>
        /// Checks to see if the FindingArn property is set.
        /// </summary>
        internal bool IsSetFindingArn() => this.FindingArn != null;

        /// <summary>
        /// Gets and sets the property FirstObservedAt. 
        /// <para>
        /// The date and time that the finding was first observed.
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
        /// Details on whether a fix is available through a version update. This value can be
        /// <c>YES</c>, <c>NO</c>, or <c>PARTIAL</c>. A <c>PARTIAL</c> fix means that some, but
        /// not all, of the packages identified in the finding have fixes available through updated
        /// versions.
        /// </para>
        /// </summary>
        public string FixAvailable { get; set; }

        /// <summary>
        /// Checks to see if the FixAvailable property is set.
        /// </summary>
        internal bool IsSetFixAvailable() => this.FixAvailable != null;

        /// <summary>
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// The date and time that the finding was last observed.
        /// </para>
        /// </summary>
        public DateTime? LastObservedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastObservedAt property is set.
        /// </summary>
        internal bool IsSetLastObservedAt() => this.LastObservedAt.HasValue;

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
        /// An object that contains the details about how to remediate a finding.
        /// </para>
        /// </summary>
        public Remediation Remediation { get; set; }

        /// <summary>
        /// Checks to see if the Remediation property is set.
        /// </summary>
        internal bool IsSetRemediation() => this.Remediation != null;

        /// <summary>
        /// Gets and sets the property Resources. 
        /// <para>
        /// Contains information on the resources involved in a finding.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Resource> Resources { get; set; } = AWSConfigs.InitializeCollections ? new List<Resource>() : null;

        /// <summary>
        /// Checks to see if the Resources property is set.
        /// </summary>
        internal bool IsSetResources() => this.Resources != null && (this.Resources.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The Amazon Inspector score given to the finding.
        /// </para>
        /// </summary>
        public double? Score { get; set; }

        /// <summary>
        /// Checks to see if the Score property is set.
        /// </summary>
        internal bool IsSetScore() => this.Score.HasValue;

        /// <summary>
        /// Gets and sets the property ScoreDetails. 
        /// <para>
        /// An object that contains details of the Amazon Inspector score.
        /// </para>
        /// </summary>
        public ScoreDetails ScoreDetails { get; set; }

        /// <summary>
        /// Checks to see if the ScoreDetails property is set.
        /// </summary>
        internal bool IsSetScoreDetails() => this.ScoreDetails != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        public string Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the finding.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the finding.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the finding.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the finding was last updated at.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
