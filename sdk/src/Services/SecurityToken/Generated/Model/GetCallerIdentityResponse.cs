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
    /// Contains the response to a successful <a>GetCallerIdentity</a> request, including
    /// information about the entity making the request.
    /// </summary>
    public partial class GetCallerIdentityResponse : AmazonWebServiceResponse
    {
        private string _account;
        private string _arn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The Amazon Web Services account ID number of the account that owns or contains the
        /// calling entity.
        /// </para>
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Web Services ARN associated with the calling entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The unique identifier of the calling entity. The exact value depends on the type of
        /// entity that is making the call. The values returned are those listed in the <b>aws:userid</b>
        /// column in the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_variables.html#principaltable">Principal
        /// table</a> found on the <b>Policy Variables</b> reference page in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}