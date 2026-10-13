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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the DetachRLSPolicy operation. Detaches a row-level
    /// security policy from a resource for a principal. After the policy is detached, its
    /// filter expression is no longer applied to the principal's queries on that resource.
    /// </summary>
    public partial class DetachRLSPolicyRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property Condition. 
        /// <para>
        /// A Lake Formation condition, which applies to the row-level security policy attachment
        /// and contains an expression.
        /// </para>
        /// </summary>
        public Condition Condition { get; set; }

        /// <summary>
        /// Checks to see if the Condition property is set.
        /// </summary>
        internal bool IsSetCondition() => this.Condition != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the row-level security policy to detach.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The principal for which the row-level security policy is detached.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property RemoveDefault. 
        /// <para>
        /// Indicates whether to remove this policy as the default row-level security policy for
        /// the resource.
        /// </para>
        /// </summary>
        public bool? RemoveDefault { get; set; }

        /// <summary>
        /// Checks to see if the RemoveDefault property is set.
        /// </summary>
        internal bool IsSetRemoveDefault() => this.RemoveDefault.HasValue;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource from which the row-level security policy is detached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;
    }
}
