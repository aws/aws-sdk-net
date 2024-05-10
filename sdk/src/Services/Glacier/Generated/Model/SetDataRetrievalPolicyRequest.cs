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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Container for the parameters to the SetDataRetrievalPolicy operation.
    /// This operation sets and then enacts a data retrieval policy in the region specified
    /// in the PUT request. You can set one policy per region for an AWS account. The policy
    /// is enacted within a few minutes of a successful PUT operation.
    /// 
    ///  
    /// <para>
    /// The set policy operation does not affect retrieval jobs that were in progress before
    /// the policy was enacted. For more information about data retrieval policies, see <a
    /// href="https://docs.aws.amazon.com/amazonglacier/latest/dev/data-retrieval-policy.html">Amazon
    /// Glacier Data Retrieval Policies</a>. 
    /// </para>
    /// </summary>
    public partial class SetDataRetrievalPolicyRequest : AmazonGlacierRequest
    {
        private string _accountId;
        private DataRetrievalPolicy _policy;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The <c>AccountId</c> value is the AWS account ID. This value must match the AWS account
        /// ID associated with the credentials used to sign the request. You can either specify
        /// an AWS account ID or optionally a single '<c>-</c>' (hyphen), in which case Amazon
        /// Glacier uses the AWS account ID associated with the credentials used to sign the request.
        /// If you specify your account ID, do not include any hyphens ('-') in the ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The data retrieval policy in JSON format.
        /// </para>
        /// </summary>
        public DataRetrievalPolicy Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

    }
}