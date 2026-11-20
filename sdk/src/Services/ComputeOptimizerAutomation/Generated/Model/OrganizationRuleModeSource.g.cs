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

namespace Amazon.ComputeOptimizerAutomation.Model
{
    /// <summary>
    /// Information about the source of an effective organization rule mode.
    /// </summary>
    public partial class OrganizationRuleModeSource
    {
        /// <summary>
        /// Gets and sets the property SourceTargetId. 
        /// <para>
        /// The ID of the account, organizational unit (OU), or organization root that has the
        /// organization enrollment configuration. This field is omitted when <c>sourceType</c>
        /// is <c>Direct</c> or <c>Default</c>.
        /// </para>
        /// </summary>
        public string SourceTargetId { get; set; }

        /// <summary>
        /// Checks to see if the SourceTargetId property is set.
        /// </summary>
        internal bool IsSetSourceTargetId() => this.SourceTargetId != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// How the effective organization rule mode is supplied.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Applied</c> - An organization enrollment configuration is on this organizational
        /// unit or account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Inherited</c> - The organization enrollment configuration is on the parent organizational
        /// unit or root.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Direct</c> - The organization rule mode is set on the account itself, with no
        /// organization enrollment configuration applied.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Default</c> - No organization enrollment configuration applies, so the organization
        /// rule mode is None allowed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationRuleModeSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;
    }
}
