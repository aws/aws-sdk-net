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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Describes a client certificate identity filter.
    /// </summary>
    public partial class ClientCertificateIdentityFilter
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action to take when the client certificate matches the filter. The only supported
        /// action is <c>accept</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientCertificateIdentityFilterAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The client certificate field to match. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>subject-cn</c> – The common name in the certificate subject.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>subject-ou</c> – The organizational unit in the certificate subject.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>san-dns</c> – A DNS name in the subject alternative name (SAN).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>san-uri</c> – A URI in the subject alternative name (SAN).
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the client certificate doesn't contain the field, the filter doesn't match. If
        /// the field has multiple values, the filter matches if it matches any one of the values.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientCertificateIdentityFilterField Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property MatchType. 
        /// <para>
        /// The match type. The possible values are <c>exact</c> and <c>prefix</c>.
        /// </para>
        ///  
        /// <para>
        /// For the <c>subject-cn</c>, <c>subject-ou</c>, and <c>san-dns</c> fields, matching
        /// is case-insensitive. For the <c>san-uri</c> field, the scheme and host are matched
        /// case-insensitively, and the rest of the URI is matched case-sensitively.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ClientCertificateIdentityFilterMatchType MatchType { get; set; }

        /// <summary>
        /// Checks to see if the MatchType property is set.
        /// </summary>
        internal bool IsSetMatchType() => this.MatchType != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value to match. The value must be 1–256 printable ASCII characters.
        /// </para>
        ///  
        /// <para>
        /// If the field is <c>san-uri</c>, the value must begin with a letter. Before the first
        /// colon, the value can contain only letters, digits, plus signs (+), hyphens (-), or
        /// periods (.). If the match type is <c>exact</c>, the value must contain a colon. For
        /// example, <c>spiffe://example.com/workload</c> is a valid value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
