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
    /// Contains information about a filter to refine policies returned in a query.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response parameter for the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicies.html">ListPolicies</a>
    /// operation.
    /// </para>
    /// </summary>
    public partial class PolicyFilter
    {
        /// <summary>
        /// Gets and sets the property PolicyTemplateId. 
        /// <para>
        /// Filters the output to only template-linked policies that were instantiated from the
        /// specified policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string PolicyTemplateId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyTemplateId property is set.
        /// </summary>
        internal bool IsSetPolicyTemplateId() => this.PolicyTemplateId != null;

        /// <summary>
        /// Gets and sets the property PolicyType. 
        /// <para>
        /// Filters the output to only policies of the specified type.
        /// </para>
        /// </summary>
        public PolicyType PolicyType { get; set; }

        /// <summary>
        /// Checks to see if the PolicyType property is set.
        /// </summary>
        internal bool IsSetPolicyType() => this.PolicyType != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// Filters the output to only policies that reference the specified principal.
        /// </para>
        /// </summary>
        public EntityReference Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// Filters the output to only policies that reference the specified resource.
        /// </para>
        /// </summary>
        public EntityReference Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
