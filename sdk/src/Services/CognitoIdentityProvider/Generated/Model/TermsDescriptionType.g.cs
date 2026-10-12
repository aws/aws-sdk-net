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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The details of a set of terms documents. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-managed-login.html#managed-login-terms-documents">Terms
    /// documents</a>.
    /// </summary>
    public partial class TermsDescriptionType
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Enforcement. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TermsEnforcementType Enforcement { get; set; }

        /// <summary>
        /// Checks to see if the Enforcement property is set.
        /// </summary>
        internal bool IsSetEnforcement() => this.Enforcement != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property TermsId. 
        /// <para>
        /// The ID of the requested terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TermsId { get; set; }

        /// <summary>
        /// Checks to see if the TermsId property is set.
        /// </summary>
        internal bool IsSetTermsId() => this.TermsId != null;

        /// <summary>
        /// Gets and sets the property TermsName. 
        /// <para>
        /// The type and friendly name of the requested terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TermsName { get; set; }

        /// <summary>
        /// Checks to see if the TermsName property is set.
        /// </summary>
        internal bool IsSetTermsName() => this.TermsName != null;
    }
}
