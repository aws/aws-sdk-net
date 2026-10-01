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
    /// A version of an IAM policy.
    /// </summary>
    public partial class AwsIamPolicyVersion
    {
        /// <summary>
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// Indicates when the version was created.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate != null;

        /// <summary>
        /// Gets and sets the property IsDefaultVersion. 
        /// <para>
        /// Whether the version is the default version.
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
        /// The identifier of the policy version.
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
