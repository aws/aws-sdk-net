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

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// The <c>ResourceDriftIgnoredAttribute</c> data type.
    /// </summary>
    public partial class ResourceDriftIgnoredAttribute
    {
        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Path of the resource attribute for which drift was ignored.
        /// </para>
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Reason why drift was ignored for the attribute, can have 3 possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>WRITE_ONLY_PROPERTY</c> – Property is not included in read response for the resource’s
        /// live state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MANAGED_BY_AWS</c> – Property is managed by an Amazon Web Services service and
        /// is expected to be dynamically modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SENSITIVE_PROPERTY</c> – Property has a sensitive value, such as an Amazon Web
        /// Services Secrets Manager value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DriftIgnoredReason Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
