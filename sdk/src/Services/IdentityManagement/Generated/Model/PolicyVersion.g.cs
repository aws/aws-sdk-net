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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains information about a version of a managed policy.
    /// 
    ///  
    /// <para>
    /// This data type is used as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicyVersion.html">CreatePolicyVersion</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>,
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountAuthorizationDetails.html">GetAccountAuthorizationDetails</a>
    /// operations. 
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, refer to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// policies and inline policies</a> in the <i>IAM User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class PolicyVersion
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time, in <a href="http://www.iso.org/iso/iso8601">ISO 8601 date-time
        /// format</a>, when the policy version was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Document. 
        /// <para>
        /// The policy document.
        /// </para>
        ///  
        /// <para>
        /// The policy document is returned in the response to the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetPolicyVersion.html">GetPolicyVersion</a>
        /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetAccountAuthorizationDetails.html">GetAccountAuthorizationDetails</a>
        /// operations. It is not returned in the response to the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreatePolicyVersion.html">CreatePolicyVersion</a>
        /// or <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListPolicyVersions.html">ListPolicyVersions</a>
        /// operations. 
        /// </para>
        ///  
        /// <para>
        /// The policy document returned in this structure is URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
        /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
        /// text. For example, if you use Java, you can use the <c>decode</c> method of the <c>java.net.URLDecoder</c>
        /// utility class in the Java SDK. Other languages and SDKs provide similar functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 131072)]
        public string Document { get; set; }

        /// <summary>
        /// Checks to see if the Document property is set.
        /// </summary>
        internal bool IsSetDocument() => this.Document != null;

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Specifies whether the policy version is set as the policy's default version.
        /// </para>
        /// </summary>
        public bool? IsDefaultVersion { get; set; }

        /// <summary>
        /// Checks to see if the IsDefaultVersion property is set.
        /// </summary>
        internal bool IsSetIsDefaultVersion() => this.IsDefaultVersion.HasValue;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The identifier for the policy version.
        /// </para>
        ///  
        /// <para>
        /// Policy version identifiers always begin with <c>v</c> (always lowercase). When a policy
        /// is created, the first policy version is <c>v1</c>. 
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
