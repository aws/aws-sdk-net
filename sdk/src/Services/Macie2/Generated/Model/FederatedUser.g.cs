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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about an identity that performed an action on an affected resource
    /// by using temporary security credentials. The credentials were obtained using the GetFederationToken
    /// operation of the Security Token Service (STS) API.
    /// </summary>
    public partial class FederatedUser
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The Amazon Web Services access key ID that identifies the credentials.
        /// </para>
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account that owns the entity that
        /// was used to get the credentials.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity that was used to get the credentials.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property PrincipalId. 
        /// <para>
        /// The unique identifier for the entity that was used to get the credentials.
        /// </para>
        /// </summary>
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property SessionContext. 
        /// <para>
        /// The details of the session that was created for the credentials, including the entity
        /// that issued the session.
        /// </para>
        /// </summary>
        public SessionContext SessionContext { get; set; }

        /// <summary>
        /// Checks to see if the SessionContext property is set.
        /// </summary>
        internal bool IsSetSessionContext() => this.SessionContext != null;
    }
}
