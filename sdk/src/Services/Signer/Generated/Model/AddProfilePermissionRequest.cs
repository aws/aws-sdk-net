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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the AddProfilePermission operation.
    /// Adds cross-account permissions to a signing profile.
    /// </summary>
    public partial class AddProfilePermissionRequest : AmazonSignerRequest
    {
        private string _action;
        private string _principal;
        private string _profileName;
        private string _profileVersion;
        private string _revisionId;
        private string _statementId;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// For cross-account signing. Grant a designated account permission to perform one or
        /// more of the following actions. Each action is associated with a specific API's operations.
        /// For more information about cross-account signing, see <a href="https://docs.aws.amazon.com/signer/latest/developerguide/signing-profile-cross-account.html">Using
        /// cross-account signing with signing profiles</a> in the <i>AWS Signer Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can designate the following actions to an account.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>signer:StartSigningJob</c>. This action isn't supported for container image workflows.
        /// For details, see <a>StartSigningJob</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>signer:SignPayload</c>. This action isn't supported for AWS Lambda workflows.
        /// For details, see <a>SignPayload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>signer:GetSigningProfile</c>. For details, see <a>GetSigningProfile</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>signer:RevokeSignature</c>. For details, see <a>RevokeSignature</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Principal. 
        /// <para>
        /// The AWS principal receiving cross-account permissions. This may be an IAM role or
        /// another AWS account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Principal
        {
            get { return this._principal; }
            set { this._principal = value; }
        }

        // Check to see if Principal property is set
        internal bool IsSetPrincipal()
        {
            return this._principal != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The human-readable name of the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version of the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string ProfileVersion
        {
            get { return this._profileVersion; }
            set { this._profileVersion = value; }
        }

        // Check to see if ProfileVersion property is set
        internal bool IsSetProfileVersion()
        {
            return this._profileVersion != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// A unique identifier for the current profile revision.
        /// </para>
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property StatementId. 
        /// <para>
        /// A unique identifier for the cross-account permission statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string StatementId
        {
            get { return this._statementId; }
            set { this._statementId = value; }
        }

        // Check to see if StatementId property is set
        internal bool IsSetStatementId()
        {
            return this._statementId != null;
        }

    }
}