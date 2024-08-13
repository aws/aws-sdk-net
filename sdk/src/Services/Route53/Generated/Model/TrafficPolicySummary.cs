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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains information about the latest version of one traffic policy
    /// that is associated with the current Amazon Web Services account.
    /// </summary>
    public partial class TrafficPolicySummary
    {
        private string _id;
        private string _name;
        private RRType _type;
        private int? _latestVersion;
        private int? _trafficPolicyCount;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID that Amazon Route 53 assigned to the traffic policy when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you specified for the traffic policy when you created it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The DNS type of the resource record sets that Amazon Route 53 creates when you use
        /// a traffic policy to create a traffic policy instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RRType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// The version number of the latest version of the traffic policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrafficPolicyCount. 
        /// <para>
        /// The number of traffic policies that are associated with the current Amazon Web Services
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int? TrafficPolicyCount
        {
            get { return this._trafficPolicyCount; }
            set { this._trafficPolicyCount = value; }
        }

        // Check to see if TrafficPolicyCount property is set
        internal bool IsSetTrafficPolicyCount()
        {
            return this._trafficPolicyCount.HasValue; 
        }

    }
}