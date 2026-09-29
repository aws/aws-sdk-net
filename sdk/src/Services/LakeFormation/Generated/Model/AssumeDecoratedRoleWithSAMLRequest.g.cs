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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the AssumeDecoratedRoleWithSAML operation. Allows
    /// a caller to assume an IAM role decorated as the SAML user specified in the SAML assertion
    /// included in the request. This decoration allows Lake Formation to enforce access policies
    /// against the SAML users and groups. This API operation requires SAML federation setup
    /// in the caller’s account as it can only be called with valid SAML assertions. Lake
    /// Formation does not scope down the permission of the assumed role. All permissions
    /// attached to the role via the SAML federation setup will be included in the role session.
    /// <para> This decorated role is expected to access data in Amazon S3 by getting temporary
    /// access from Lake Formation which is authorized via the virtual API <c>GetDataAccess</c>.
    /// Therefore, all SAML roles that can be assumed via <c>AssumeDecoratedRoleWithSAML</c>
    /// must at a minimum include <c>lakeformation:GetDataAccess</c> in their role policies.
    /// A typical IAM policy attached to such a role would include the following actions:
    /// </para> <ul> <li> <para> glue:*Database* </para> </li> <li> <para> glue:*Table* </para>
    /// </li> <li> <para> glue:*Partition* </para> </li> <li> <para> glue:*UserDefinedFunction*
    /// </para> </li> <li> <para> lakeformation:GetDataAccess </para> </li> </ul>
    /// </summary>
    public partial class AssumeDecoratedRoleWithSAMLRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The time period, between 900 and 43,200 seconds, for the timeout of the temporary
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 900, Max = 43200)]
        public int? DurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the DurationSeconds property is set.
        /// </summary>
        internal bool IsSetDurationSeconds() => this.DurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider in IAM that describes the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PrincipalArn { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalArn property is set.
        /// </summary>
        internal bool IsSetPrincipalArn() => this.PrincipalArn != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role that represents an IAM principal whose scope down policy allows it to call
        /// credential vending APIs such as <c>GetTemporaryTableCredentials</c>. The caller must
        /// also have iam:PassRole permission on this role. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SAMLAssertion. 
        /// <para>
        /// A SAML assertion consisting of an assertion statement for the user who needs temporary
        /// credentials. This must match the SAML assertion that was issued to IAM. This must
        /// be Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 100000)]
        public string SAMLAssertion { get; set; }

        /// <summary>
        /// Checks to see if the SAMLAssertion property is set.
        /// </summary>
        internal bool IsSetSAMLAssertion() => this.SAMLAssertion != null;
    }
}
