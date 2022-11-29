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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details about an Amazon Inspector finding.
    /// </summary>
    public partial class Finding
    {
        private string _awsAccountId;
        private string _description;
        private ExploitabilityDetails _exploitabilityDetails;
        private ExploitAvailable _exploitAvailable;
        private string _findingArn;
        private DateTime? _firstObservedAt;
        private FixAvailable _fixAvailable;
        private double? _inspectorScore;
        private InspectorScoreDetails _inspectorScoreDetails;
        private DateTime? _lastObservedAt;
        private NetworkReachabilityDetails _networkReachabilityDetails;
        private PackageVulnerabilityDetails _packageVulnerabilityDetails;
        private Remediation _remediation;
        private List<Resource> _resources = new List<Resource>();
        private Severity _severity;
        private FindingStatus _status;
        private string _title;
        private FindingType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
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
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property ExploitabilityDetails. 
        /// <para>
        /// The details of an exploit available for a finding discovered in your environment.
        /// </para>
        /// </summary>
        public ExploitabilityDetails ExploitabilityDetails
        {
            get { return this._exploitabilityDetails; }
            set { this._exploitabilityDetails = value; }
        }

        // Check to see if ExploitabilityDetails property is set
        internal bool IsSetExploitabilityDetails()
        {
            return this._exploitabilityDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExploitAvailable. 
        /// <para>
        /// If a finding discovered in your environment has an exploit available.
        /// </para>
        /// </summary>
        public ExploitAvailable ExploitAvailable
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
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        [AWSProperty(Required=true)]
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
        /// Details on whether a fix is available through a version update. This value can be
        /// <code>YES</code>, <code>NO</code>, or <code>PARTIAL</code>. A <code>PARTIAL</code>
        /// fix means that some, but not all, of the packages identified in the finding have fixes
        /// available through updated versions.
        /// </para>
        /// </summary>
        public FixAvailable FixAvailable
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
        /// Gets and sets the property InspectorScore. 
        /// <para>
        /// The Amazon Inspector score given to the finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property LastObservedAt. 
        /// <para>
        /// The date and time that the finding was last observed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastObservedAt
        {
            get { return this._lastObservedAt.GetValueOrDefault(); }
            set { this._lastObservedAt = value; }
        }

        // Check to see if LastObservedAt property is set
        internal bool IsSetLastObservedAt()
        {
            return this._lastObservedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkReachabilityDetails. 
        /// <para>
        /// An object that contains the details of a network reachability finding.
        /// </para>
        /// </summary>
        public NetworkReachabilityDetails NetworkReachabilityDetails
        {
            get { return this._networkReachabilityDetails; }
            set { this._networkReachabilityDetails = value; }
        }

        // Check to see if NetworkReachabilityDetails property is set
        internal bool IsSetNetworkReachabilityDetails()
        {
            return this._networkReachabilityDetails != null;
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
        [AWSProperty(Required=true)]
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
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<Resource> Resources
        {
            get { return this._resources; }
            set { this._resources = value; }
        }

        // Check to see if Resources property is set
        internal bool IsSetResources()
        {
            return this._resources != null && this._resources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Severity Severity
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
        [AWSProperty(Required=true)]
        public FindingStatus Status
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
        /// The type of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingType Type
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