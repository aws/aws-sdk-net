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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// This is the response object from the GetDataAccess operation.
    /// </summary>
    public partial class GetDataAccessResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The temporary credential token that S3 Access Grants vends.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property Grantee. 
        /// <para>
        /// The user, group, or role that was granted access to the S3 location scope. For directory
        /// identities, this API also returns the grants of the IAM role used for the identity-aware
        /// request. For more information on identity-aware sessions, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_control-access_sts-setcontext.html">Granting
        /// permissions to use identity-aware console sessions</a>. 
        /// </para>
        /// </summary>
        public Grantee Grantee { get; set; }

        /// <summary>
        /// Checks to see if the Grantee property is set.
        /// </summary>
        internal bool IsSetGrantee() => this.Grantee != null;

        /// <summary>
        /// Gets and sets the property MatchedGrantTarget. 
        /// <para>
        /// The S3 URI path of the data to which you are being granted temporary access credentials.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string MatchedGrantTarget { get; set; }

        /// <summary>
        /// Checks to see if the MatchedGrantTarget property is set.
        /// </summary>
        internal bool IsSetMatchedGrantTarget() => this.MatchedGrantTarget != null;
    }
}
