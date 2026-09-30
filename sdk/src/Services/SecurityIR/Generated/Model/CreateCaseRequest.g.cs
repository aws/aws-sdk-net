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
    /// Container for the parameters to the CreateCase operation. Creates a new case.
    /// </summary>
    public partial class CreateCaseRequest : AmazonSecurityIRRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. <note> 
        /// <para>
        /// The <c>clientToken</c> field is an idempotency key used to ensure that repeated attempts
        /// for a single action will be ignored by the server during retries. A caller supplied
        /// unique ID (typically a UUID) should be provided. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

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
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 8000)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EngagementType. 
        /// <para>
        /// Required element used in combination with CreateCase to provide an engagement type
        /// for the new cases. Available engagement types include Security Incident | Investigation
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EngagementType EngagementType { get; set; }

        /// <summary>
        /// Checks to see if the EngagementType property is set.
        /// </summary>
        internal bool IsSetEngagementType() => this.EngagementType != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public List<string> ImpactedAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ImpactedAccounts property is set.
        /// </summary>
        internal bool IsSetImpactedAccounts() => this.ImpactedAccounts != null && (this.ImpactedAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImpactedAwsRegions. 
        /// <para>
        /// An optional element used in combination with CreateCase to provide a list of impacted
        /// regions.
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
        /// An optional element used in combination with CreateCase to provide a list of services
        /// impacted.
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
        /// Gets and sets the property ReportedIncidentStartDate. 
        /// <para>
        /// Required element used in combination with CreateCase to provide an initial start date
        /// for the unauthorized activity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ReportedIncidentStartDate { get; set; }

        /// <summary>
        /// Checks to see if the ReportedIncidentStartDate property is set.
        /// </summary>
        internal bool IsSetReportedIncidentStartDate() => this.ReportedIncidentStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property ResolverType. 
        /// <para>
        /// Required element used in combination with CreateCase to identify the resolver type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResolverType ResolverType { get; set; }

        /// <summary>
        /// Checks to see if the ResolverType property is set.
        /// </summary>
        internal bool IsSetResolverType() => this.ResolverType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional element used in combination with CreateCase to add customer specified
        /// tags to a case.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThreatActorIpAddresses. 
        /// <para>
        /// An optional element used in combination with CreateCase to provide a list of suspicious
        /// internet protocol addresses associated with unauthorized activity. 
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
        /// Required element used in combination with CreateCase to provide a title for the new
        /// case.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 300)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Watchers. 
        /// <para>
        /// Required element used in combination with CreateCase to provide a list of entities
        /// to receive notifications for case updates. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 30)]
        public List<Watcher> Watchers { get; set; } = AWSConfigs.InitializeCollections ? new List<Watcher>() : null;

        /// <summary>
        /// Checks to see if the Watchers property is set.
        /// </summary>
        internal bool IsSetWatchers() => this.Watchers != null && (this.Watchers.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
