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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Contains information about a policy returned from a <c>BatchGetPolicy</c> API request.
    /// </summary>
    public partial class BatchGetPolicyOutputItem
    {
        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time the policy was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Definition. 
        /// <para>
        /// The policy definition of an item in the list of policies returned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyDefinitionDetail Definition { get; set; }

        /// <summary>
        /// Checks to see if the Definition property is set.
        /// </summary>
        internal bool IsSetDefinition() => this.Definition != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedDate. 
        /// <para>
        /// The date and time the policy was most recently updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdatedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDate property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDate() => this.LastUpdatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the policy, if one was assigned when the policy was created or last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 150)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The identifier of the policy you want information about.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The identifier of the policy store where the policy you want information about is
        /// stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// The type of the policy. This is one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STATIC</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TEMPLATE_LINKED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;
    }
}
