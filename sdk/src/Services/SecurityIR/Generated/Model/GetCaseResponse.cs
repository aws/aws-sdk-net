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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the GetCase operation.
    /// </summary>
    public partial class GetCaseResponse : AmazonWebServiceResponse
    {
        private DateTime? _actualIncidentStartDate;
        private string _caseArn;
        private List<CaseAttachmentAttributes> _caseAttachments = AWSConfigs.InitializeCollections ? new List<CaseAttachmentAttributes>() : null;
        private CaseStatus _caseStatus;
        private DateTime? _closedDate;
        private ClosureCode _closureCode;
        private DateTime? _createdDate;
        private string _description;
        private EngagementType _engagementType;
        private List<string> _impactedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ImpactedAwsRegion> _impactedAwsRegions = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;
        private List<string> _impactedServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _lastUpdatedDate;
        private PendingAction _pendingAction;
        private DateTime? _reportedIncidentStartDate;
        private ResolverType _resolverType;
        private List<ThreatActorIp> _threatActorIpAddresses = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;
        private string _title;
        private List<Watcher> _watchers = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Gets and sets the property ActualIncidentStartDate. 
        /// <para>
        /// Response element for GetCase that provides the actual incident start date as identified
        /// by data analysis during the investigation. 
        /// </para>
        /// </summary>
        public DateTime? ActualIncidentStartDate
        {
            get { return this._actualIncidentStartDate; }
            set { this._actualIncidentStartDate = value; }
        }

        // Check to see if ActualIncidentStartDate property is set
        internal bool IsSetActualIncidentStartDate()
        {
            return this._actualIncidentStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaseArn. 
        /// <para>
        /// Response element for GetCase that provides the case ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=80)]
        public string CaseArn
        {
            get { return this._caseArn; }
            set { this._caseArn = value; }
        }

        // Check to see if CaseArn property is set
        internal bool IsSetCaseArn()
        {
            return this._caseArn != null;
        }

        /// <summary>
        /// Gets and sets the property CaseAttachments. 
        /// <para>
        /// Response element for GetCase that provides a list of current case attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<CaseAttachmentAttributes> CaseAttachments
        {
            get { return this._caseAttachments; }
            set { this._caseAttachments = value; }
        }

        // Check to see if CaseAttachments property is set
        internal bool IsSetCaseAttachments()
        {
            return this._caseAttachments != null && (this._caseAttachments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// Response element for GetCase that provides the case status. Options for statuses include
        /// <c>Submitted | Detection and Analysis | Eradication, Containment and Recovery | Post-Incident
        /// Activities | Closed </c> 
        /// </para>
        /// </summary>
        public CaseStatus CaseStatus
        {
            get { return this._caseStatus; }
            set { this._caseStatus = value; }
        }

        // Check to see if CaseStatus property is set
        internal bool IsSetCaseStatus()
        {
            return this._caseStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ClosedDate. 
        /// <para>
        /// Response element for GetCase that provides the date a specified case was closed.
        /// </para>
        /// </summary>
        public DateTime? ClosedDate
        {
            get { return this._closedDate; }
            set { this._closedDate = value; }
        }

        // Check to see if ClosedDate property is set
        internal bool IsSetClosedDate()
        {
            return this._closedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClosureCode. 
        /// <para>
        /// Response element for GetCase that provides the summary code for why a case was closed.
        /// </para>
        /// </summary>
        public ClosureCode ClosureCode
        {
            get { return this._closureCode; }
            set { this._closureCode = value; }
        }

        // Check to see if ClosureCode property is set
        internal bool IsSetClosureCode()
        {
            return this._closureCode != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Response element for GetCase that provides the date the case was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Response element for GetCase that provides contents of the case description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8000)]
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
        /// Gets and sets the property EngagementType. 
        /// <para>
        /// Response element for GetCase that provides the engagement type. Options for engagement
        /// type include <c>Active Security Event | Investigations</c> 
        /// </para>
        /// </summary>
        public EngagementType EngagementType
        {
            get { return this._engagementType; }
            set { this._engagementType = value; }
        }

        // Check to see if EngagementType property is set
        internal bool IsSetEngagementType()
        {
            return this._engagementType != null;
        }

        /// <summary>
        /// Gets and sets the property ImpactedAccounts. 
        /// <para>
        /// Response element for GetCase that provides a list of impacted accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ImpactedAccounts
        {
            get { return this._impactedAccounts; }
            set { this._impactedAccounts = value; }
        }

        // Check to see if ImpactedAccounts property is set
        internal bool IsSetImpactedAccounts()
        {
            return this._impactedAccounts != null && (this._impactedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegions. 
        /// <para>
        /// Response element for GetCase that provides the impacted regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegions
        {
            get { return this._impactedAwsRegions; }
            set { this._impactedAwsRegions = value; }
        }

        // Check to see if ImpactedAwsRegions property is set
        internal bool IsSetImpactedAwsRegions()
        {
            return this._impactedAwsRegions != null && (this._impactedAwsRegions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedServices. 
        /// <para>
        /// Response element for GetCase that provides a list of impacted services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public List<string> ImpactedServices
        {
            get { return this._impactedServices; }
            set { this._impactedServices = value; }
        }

        // Check to see if ImpactedServices property is set
        internal bool IsSetImpactedServices()
        {
            return this._impactedServices != null && (this._impactedServices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Response element for GetCase that provides the date a case was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate
        {
            get { return this._lastUpdatedDate; }
            set { this._lastUpdatedDate = value; }
        }

        // Check to see if LastUpdatedDate property is set
        internal bool IsSetLastUpdatedDate()
        {
            return this._lastUpdatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PendingAction. 
        /// <para>
        /// Response element for GetCase that identifies the case is waiting on customer input.
        /// </para>
        /// </summary>
        public PendingAction PendingAction
        {
            get { return this._pendingAction; }
            set { this._pendingAction = value; }
        }

        // Check to see if PendingAction property is set
        internal bool IsSetPendingAction()
        {
            return this._pendingAction != null;
        }

        /// <summary>
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Response element for GetCase that provides the customer provided incident start date.
        /// </para>
        /// </summary>
        public DateTime? ReportedIncidentStartDate
        {
            get { return this._reportedIncidentStartDate; }
            set { this._reportedIncidentStartDate = value; }
        }

        // Check to see if ReportedIncidentStartDate property is set
        internal bool IsSetReportedIncidentStartDate()
        {
            return this._reportedIncidentStartDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResolverType. 
        /// <para>
        /// Response element for GetCase that provides the current resolver types.
        /// </para>
        /// </summary>
        public ResolverType ResolverType
        {
            get { return this._resolverType; }
            set { this._resolverType = value; }
        }

        // Check to see if ResolverType property is set
        internal bool IsSetResolverType()
        {
            return this._resolverType != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddresses. 
        /// <para>
        /// Response element for GetCase that provides a list of suspicious IP addresses associated
        /// with unauthorized activity. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ThreatActorIp> ThreatActorIpAddresses
        {
            get { return this._threatActorIpAddresses; }
            set { this._threatActorIpAddresses = value; }
        }

        // Check to see if ThreatActorIpAddresses property is set
        internal bool IsSetThreatActorIpAddresses()
        {
            return this._threatActorIpAddresses != null && (this._threatActorIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Response element for GetCase that provides the case title.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=300)]
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
        /// Gets and sets the property Watchers. 
        /// <para>
        /// Response element for GetCase that provides a list of Watchers added to the case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<Watcher> Watchers
        {
            get { return this._watchers; }
            set { this._watchers = value; }
        }

        // Check to see if Watchers property is set
        internal bool IsSetWatchers()
        {
            return this._watchers != null && (this._watchers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}