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

namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// This is the response object from the GetCase operation.
    /// </summary>
    public partial class GetCaseResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ActualIncidentStartDate. 
        /// <para>
        /// Response element for GetCase that provides the actual incident start date as identified
        /// by data analysis during the investigation. 
        /// </para>
        /// </summary>
        public DateTime? ActualIncidentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ActualIncidentStartDate property is set.
        /// </summary>
        internal bool IsSetActualIncidentStartDate() => this.ActualIncidentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property CaseArn. 
        /// <para>
        /// Response element for GetCase that provides the case ARN
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 80)]
        public string CaseArn { get; set; }

        /// <summary>
        /// Checks to see if the CaseArn property is set.
        /// </summary>
        internal bool IsSetCaseArn() => this.CaseArn != null;

        /// <summary>
        /// Gets and sets the property CaseAttachments. 
        /// <para>
        /// Response element for GetCase that provides a list of current case attachments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<CaseAttachmentAttributes> CaseAttachments { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseAttachmentAttributes>() : null;

        /// <summary>
        /// Checks to see if the CaseAttachments property is set.
        /// </summary>
        internal bool IsSetCaseAttachments() => this.CaseAttachments != null && (this.CaseAttachments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaseMetadata. 
        /// <para>
        /// Case response metadata
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public List<CaseMetadataEntry> CaseMetadata { get; set; } = AWSConfigs.InitializeCollections ? new List<CaseMetadataEntry>() : null;

        /// <summary>
        /// Checks to see if the CaseMetadata property is set.
        /// </summary>
        internal bool IsSetCaseMetadata() => this.CaseMetadata != null && (this.CaseMetadata.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// Response element for GetCase that provides the case status. Options for statuses include
        /// <c>Submitted | Detection and Analysis | Eradication, Containment and Recovery | Post-Incident
        /// Activities | Closed </c> 
        /// </para>
        /// </summary>
        public CaseStatus CaseStatus { get; set; }

        /// <summary>
        /// Checks to see if the CaseStatus property is set.
        /// </summary>
        internal bool IsSetCaseStatus() => this.CaseStatus != null;

        /// <summary>
        /// Gets and sets the property ClosedDate. 
        /// <para>
        /// Response element for GetCase that provides the date a specified case was closed.
        /// </para>
        /// </summary>
        public DateTime? ClosedDate { get; set; }

        /// <summary>
        /// Checks to see if the ClosedDate property is set.
        /// </summary>
        internal bool IsSetClosedDate() => this.ClosedDate.HasValue;

        /// <summary>
        /// Gets and sets the property ClosureCode. 
        /// <para>
        /// Response element for GetCase that provides the summary code for why a case was closed.
        /// </para>
        /// </summary>
        public ClosureCode ClosureCode { get; set; }

        /// <summary>
        /// Checks to see if the ClosureCode property is set.
        /// </summary>
        internal bool IsSetClosureCode() => this.ClosureCode != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Response element for GetCase that provides the date the case was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Response element for GetCase that provides contents of the case description.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngagementType. 
        /// <para>
        /// Response element for GetCase that provides the engagement type. Options for engagement
        /// type include <c>Active Security Event | Investigations</c> 
        /// </para>
        /// </summary>
        public EngagementType EngagementType { get; set; }

        /// <summary>
        /// Checks to see if the EngagementType property is set.
        /// </summary>
        internal bool IsSetEngagementType() => this.EngagementType != null;

        /// <summary>
        /// Gets and sets the property ImpactedAccounts. 
        /// <para>
        /// Response element for GetCase that provides a list of impacted accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> ImpactedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAccounts property is set.
        /// </summary>
        internal bool IsSetImpactedAccounts() => this.ImpactedAccounts != null && (this.ImpactedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegions. 
        /// <para>
        /// Response element for GetCase that provides the impacted regions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAwsRegions property is set.
        /// </summary>
        internal bool IsSetImpactedAwsRegions() => this.ImpactedAwsRegions != null && (this.ImpactedAwsRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedServices. 
        /// <para>
        /// Response element for GetCase that provides a list of impacted services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public List<string> ImpactedServices { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedServices property is set.
        /// </summary>
        internal bool IsSetImpactedServices() => this.ImpactedServices != null && (this.ImpactedServices.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// Response element for GetCase that provides the date a case was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PendingAction. 
        /// <para>
        /// Response element for GetCase that identifies the case is waiting on customer input.
        /// </para>
        /// </summary>
        public PendingAction PendingAction { get; set; }

        /// <summary>
        /// Checks to see if the PendingAction property is set.
        /// </summary>
        internal bool IsSetPendingAction() => this.PendingAction != null;

        /// <summary>
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Response element for GetCase that provides the customer provided incident start date.
        /// </para>
        /// </summary>
        public DateTime? ReportedIncidentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReportedIncidentStartDate property is set.
        /// </summary>
        internal bool IsSetReportedIncidentStartDate() => this.ReportedIncidentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResolverType. 
        /// <para>
        /// Response element for GetCase that provides the current resolver types.
        /// </para>
        /// </summary>
        public ResolverType ResolverType { get; set; }

        /// <summary>
        /// Checks to see if the ResolverType property is set.
        /// </summary>
        internal bool IsSetResolverType() => this.ResolverType != null;

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddresses. 
        /// <para>
        /// Response element for GetCase that provides a list of suspicious IP addresses associated
        /// with unauthorized activity. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ThreatActorIp> ThreatActorIpAddresses { get; set; } = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;

        /// <summary>
        /// Checks to see if the ThreatActorIpAddresses property is set.
        /// </summary>
        internal bool IsSetThreatActorIpAddresses() => this.ThreatActorIpAddresses != null && (this.ThreatActorIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Response element for GetCase that provides the case title.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 300)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Watchers. 
        /// <para>
        /// Response element for GetCase that provides a list of Watchers added to the case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<Watcher> Watchers { get; set; } = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Checks to see if the Watchers property is set.
        /// </summary>
        internal bool IsSetWatchers() => this.Watchers != null && (this.Watchers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
