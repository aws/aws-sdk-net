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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Contains the response to a successful <a>AssumeRole</a> request, including temporary
    /// Amazon Web Services credentials that can be used to make Amazon Web Services requests.
    /// </summary>
    public partial class AssumeRoleResponse : AmazonWebServiceResponse
    {
        private AssumedRoleUser _assumedRoleUser;
        private Credentials _credentials;
        private int? _packedPolicySize;
        private string _sourceIdentity;

        /// <summary>
        /// Gets and sets the property AssumedRoleUser. 
        /// <para>
        /// The Amazon Resource Name (ARN) and the assumed role ID, which are identifiers that
        /// you can use to refer to the resulting temporary security credentials. For example,
        /// you can reference these credentials as a principal in a resource-based policy by using
        /// the ARN or assumed role ID. The ARN and ID include the <c>RoleSessionName</c> that
        /// you specified when you called <c>AssumeRole</c>. 
        /// </para>
        /// </summary>
        public AssumedRoleUser AssumedRoleUser
        {
            get { return this._assumedRoleUser; }
            set { this._assumedRoleUser = value; }
        }

        // Check to see if AssumedRoleUser property is set
        internal bool IsSetAssumedRoleUser()
        {
            return this._assumedRoleUser != null;
        }

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary security credentials, which include an access key ID, a secret access
        /// key, and a security (or session) token.
        /// </para>
        ///  <note> 
        /// <para>
        /// The size of the security token that STS API operations return is not fixed. We strongly
        /// recommend that you make no assumptions about the maximum size.
        /// </para>
        ///  </note>
        /// </summary>
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property PackedPolicySize. 
        /// <para>
        /// A percentage value that indicates the packed size of the session policies and session
        /// tags combined passed in the request. The request fails if the packed size is greater
        /// than 100 percent, which means the policies and tags exceeded the allowed space.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? PackedPolicySize
        {
            get { return this._packedPolicySize; }
            set { this._packedPolicySize = value; }
        }

        // Check to see if PackedPolicySize property is set
        internal bool IsSetPackedPolicySize()
        {
            return this._packedPolicySize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceIdentity. 
        /// <para>
        /// The source identity specified by the principal that is calling the <c>AssumeRole</c>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// You can require users to specify a source identity when they assume a role. You do
        /// this by using the <c>sts:SourceIdentity</c> condition key in a role trust policy.
        /// You can use source identity information in CloudTrail logs to determine who took actions
        /// with a role. You can use the <c>aws:SourceIdentity</c> condition key to further control
        /// access to Amazon Web Services resources based on the value of source identity. For
        /// more information about using source identity, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_monitor.html">Monitor
        /// and control actions taken with assumed roles</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The regex used to validate this parameter is a string of characters consisting of
        /// upper- and lower-case alphanumeric characters with no spaces. You can also include
        /// underscores or any of the following characters: =,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string SourceIdentity
        {
            get { return this._sourceIdentity; }
            set { this._sourceIdentity = value; }
        }

        // Check to see if SourceIdentity property is set
        internal bool IsSetSourceIdentity()
        {
            return this._sourceIdentity != null;
        }

    }
}