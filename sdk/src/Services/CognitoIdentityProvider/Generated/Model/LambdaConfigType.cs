/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Specifies the type of configuration for AWS Lambda triggers.
    /// </summary>
    public partial class LambdaConfigType
    {
        private string _customMessage;
        private string _postAuthentication;
        private string _postConfirmation;
        private string _preAuthentication;
        private string _preSignUp;

        /// <summary>
        /// Gets and sets the property CustomMessage. 
        /// <para>
        /// A custom Message AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string CustomMessage
        {
            get { return this._customMessage; }
            set { this._customMessage = value; }
        }

        // Check to see if CustomMessage property is set
        internal bool IsSetCustomMessage()
        {
            return this._customMessage != null;
        }

        /// <summary>
        /// Gets and sets the property PostAuthentication. 
        /// <para>
        /// A post-authentication AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PostAuthentication
        {
            get { return this._postAuthentication; }
            set { this._postAuthentication = value; }
        }

        // Check to see if PostAuthentication property is set
        internal bool IsSetPostAuthentication()
        {
            return this._postAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PostConfirmation. 
        /// <para>
        /// A post-confirmation AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PostConfirmation
        {
            get { return this._postConfirmation; }
            set { this._postConfirmation = value; }
        }

        // Check to see if PostConfirmation property is set
        internal bool IsSetPostConfirmation()
        {
            return this._postConfirmation != null;
        }

        /// <summary>
        /// Gets and sets the property PreAuthentication. 
        /// <para>
        /// A pre-authentication AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PreAuthentication
        {
            get { return this._preAuthentication; }
            set { this._preAuthentication = value; }
        }

        // Check to see if PreAuthentication property is set
        internal bool IsSetPreAuthentication()
        {
            return this._preAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property PreSignUp. 
        /// <para>
        /// A pre-registration AWS Lambda trigger.
        /// </para>
        /// </summary>
        public string PreSignUp
        {
            get { return this._preSignUp; }
            set { this._preSignUp = value; }
        }

        // Check to see if PreSignUp property is set
        internal bool IsSetPreSignUp()
        {
            return this._preSignUp != null;
        }

    }
}