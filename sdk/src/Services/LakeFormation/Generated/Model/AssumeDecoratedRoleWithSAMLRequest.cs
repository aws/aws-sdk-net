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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
    /// Container for the parameters to the AssumeDecoratedRoleWithSAML operation.
    /// Allows a caller to assume an IAM role decorated as the SAML user specified in the
    /// SAML assertion included in the request. This decoration allows Lake Formation to enforce
    /// access policies against the SAML users and groups. This API operation requires SAML
    /// federation setup in the caller’s account as it can only be called with valid SAML
    /// assertions. Lake Formation does not scope down the permission of the assumed role.
    /// All permissions attached to the role via the SAML federation setup will be included
    /// in the role session. 
    /// 
    ///  
    /// <para>
    ///  This decorated role is expected to access data in Amazon S3 by getting temporary
    /// access from Lake Formation which is authorized via the virtual API <c>GetDataAccess</c>.
    /// Therefore, all SAML roles that can be assumed via <c>AssumeDecoratedRoleWithSAML</c>
    /// must at a minimum include <c>lakeformation:GetDataAccess</c> in their role policies.
    /// A typical IAM policy attached to such a role would look as follows: 
    /// </para>
    /// </summary>
    public partial class AssumeDecoratedRoleWithSAMLRequest : AmazonLakeFormationRequest
    {
        private int? _durationSeconds;
        private string _principalArn;
        private string _roleArn;
        private string _samlAssertion;

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The time period, between 900 and 43,200 seconds, for the timeout of the temporary
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrincipalArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider in IAM that describes the IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrincipalArn
        {
            get { return this._principalArn; }
            set { this._principalArn = value; }
        }

        // Check to see if PrincipalArn property is set
        internal bool IsSetPrincipalArn()
        {
            return this._principalArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The role that represents an IAM principal whose scope down policy allows it to call
        /// credential vending APIs such as <c>GetTemporaryTableCredentials</c>. The caller must
        /// also have iam:PassRole permission on this role. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SAMLAssertion. 
        /// <para>
        /// A SAML assertion consisting of an assertion statement for the user who needs temporary
        /// credentials. This must match the SAML assertion that was issued to IAM. This must
        /// be Base64 encoded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=100000)]
        public string SAMLAssertion
        {
            get { return this._samlAssertion; }
            set { this._samlAssertion = value; }
        }

        // Check to see if SAMLAssertion property is set
        internal bool IsSetSAMLAssertion()
        {
            return this._samlAssertion != null;
        }

    }
}