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
    /// Container for the parameters to the CreateCase operation.
    /// Creates a new case.
    /// </summary>
    public partial class CreateCaseRequest : AmazonSecurityIRRequest
    {
        private string _clientToken;
        private string _description;
        private EngagementType _engagementType;
        private List<string> _impactedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<ImpactedAwsRegion> _impactedAwsRegions = AWSConfigs.InitializeCollections ? new List<ImpactedAwsRegion>() : null;
        private List<string> _impactedServices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _reportedIncidentStartDate;
        private ResolverType _resolverType;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<ThreatActorIp> _threatActorIpAddresses = AWSConfigs.InitializeCollections ? new List<ThreatActorIp>() : null;
        private string _title;
        private List<Watcher> _watchers = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// <note> 
        /// <para>
        /// The <c>clientToken</c> field is an idempotency key used to ensure that repeated attempts
        /// for a single action will be ignored by the server during retries. A caller supplied
        /// unique ID (typically a UUID) should be provided. 
        /// </para>
        ///  </note>
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Required element used in combination with CreateCase
        /// </para>
        ///  
        /// <para>
        /// to provide a description for the new case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=8000)]
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
        /// Required element used in combination with CreateCase to provide an engagement type
        /// for the new cases. Available engagement types include Security Incident | Investigation
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Required element used in combination with CreateCase to provide a list of impacted
        /// accounts.
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
        [AWSProperty(Required=true, Min=0, Max=200)]
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
        /// An optional element used in combination with CreateCase to provide a list of impacted
        /// regions.
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
        /// An optional element used in combination with CreateCase to provide a list of services
        /// impacted.
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
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Required element used in combination with CreateCase to provide an initial start date
        /// for the unauthorized activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Required element used in combination with CreateCase to identify the resolver type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional element used in combination with CreateCase to add customer specified
        /// tags to a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddresses. 
        /// <para>
        /// An optional element used in combination with CreateCase to provide a list of suspicious
        /// internet protocol addresses associated with unauthorized activity. 
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
        /// Required element used in combination with CreateCase to provide a title for the new
        /// case.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=300)]
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
        /// Required element used in combination with CreateCase to provide a list of entities
        /// to receive notifications for case updates. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=30)]
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