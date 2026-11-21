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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A principal that a <c>BatchDeletePolicyAssignmentByPolicy</c> request couldn't remove
    /// the policy from.
    /// </summary>
    public partial class BatchDeletePolicyAssignmentError
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The reason the entry failed. Possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ValidationException</c> – The entry is not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceNotFoundException</c> – The principal doesn't exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ConflictException</c> – The principal has a different policy of the same type,
        /// or the assignment changed while this request was being processed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ThrottlingException</c> – The entry was throttled. You can retry this entry.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InternalFailureException</c> – An internal error occurred.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A description of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The ARN of the principal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;
    }
}
