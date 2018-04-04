/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Details of the resource that is not protected by the policy.
    /// </summary>
    public partial class ComplianceViolator
    {
        private string _resourceId;
        private string _resourceType;
        private ViolationReason _violationReason;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource ID.
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type. This is in the format shown in <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">AWS
        /// Resource Types Reference</a>. Valid values are <code>AWS::ElasticLoadBalancingV2::LoadBalancer</code>
        /// or <code>AWS::CloudFront::Distribution</code>.
        /// </para>
        /// </summary>
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property ViolationReason. 
        /// <para>
        /// The reason that the resource is not protected by the policy.
        /// </para>
        /// </summary>
        public ViolationReason ViolationReason
        {
            get { return this._violationReason; }
            set { this._violationReason = value; }
        }

        // Check to see if ViolationReason property is set
        internal bool IsSetViolationReason()
        {
            return this._violationReason != null;
        }

    }
}