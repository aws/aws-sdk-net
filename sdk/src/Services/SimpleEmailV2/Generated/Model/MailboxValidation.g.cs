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
    /// Contains detailed validation information about an email address.
    /// </summary>
    public partial class MailboxValidation
    {
        /// <summary>
        /// Gets and sets the property Evaluations. 
        /// <para>
        /// Specific validation checks performed on the email address.
        /// </para>
        /// </summary>
        public EmailAddressInsightsMailboxEvaluations Evaluations { get; set; }

        /// <summary>
        /// Checks to see if the Evaluations property is set.
        /// </summary>
        internal bool IsSetEvaluations() => this.Evaluations != null;

        /// <summary>
        /// Gets and sets the property IsValid. 
        /// <para>
        /// Overall validity assessment with a conﬁdence verdict.
        /// </para>
        /// </summary>
        public EmailAddressInsightsVerdict IsValid { get; set; }

        /// <summary>
        /// Checks to see if the IsValid property is set.
        /// </summary>
        internal bool IsSetIsValid() => this.IsValid != null;
    }
}
