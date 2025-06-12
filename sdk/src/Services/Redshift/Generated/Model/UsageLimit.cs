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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a usage limit object for a cluster.
    /// </summary>
    public partial class UsageLimit
    {
        private long? _amount;
        private UsageLimitBreachAction _breachAction;
        private string _clusterIdentifier;
        private UsageLimitFeatureType _featureType;
        private UsageLimitLimitType _limitType;
        private UsageLimitPeriod _period;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _usageLimitId;

        /// <summary>
        /// Gets and sets the property Amount. 
        /// <para>
        /// The limit amount. If time-based, this amount is in minutes. If data-based, this amount
        /// is in terabytes (TB).
        /// </para>
        /// </summary>
        public long? Amount
        {
            get { return this._amount; }
            set { this._amount = value; }
        }

        // Check to see if Amount property is set
        internal bool IsSetAmount()
        {
            return this._amount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BreachAction. 
        /// <para>
        /// The action that Amazon Redshift takes when the limit is reached. Possible values are:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>log</b> - To log an event in a system table. The default is log.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>emit-metric</b> - To emit CloudWatch metrics.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>disable</b> - To disable the feature until the next usage period begins.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public UsageLimitBreachAction BreachAction
        {
            get { return this._breachAction; }
            set { this._breachAction = value; }
        }

        // Check to see if BreachAction property is set
        internal bool IsSetBreachAction()
        {
            return this._breachAction != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The identifier of the cluster with a usage limit.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// The Amazon Redshift feature to which the limit applies.
        /// </para>
        /// </summary>
        public UsageLimitFeatureType FeatureType
        {
            get { return this._featureType; }
            set { this._featureType = value; }
        }

        // Check to see if FeatureType property is set
        internal bool IsSetFeatureType()
        {
            return this._featureType != null;
        }

        /// <summary>
        /// Gets and sets the property LimitType. 
        /// <para>
        /// The type of limit. Depending on the feature type, this can be based on a time duration
        /// or data size.
        /// </para>
        /// </summary>
        public UsageLimitLimitType LimitType
        {
            get { return this._limitType; }
            set { this._limitType = value; }
        }

        // Check to see if LimitType property is set
        internal bool IsSetLimitType()
        {
            return this._limitType != null;
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The time period that the amount applies to. A <c>weekly</c> period begins on Sunday.
        /// The default is <c>monthly</c>. 
        /// </para>
        /// </summary>
        public UsageLimitPeriod Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tag instances.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property UsageLimitId. 
        /// <para>
        /// The identifier of the usage limit.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string UsageLimitId
        {
            get { return this._usageLimitId; }
            set { this._usageLimitId = value; }
        }

        // Check to see if UsageLimitId property is set
        internal bool IsSetUsageLimitId()
        {
            return this._usageLimitId != null;
        }

    }
}