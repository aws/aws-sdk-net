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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Error information for an OpenSearch Serverless request.
    /// </summary>
    public partial class EffectiveLifecyclePolicyDetail
    {
        /// <summary>
        /// Gets and sets the property NoMinRetentionPeriod. 
        /// <para>
        /// The minimum number of index retention days set. That is an optional param that will
        /// return as <c>true</c> if the minimum number of days or hours is not set to a index
        /// resource.
        /// </para>
        /// </summary>
        public bool? NoMinRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the NoMinRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetNoMinRetentionPeriod() => this.NoMinRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 32)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The name of the OpenSearch Serverless index resource.
        /// </para>
        /// </summary>
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of OpenSearch Serverless resource. Currently, the only supported resource
        /// is <c>index</c>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The minimum number of index retention in days or hours. This is an optional parameter
        /// that will return only if it’s set.
        /// </para>
        /// </summary>
        public string RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of lifecycle policy.
        /// </para>
        /// </summary>
        public LifecyclePolicyType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
