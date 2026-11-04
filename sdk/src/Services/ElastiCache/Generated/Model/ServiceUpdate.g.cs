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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// An update that you can apply to your Valkey or Redis OSS clusters.
    /// </summary>
    public partial class ServiceUpdate
    {
        /// <summary>
        /// Gets and sets the property AutoUpdateAfterRecommendedApplyByDate. 
        /// <para>
        /// Indicates whether the service update will be automatically applied once the recommended
        /// apply-by date has expired. 
        /// </para>
        /// </summary>
        public bool? AutoUpdateAfterRecommendedApplyByDate { get; set; }

        /// <summary>
        /// Checks to see if the AutoUpdateAfterRecommendedApplyByDate property is set.
        /// </summary>
        internal bool IsSetAutoUpdateAfterRecommendedApplyByDate() => this.AutoUpdateAfterRecommendedApplyByDate.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Elasticache engine to which the update applies. Either Valkey, Redis OSS or Memcached.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Elasticache engine version to which the update applies. Either Valkey, Redis OSS
        /// or Memcached engine version.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property EstimatedUpdateTime. 
        /// <para>
        /// The estimated length of time the service update will take
        /// </para>
        /// </summary>
        public string EstimatedUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedUpdateTime property is set.
        /// </summary>
        internal bool IsSetEstimatedUpdateTime() => this.EstimatedUpdateTime != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateDescription. 
        /// <para>
        /// Provides details of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateDescription { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateDescription property is set.
        /// </summary>
        internal bool IsSetServiceUpdateDescription() => this.ServiceUpdateDescription != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateEndDate. 
        /// <para>
        /// The date after which the service update is no longer available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateEndDate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateEndDate property is set.
        /// </summary>
        internal bool IsSetServiceUpdateEndDate() => this.ServiceUpdateEndDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateName property is set.
        /// </summary>
        internal bool IsSetServiceUpdateName() => this.ServiceUpdateName != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateRecommendedApplyByDate. 
        /// <para>
        /// The recommendend date to apply the service update in order to ensure compliance. For
        /// information on compliance, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/elasticache-compliance.html#elasticache-compliance-self-service">Self-Service
        /// Security Updates for Compliance</a>.
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateRecommendedApplyByDate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateRecommendedApplyByDate property is set.
        /// </summary>
        internal bool IsSetServiceUpdateRecommendedApplyByDate() => this.ServiceUpdateRecommendedApplyByDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateReleaseDate. 
        /// <para>
        /// The date when the service update is initially available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateReleaseDate property is set.
        /// </summary>
        internal bool IsSetServiceUpdateReleaseDate() => this.ServiceUpdateReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceUpdateSeverity. 
        /// <para>
        /// The severity of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateSeverity ServiceUpdateSeverity { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateSeverity property is set.
        /// </summary>
        internal bool IsSetServiceUpdateSeverity() => this.ServiceUpdateSeverity != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus ServiceUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateStatus property is set.
        /// </summary>
        internal bool IsSetServiceUpdateStatus() => this.ServiceUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property ServiceUpdateType. 
        /// <para>
        /// Reflects the nature of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateType ServiceUpdateType { get; set; }

        /// <summary>
        /// Checks to see if the ServiceUpdateType property is set.
        /// </summary>
        internal bool IsSetServiceUpdateType() => this.ServiceUpdateType != null;
    }
}
