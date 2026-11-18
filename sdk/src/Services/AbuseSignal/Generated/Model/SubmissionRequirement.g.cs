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

namespace Amazon.AbuseSignal.Model
{
    /// <summary>
    /// Describes one specific submission requirement that a well-formed report did not meet.
    /// The service returns this structure in the <c>unmetRequirements</c> list of a <c>SubmissionRequirementException</c>
    /// (HTTP 422).
    /// </summary>
    public partial class SubmissionRequirement
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// A stable, dot-namespaced identifier for the submission requirement that the report
        /// did not meet (for example, <c>rule.timestamp.too_old</c>). The set of codes is append-only,
        /// so treat an unrecognized value as opaque. This value is absent when the requirement
        /// that the report did not meet does not publish an identifier.
        /// </para>
        ///  
        /// <para>
        /// The service checks the following submission requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>rule.source_identifier.too_long</c> (<c>source_identifier</c>) – The value exceeds
        /// the maximum accepted length of 253 characters (the DNS hostname limit).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.source_identifier.forbidden_characters</c> (<c>source_identifier</c>) – The
        /// value contains characters that are never valid in an address (<c>{</c>, <c>}</c>,
        /// <c>*</c>, or <c>`</c>). These are common template-injection and command-injection
        /// markers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.source_identifier.malformed</c> (<c>source_identifier</c>) – The value is
        /// not a valid IPv4 address, IPv6 address, URL, or domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.timestamp.unparseable</c> (<c>timestamp</c>) – The value could not be parsed
        /// as an RFC 3339 date-time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.timestamp.in_future</c> (<c>timestamp</c>) – The value is dated further into
        /// the future than the accepted clock-skew tolerance (a default of 1 hour).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.timestamp.too_old</c> (<c>timestamp</c>) – The value predates the submission
        /// lookback window (a default of 90 days). For content that is still accessible, set
        /// <c>timestamp</c> to the time you most recently observed it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>rule.evidence.content_type_mismatch</c> (<c>evidence</c>) – The decoded payload
        /// of an evidence item does not match its declared <c>content_type</c>. The <c>path</c>
        /// identifies the item, for example <c>/evidence/0</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Submission requirement thresholds are configuration-driven and can change over time.
        /// The set of codes is append-only, so treat an unrecognized code as opaque.
        /// </para>
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A detailed, human-readable description of the unmet submission requirement.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A JSON Pointer expression to the report member that did not meet the requirement.
        /// An empty string refers to the report as a whole.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;
    }
}
