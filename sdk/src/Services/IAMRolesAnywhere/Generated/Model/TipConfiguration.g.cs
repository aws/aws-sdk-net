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

namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The trusted identity propagation (TIP) settings of a profile. When you enable TIP,
    /// sessions from the profile include the identity from the certificate in <c>aws:OriginIdentity</c>
    /// condition keys, which callers can't set.
    /// </summary>
    public partial class TipConfiguration
    {
        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies whether you use trusted identity propagation (TIP) for the profile. This
        /// field supports the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Sessions from the profile include the <c>aws:OriginIdentity</c>
        /// condition keys.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Sessions from the profile don't include these keys.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public TipStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubjectSource. 
        /// <para>
        /// The certificate field whose value becomes the subject, <c>aws:OriginIdentity/Subject</c>.
        /// This field supports the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x509Subject/CN</c> (default) – The common name (CN) in the certificate's Subject.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x509SAN/URI</c> – The first URI in the certificate's Subject Alternative Name
        /// (SAN) extension.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The profile's attribute mappings must include a rule for this field, and the default
        /// attribute mappings include one for each value. If the certificate has no value for
        /// the field, <c>CreateSession</c> denies the request.
        /// </para>
        /// </summary>
        public TipSubjectSource SubjectSource { get; set; }

        /// <summary>
        /// Checks to see if the SubjectSource property is set.
        /// </summary>
        internal bool IsSetSubjectSource() => this.SubjectSource != null;

        /// <summary>
        /// Gets and sets the property SubjectType. 
        /// <para>
        /// Specifies whether the certificates for the profile identify workloads or people. This
        /// field supports the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>workload</c> – The certificates identify workloads.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>user</c> – The certificates identify people.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Sessions include the value in <c>aws:OriginIdentity/SubjectType</c>. If you omit this
        /// field, sessions don't include that key.
        /// </para>
        /// </summary>
        public TipSubjectType SubjectType { get; set; }

        /// <summary>
        /// Checks to see if the SubjectType property is set.
        /// </summary>
        internal bool IsSetSubjectType() => this.SubjectType != null;
    }
}
