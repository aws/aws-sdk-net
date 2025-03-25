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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the GetDataAccess operation.
    /// </summary>
    public partial class GetDataAccessResponse : AmazonWebServiceResponse
    {
        private Credentials _credentials;
        private Grantee _grantee;
        private string _matchedGrantTarget;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary credential token that S3 Access Grants vends.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The user, group, or role that was granted access to the S3 location scope. For directory
        /// identities, this API also returns the grants of the IAM role used for the identity-aware
        /// request. For more information on identity-aware sessions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_sts-setcontext.html">Granting
        /// permissions to use identity-aware console sessions</a>. 
        /// </para>
        /// </summary>
        public Grantee Grantee
        {
            get { return this._grantee; }
            set { this._grantee = value; }
        }

        // Check to see if Grantee property is set
        internal bool IsSetGrantee()
        {
            return this._grantee != null;
        }

        /// <summary>
        /// Gets and sets the property MatchedGrantTarget. 
        /// <para>
        /// The S3 URI path of the data to which you are being granted temporary access credentials.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string MatchedGrantTarget
        {
            get { return this._matchedGrantTarget; }
            set { this._matchedGrantTarget = value; }
        }

        // Check to see if MatchedGrantTarget property is set
        internal bool IsSetMatchedGrantTarget()
        {
            return this._matchedGrantTarget != null;
        }

    }
}