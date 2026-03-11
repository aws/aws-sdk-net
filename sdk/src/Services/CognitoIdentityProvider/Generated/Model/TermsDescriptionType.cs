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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
        private DateTime? _creationDate;
        private TermsEnforcementType _enforcement;
        private DateTime? _lastModifiedDate;
        private string _termsId;
        private string _termsName;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the item was created. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Enforcement. 
        /// <para>
        /// This parameter is reserved for future use and currently accepts one value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TermsEnforcementType Enforcement
        {
            get { return this._enforcement; }
            set { this._enforcement = value; }
        }

        // Check to see if Enforcement property is set
        internal bool IsSetEnforcement()
        {
            return this._enforcement != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the item was modified. Amazon Cognito returns this timestamp
        /// in UNIX epoch time format. Your SDK might render the output in a human-readable format
        /// like ISO 8601 or a Java <c>Date</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TermsId. 
        /// <para>
        /// The ID of the requested terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TermsId
        {
            get { return this._termsId; }
            set { this._termsId = value; }
        }

        // Check to see if TermsId property is set
        internal bool IsSetTermsId()
        {
            return this._termsId != null;
        }

        /// <summary>
        /// Gets and sets the property TermsName. 
        /// <para>
        /// The type and friendly name of the requested terms documents.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TermsName
        {
            get { return this._termsName; }
            set { this._termsName = value; }
        }

        // Check to see if TermsName property is set
        internal bool IsSetTermsName()
        {
            return this._termsName != null;
        }

    }
}