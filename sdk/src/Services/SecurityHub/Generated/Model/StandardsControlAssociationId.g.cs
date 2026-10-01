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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// An array with one or more objects that includes a security control (identified with
    /// <c>SecurityControlId</c>, <c>SecurityControlArn</c>, or a mix of both parameters)
    /// and the Amazon Resource Name (ARN) of a standard. The security control ID or ARN is
    /// the same across standards.
    /// </summary>
    public partial class StandardsControlAssociationId
    {
        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier (identified with <c>SecurityControlId</c>, <c>SecurityControlArn</c>,
        /// or a mix of both parameters) of a security control across standards. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecurityControlId { get; set; }

        /// <summary>
        /// Checks to see if the SecurityControlId property is set.
        /// </summary>
        internal bool IsSetSecurityControlId() => this.SecurityControlId != null;

        /// <summary>
        /// Gets and sets the property StandardsArn. 
        /// <para>
        ///  The ARN of a standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StandardsArn { get; set; }

        /// <summary>
        /// Checks to see if the StandardsArn property is set.
        /// </summary>
        internal bool IsSetStandardsArn() => this.StandardsArn != null;
    }
}
