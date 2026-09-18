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
    /// Information about the entity that created the session.
    /// </summary>
    public partial class AwsIamAccessKeySessionContextSessionIssuer
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The identifier of the Amazon Web Services account that created the session.
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
        /// The ARN of the session.
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
        /// The principal ID of the principal (user, role, or group) that created the session.
        /// </para>
        /// </summary>
        public string PrincipalId { get; set; }

        /// <summary>
        /// Checks to see if the PrincipalId property is set.
        /// </summary>
        internal bool IsSetPrincipalId() => this.PrincipalId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of principal (user, role, or group) that created the session.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the principal that created the session.
        /// </para>
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;
    }
}
