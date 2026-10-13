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
    /// Container for the parameters to the AttachRLSPolicy operation. Attaches a row-level
    /// security policy to a resource for a principal. When the principal queries the resource,
    /// Lake Formation applies the policy's filter expression so that only the permitted rows
    /// are returned.
    /// </summary>
    public partial class AttachRLSPolicyRequest : AmazonLakeFormationRequest
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
        /// The name of the row-level security policy to attach.
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
        /// The principal to which the row-level security policy applies.
        /// </para>
        /// </summary>
        public DataLakePrincipal Principal { get; set; }

        /// <summary>
        /// Checks to see if the Principal property is set.
        /// </summary>
        internal bool IsSetPrincipal() => this.Principal != null;

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The resource to which the row-level security policy is attached.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property SetDefault. 
        /// <para>
        /// Indicates whether this policy becomes the default row-level security policy for the
        /// resource. The default policy applies to all principals by default.
        /// </para>
        /// </summary>
        public bool? SetDefault { get; set; }

        /// <summary>
        /// Checks to see if the SetDefault property is set.
        /// </summary>
        internal bool IsSetSetDefault() => this.SetDefault.HasValue;
    }
}
