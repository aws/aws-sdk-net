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
    /// Container for the parameters to the UpdateCase operation.
    /// Updates an existing case.
    /// </summary>
    public partial class UpdateCaseRequest : AmazonSecurityIRRequest
    {
        private DateTime? _actualIncidentStartDate;
        private string _caseId;
        private string _description;
        private EngagementType _engagementType;
        private List<string> _impactedAccountsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _impactedAccountsToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ImpactedAwsRegion> _impactedAwsRegionsToAdd = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;
        private List<ImpactedAwsRegion> _impactedAwsRegionsToDelete = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;
        private List<string> _impactedServicesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _impactedServicesToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _reportedIncidentStartDate;
        private List<ThreatActorIp> _threatActorIpAddressesToAdd = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;
        private List<ThreatActorIp> _threatActorIpAddressesToDelete = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;
        private string _title;
        private List<Watcher> _watchersToAdd = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;
        private List<Watcher> _watchersToDelete = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Gets and sets the property ActualIncidentStartDate. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the incident start date field.
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
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for UpdateCase to identify the case ID for updates.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the description field.
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
        /// Optional element for UpdateCase to provide content for the engagement type field.
        /// <c>Available engagement types include Security Incident | Investigation</c>. 
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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ImpactedAccountsToAdd
        {
            get { return this._impactedAccountsToAdd; }
            set { this._impactedAccountsToAdd = value; }
        }

        // Check to see if ImpactedAccountsToAdd property is set
        internal bool IsSetImpactedAccountsToAdd()
        {
            return this._impactedAccountsToAdd != null && (this._impactedAccountsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<string> ImpactedAccountsToDelete
        {
            get { return this._impactedAccountsToDelete; }
            set { this._impactedAccountsToDelete = value; }
        }

        // Check to see if ImpactedAccountsToDelete property is set
        internal bool IsSetImpactedAccountsToDelete()
        {
            return this._impactedAccountsToDelete != null && (this._impactedAccountsToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegionsToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add regions impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegionsToAdd
        {
            get { return this._impactedAwsRegionsToAdd; }
            set { this._impactedAwsRegionsToAdd = value; }
        }

        // Check to see if ImpactedAwsRegionsToAdd property is set
        internal bool IsSetImpactedAwsRegionsToAdd()
        {
            return this._impactedAwsRegionsToAdd != null && (this._impactedAwsRegionsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegionsToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove regions impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<ImpactedAwsRegion> ImpactedAwsRegionsToDelete
        {
            get { return this._impactedAwsRegionsToDelete; }
            set { this._impactedAwsRegionsToDelete = value; }
        }

        // Check to see if ImpactedAwsRegionsToDelete property is set
        internal bool IsSetImpactedAwsRegionsToDelete()
        {
            return this._impactedAwsRegionsToDelete != null && (this._impactedAwsRegionsToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedServicesToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add services impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public List<string> ImpactedServicesToAdd
        {
            get { return this._impactedServicesToAdd; }
            set { this._impactedServicesToAdd = value; }
        }

        // Check to see if ImpactedServicesToAdd property is set
        internal bool IsSetImpactedServicesToAdd()
        {
            return this._impactedServicesToAdd != null && (this._impactedServicesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImpactedServicesToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove services impacted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=600)]
        public List<string> ImpactedServicesToDelete
        {
            get { return this._impactedServicesToDelete; }
            set { this._impactedServicesToDelete = value; }
        }

        // Check to see if ImpactedServicesToDelete property is set
        internal bool IsSetImpactedServicesToDelete()
        {
            return this._impactedServicesToDelete != null && (this._impactedServicesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the customer reported incident
        /// start date field. 
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
        /// Gets and sets the property ThreatActorIpAddressesToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add additional suspicious IP
        /// addresses related to a case. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ThreatActorIp> ThreatActorIpAddressesToAdd
        {
            get { return this._threatActorIpAddressesToAdd; }
            set { this._threatActorIpAddressesToAdd = value; }
        }

        // Check to see if ThreatActorIpAddressesToAdd property is set
        internal bool IsSetThreatActorIpAddressesToAdd()
        {
            return this._threatActorIpAddressesToAdd != null && (this._threatActorIpAddressesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddressesToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove suspicious IP addresses
        /// from a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<ThreatActorIp> ThreatActorIpAddressesToDelete
        {
            get { return this._threatActorIpAddressesToDelete; }
            set { this._threatActorIpAddressesToDelete = value; }
        }

        // Check to see if ThreatActorIpAddressesToDelete property is set
        internal bool IsSetThreatActorIpAddressesToDelete()
        {
            return this._threatActorIpAddressesToDelete != null && (this._threatActorIpAddressesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// Optional element for UpdateCase to provide content for the title field.
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
        /// Gets and sets the property WatchersToAdd. 
        /// <para>
        /// Optional element for UpdateCase to provide content to add additional watchers to a
        /// case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<Watcher> WatchersToAdd
        {
            get { return this._watchersToAdd; }
            set { this._watchersToAdd = value; }
        }

        // Check to see if WatchersToAdd property is set
        internal bool IsSetWatchersToAdd()
        {
            return this._watchersToAdd != null && (this._watchersToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WatchersToDelete. 
        /// <para>
        /// Optional element for UpdateCase to provide content to remove existing watchers from
        /// a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<Watcher> WatchersToDelete
        {
            get { return this._watchersToDelete; }
            set { this._watchersToDelete = value; }
        }

        // Check to see if WatchersToDelete property is set
        internal bool IsSetWatchersToDelete()
        {
            return this._watchersToDelete != null && (this._watchersToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}