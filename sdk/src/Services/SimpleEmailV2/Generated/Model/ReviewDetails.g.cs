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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about your account details review.
    /// </summary>
    public partial class ReviewDetails
    {
        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// The associated support center case ID (if any).
        /// </para>
        /// </summary>
        public string CaseId { get; set; }

        /// <summary>
        /// Checks to see if the CaseId property is set.
        /// </summary>
        internal bool IsSetCaseId() => this.CaseId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the latest review of your account. The status can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – We have received your appeal and are in the process of reviewing
        /// it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GRANTED</c> – Your appeal has been reviewed and your production access has been
        /// granted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c> – Your appeal has been reviewed and your production access has been
        /// denied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – An internal error occurred and we didn't receive your appeal. You
        /// can submit your appeal again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReviewStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
