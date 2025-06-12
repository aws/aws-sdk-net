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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// The details of a DDoS attack.
    /// </summary>
    public partial class AttackDetail
    {
        private List<SummarizedCounter> _attackCounters = AWSConfigs.InitializeCollections ? new List<SummarizedCounter>() : null;
        private string _attackId;
        private List<AttackProperty> _attackProperties = AWSConfigs.InitializeCollections ? new List<AttackProperty>() : null;
        private DateTime? _endTime;
        private List<Mitigation> _mitigations = AWSConfigs.InitializeCollections ? new List<Mitigation>() : null;
        private string _resourceArn;
        private DateTime? _startTime;
        private List<SubResourceSummary> _subResources = AWSConfigs.InitializeCollections ? new List<SubResourceSummary>() : null;

        /// <summary>
        /// Gets and sets the property AttackCounters. 
        /// <para>
        /// List of counters that describe the attack for the specified time period.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SummarizedCounter> AttackCounters
        {
            get { return this._attackCounters; }
            set { this._attackCounters = value; }
        }

        // Check to see if AttackCounters property is set
        internal bool IsSetAttackCounters()
        {
            return this._attackCounters != null && (this._attackCounters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AttackId. 
        /// <para>
        /// The unique identifier (ID) of the attack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string AttackId
        {
            get { return this._attackId; }
            set { this._attackId = value; }
        }

        // Check to see if AttackId property is set
        internal bool IsSetAttackId()
        {
            return this._attackId != null;
        }

        /// <summary>
        /// Gets and sets the property AttackProperties. 
        /// <para>
        /// The array of objects that provide details of the Shield event. 
        /// </para>
        ///  
        /// <para>
        /// For infrastructure layer events (L3 and L4 events), you can view metrics for top contributors
        /// in Amazon CloudWatch metrics. For more information, see <a href="https://docs.aws.amazon.com/waf/latest/developerguide/monitoring-cloudwatch.html#set-ddos-alarms">Shield
        /// metrics and alarms</a> in the <i>WAF Developer Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AttackProperty> AttackProperties
        {
            get { return this._attackProperties; }
            set { this._attackProperties = value; }
        }

        // Check to see if AttackProperties property is set
        internal bool IsSetAttackProperties()
        {
            return this._attackProperties != null && (this._attackProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time the attack ended, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mitigations. 
        /// <para>
        /// List of mitigation actions taken for the attack.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Mitigation> Mitigations
        {
            get { return this._mitigations; }
            set { this._mitigations = value; }
        }

        // Check to see if Mitigations property is set
        internal bool IsSetMitigations()
        {
            return this._mitigations != null && (this._mitigations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN (Amazon Resource Name) of the resource that was attacked.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the attack started, in Unix time in seconds. 
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubResources. 
        /// <para>
        /// If applicable, additional detail about the resource being attacked, for example, IP
        /// address or URL.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SubResourceSummary> SubResources
        {
            get { return this._subResources; }
            set { this._subResources = value; }
        }

        // Check to see if SubResources property is set
        internal bool IsSetSubResources()
        {
            return this._subResources != null && (this._subResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}