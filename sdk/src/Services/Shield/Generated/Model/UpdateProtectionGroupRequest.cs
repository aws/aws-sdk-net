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
    /// Container for the parameters to the UpdateProtectionGroup operation.
    /// Updates an existing protection group. A protection group is a grouping of protected
    /// resources so they can be handled as a collective. This resource grouping improves
    /// the accuracy of detection and reduces false positives.
    /// </summary>
    public partial class UpdateProtectionGroupRequest : AmazonShieldRequest
    {
        private ProtectionGroupAggregation _aggregation;
        private List<string> _members = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ProtectionGroupPattern _pattern;
        private string _protectionGroupId;
        private ProtectedResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Aggregation. 
        /// <para>
        /// Defines how Shield combines resource data for the group in order to detect, mitigate,
        /// and report events.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sum - Use the total traffic across the group. This is a good choice for most cases.
        /// Examples include Elastic IP addresses for EC2 instances that scale manually or automatically.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Mean - Use the average of the traffic across the group. This is a good choice for
        /// resources that share traffic uniformly. Examples include accelerators and load balancers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Max - Use the highest traffic from each resource. This is useful for resources that
        /// don't share traffic and for resources that share that traffic in a non-uniform way.
        /// Examples include Amazon CloudFront distributions and origin resources for CloudFront
        /// distributions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionGroupAggregation Aggregation
        {
            get { return this._aggregation; }
            set { this._aggregation = value; }
        }

        // Check to see if Aggregation property is set
        internal bool IsSetAggregation()
        {
            return this._aggregation != null;
        }

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The Amazon Resource Names (ARNs) of the resources to include in the protection group.
        /// You must set this when you set <c>Pattern</c> to <c>ARBITRARY</c> and you must not
        /// set it for any other <c>Pattern</c> setting. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
        public List<string> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && (this._members.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// The criteria to use to choose the protected resources for inclusion in the group.
        /// You can include all resources that have protections, provide a list of resource Amazon
        /// Resource Names (ARNs), or include all resources of a specified resource type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtectionGroupPattern Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectionGroupId. 
        /// <para>
        /// The name of the protection group. You use this to identify the protection group in
        /// lists and to manage the protection group, for example to update, delete, or describe
        /// it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=36)]
        public string ProtectionGroupId
        {
            get { return this._protectionGroupId; }
            set { this._protectionGroupId = value; }
        }

        // Check to see if ProtectionGroupId property is set
        internal bool IsSetProtectionGroupId()
        {
            return this._protectionGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type to include in the protection group. All protected resources of this
        /// type are included in the protection group. You must set this when you set <c>Pattern</c>
        /// to <c>BY_RESOURCE_TYPE</c> and you must not set it for any other <c>Pattern</c> setting.
        /// 
        /// </para>
        /// </summary>
        public ProtectedResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}