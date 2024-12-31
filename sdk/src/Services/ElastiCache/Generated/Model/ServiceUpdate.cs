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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
        private bool? _autoUpdateAfterRecommendedApplyByDate;
        private string _engine;
        private string _engineVersion;
        private string _estimatedUpdateTime;
        private string _serviceUpdateDescription;
        private DateTime? _serviceUpdateEndDate;
        private string _serviceUpdateName;
        private DateTime? _serviceUpdateRecommendedApplyByDate;
        private DateTime? _serviceUpdateReleaseDate;
        private ServiceUpdateSeverity _serviceUpdateSeverity;
        private ServiceUpdateStatus _serviceUpdateStatus;
        private ServiceUpdateType _serviceUpdateType;

        /// <summary>
        /// Gets and sets the property AutoUpdateAfterRecommendedApplyByDate. 
        /// <para>
        /// Indicates whether the service update will be automatically applied once the recommended
        /// apply-by date has expired. 
        /// </para>
        /// </summary>
        public bool? AutoUpdateAfterRecommendedApplyByDate
        {
            get { return this._autoUpdateAfterRecommendedApplyByDate; }
            set { this._autoUpdateAfterRecommendedApplyByDate = value; }
        }

        // Check to see if AutoUpdateAfterRecommendedApplyByDate property is set
        internal bool IsSetAutoUpdateAfterRecommendedApplyByDate()
        {
            return this._autoUpdateAfterRecommendedApplyByDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The Elasticache engine to which the update applies. Either Valkey, Redis OSS or Memcached.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The Elasticache engine version to which the update applies. Either Valkey, Redis OSS
        /// or Memcached engine version.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EstimatedUpdateTime. 
        /// <para>
        /// The estimated length of time the service update will take
        /// </para>
        /// </summary>
        public string EstimatedUpdateTime
        {
            get { return this._estimatedUpdateTime; }
            set { this._estimatedUpdateTime = value; }
        }

        // Check to see if EstimatedUpdateTime property is set
        internal bool IsSetEstimatedUpdateTime()
        {
            return this._estimatedUpdateTime != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateDescription. 
        /// <para>
        /// Provides details of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateDescription
        {
            get { return this._serviceUpdateDescription; }
            set { this._serviceUpdateDescription = value; }
        }

        // Check to see if ServiceUpdateDescription property is set
        internal bool IsSetServiceUpdateDescription()
        {
            return this._serviceUpdateDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateEndDate. 
        /// <para>
        /// The date after which the service update is no longer available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateEndDate
        {
            get { return this._serviceUpdateEndDate; }
            set { this._serviceUpdateEndDate = value; }
        }

        // Check to see if ServiceUpdateEndDate property is set
        internal bool IsSetServiceUpdateEndDate()
        {
            return this._serviceUpdateEndDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateName. 
        /// <para>
        /// The unique ID of the service update
        /// </para>
        /// </summary>
        public string ServiceUpdateName
        {
            get { return this._serviceUpdateName; }
            set { this._serviceUpdateName = value; }
        }

        // Check to see if ServiceUpdateName property is set
        internal bool IsSetServiceUpdateName()
        {
            return this._serviceUpdateName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateRecommendedApplyByDate. 
        /// <para>
        /// The recommendend date to apply the service update in order to ensure compliance. For
        /// information on compliance, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/elasticache-compliance.html#elasticache-compliance-self-service">Self-Service
        /// Security Updates for Compliance</a>.
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateRecommendedApplyByDate
        {
            get { return this._serviceUpdateRecommendedApplyByDate; }
            set { this._serviceUpdateRecommendedApplyByDate = value; }
        }

        // Check to see if ServiceUpdateRecommendedApplyByDate property is set
        internal bool IsSetServiceUpdateRecommendedApplyByDate()
        {
            return this._serviceUpdateRecommendedApplyByDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateReleaseDate. 
        /// <para>
        /// The date when the service update is initially available
        /// </para>
        /// </summary>
        public DateTime? ServiceUpdateReleaseDate
        {
            get { return this._serviceUpdateReleaseDate; }
            set { this._serviceUpdateReleaseDate = value; }
        }

        // Check to see if ServiceUpdateReleaseDate property is set
        internal bool IsSetServiceUpdateReleaseDate()
        {
            return this._serviceUpdateReleaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateSeverity. 
        /// <para>
        /// The severity of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateSeverity ServiceUpdateSeverity
        {
            get { return this._serviceUpdateSeverity; }
            set { this._serviceUpdateSeverity = value; }
        }

        // Check to see if ServiceUpdateSeverity property is set
        internal bool IsSetServiceUpdateSeverity()
        {
            return this._serviceUpdateSeverity != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateStatus. 
        /// <para>
        /// The status of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateStatus ServiceUpdateStatus
        {
            get { return this._serviceUpdateStatus; }
            set { this._serviceUpdateStatus = value; }
        }

        // Check to see if ServiceUpdateStatus property is set
        internal bool IsSetServiceUpdateStatus()
        {
            return this._serviceUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceUpdateType. 
        /// <para>
        /// Reflects the nature of the service update
        /// </para>
        /// </summary>
        public ServiceUpdateType ServiceUpdateType
        {
            get { return this._serviceUpdateType; }
            set { this._serviceUpdateType = value; }
        }

        // Check to see if ServiceUpdateType property is set
        internal bool IsSetServiceUpdateType()
        {
            return this._serviceUpdateType != null;
        }

    }
}