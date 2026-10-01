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
    /// Container for the parameters to the UpdateCase operation. Updates an existing case.
    /// </summary>
    public partial class UpdateCaseRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property ActualIncidentStartDate. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the incident start date field.
        /// </para>
        /// </summary>
        public DateTime? ActualIncidentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ActualIncidentStartDate property is set.
        /// </summary>
        internal bool IsSetActualIncidentStartDate() => this.ActualIncidentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for UpdateCase to identify the case ID for updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 32)]
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property CaseMetadata. 
        /// <para>
        /// Update the case request with case metadata
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
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the description field.
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
        /// Optional element for UpdateCase to provide content for the engagement type field.
        /// <c>Available engagement types include Security Incident | Investigation</c>. 
        /// </para>
        /// </summary>
        public EngagementType EngagementType { get; set; }

        /// <summary>
        /// Checks to see if the EngagementType property is set.
        /// </summary>
        internal bool IsSetEngagementType() => this.EngagementType != null;

        /// <summary>
        /// Gets and sets the property ImpactedAccountsToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add accounts impacted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> ImpactedAccountsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAccountsToAdd property is set.
        /// </summary>
        internal bool IsSetImpactedAccountsToAdd() => this.ImpactedAccountsToAdd != null && (this.ImpactedAccountsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAccountsToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add accounts impacted.
        /// </para>
        ///  <note> 
        /// <para>
        ///  AWS account ID's may appear less than 12 characters and need to be zero-prepended.
        /// An example would be <c>123123123</c> which is nine digits, and with zero-prepend would
        /// be <c>000123123123</c>. Not zero-prepending to 12 digits could result in errors. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<string> ImpactedAccountsToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAccountsToDelete property is set.
        /// </summary>
        internal bool IsSetImpactedAccountsToDelete() => this.ImpactedAccountsToDelete != null && (this.ImpactedAccountsToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegionsToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add regions impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegionsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAwsRegionsToAdd property is set.
        /// </summary>
        internal bool IsSetImpactedAwsRegionsToAdd() => this.ImpactedAwsRegionsToAdd != null && (this.ImpactedAwsRegionsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegionsToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove regions impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegionsToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAwsRegionsToDelete property is set.
        /// </summary>
        internal bool IsSetImpactedAwsRegionsToDelete() => this.ImpactedAwsRegionsToDelete != null && (this.ImpactedAwsRegionsToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedServicesToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add services impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public List<string> ImpactedServicesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedServicesToAdd property is set.
        /// </summary>
        internal bool IsSetImpactedServicesToAdd() => this.ImpactedServicesToAdd != null && (this.ImpactedServicesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedServicesToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove services impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 600)]
        public List<string> ImpactedServicesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedServicesToDelete property is set.
        /// </summary>
        internal bool IsSetImpactedServicesToDelete() => this.ImpactedServicesToDelete != null && (this.ImpactedServicesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the customer reported incident
        /// start date field. 
        /// </para>
        /// </summary>
        public DateTime? ReportedIncidentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReportedIncidentStartDate property is set.
        /// </summary>
        internal bool IsSetReportedIncidentStartDate() => this.ReportedIncidentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddressesToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add additional suspicious IP
        /// addresses related to a case. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ThreatActorIp> ThreatActorIpAddressesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;

        /// <summary>
        /// Checks to see if the ThreatActorIpAddressesToAdd property is set.
        /// </summary>
        internal bool IsSetThreatActorIpAddressesToAdd() => this.ThreatActorIpAddressesToAdd != null && (this.ThreatActorIpAddressesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddressesToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove suspicious IP addresses
        /// from a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<ThreatActorIp> ThreatActorIpAddressesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;

        /// <summary>
        /// Checks to see if the ThreatActorIpAddressesToDelete property is set.
        /// </summary>
        internal bool IsSetThreatActorIpAddressesToDelete() => this.ThreatActorIpAddressesToDelete != null && (this.ThreatActorIpAddressesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the title field.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 300)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property WatchersToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add additional watchers to a
        /// case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<Watcher> WatchersToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Checks to see if the WatchersToAdd property is set.
        /// </summary>
        internal bool IsSetWatchersToAdd() => this.WatchersToAdd != null && (this.WatchersToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WatchersToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove existing watchers from
        /// a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<Watcher> WatchersToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Checks to see if the WatchersToDelete property is set.
        /// </summary>
        internal bool IsSetWatchersToDelete() => this.WatchersToDelete != null && (this.WatchersToDelete.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
