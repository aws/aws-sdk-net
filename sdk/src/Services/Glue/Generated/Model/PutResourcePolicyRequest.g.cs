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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the PutResourcePolicy operation. Sets the Data Catalog
    /// resource policy for access control.
    /// </summary>
    public partial class PutResourcePolicyRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property EnableHybrid. 
        /// <para>
        /// If <c>'TRUE'</c>, indicates that you are using both methods to grant cross-account
        /// access to Data Catalog resources:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// By directly updating the resource policy with <c>PutResourePolicy</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// By using the <b>Grant permissions</b> command on the Amazon Web Services Management
        /// Console.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Must be set to <c>'TRUE'</c> if you have already used the Management Console to grant
        /// cross-account access, otherwise the call fails. Default is 'FALSE'.
        /// </para>
        /// </summary>
        public EnableHybridValues EnableHybrid { get; set; }

        /// <summary>
        /// Checks to see if the EnableHybrid property is set.
        /// </summary>
        internal bool IsSetEnableHybrid() => this.EnableHybrid != null;

        /// <summary>
        /// Gets and sets the property PolicyExistsCondition. 
        /// <para>
        /// A value of <c>MUST_EXIST</c> is used to update a policy. A value of <c>NOT_EXIST</c>
        /// is used to create a new policy. If a value of <c>NONE</c> or a null value is used,
        /// the call does not depend on the existence of a policy.
        /// </para>
        /// </summary>
        public ExistCondition PolicyExistsCondition { get; set; }

        /// <summary>
        /// Checks to see if the PolicyExistsCondition property is set.
        /// </summary>
        internal bool IsSetPolicyExistsCondition() => this.PolicyExistsCondition != null;

        /// <summary>
        /// Gets and sets the property PolicyHashCondition. 
        /// <para>
        /// The hash value returned when the previous policy was set using <c>PutResourcePolicy</c>.
        /// Its purpose is to prevent concurrent modifications of a policy. Do not use this parameter
        /// if no previous policy has been set.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string PolicyHashCondition { get; set; }

        /// <summary>
        /// Checks to see if the PolicyHashCondition property is set.
        /// </summary>
        internal bool IsSetPolicyHashCondition() => this.PolicyHashCondition != null;

        /// <summary>
        /// Gets and sets the property PolicyInJson. 
        /// <para>
        /// Contains the policy document to set, in JSON format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2)]
        public string PolicyInJson { get; set; }

        /// <summary>
        /// Checks to see if the PolicyInJson property is set.
        /// </summary>
        internal bool IsSetPolicyInJson() => this.PolicyInJson != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Do not use. For internal use only.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10240)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
