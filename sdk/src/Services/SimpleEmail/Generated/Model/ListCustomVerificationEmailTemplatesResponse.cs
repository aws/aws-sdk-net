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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// A paginated list of custom verification email templates.
    /// </summary>
    public partial class ListCustomVerificationEmailTemplatesResponse : AmazonWebServiceResponse
    {
        private List<CustomVerificationEmailTemplate> _customVerificationEmailTemplates = new List<CustomVerificationEmailTemplate>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property CustomVerificationEmailTemplates. 
        /// <para>
        /// A list of the custom verification email templates that exist in your account.
        /// </para>
        /// </summary>
        public List<CustomVerificationEmailTemplate> CustomVerificationEmailTemplates
        {
            get { return this._customVerificationEmailTemplates; }
            set { this._customVerificationEmailTemplates = value; }
        }

        // Check to see if CustomVerificationEmailTemplates property is set
        internal bool IsSetCustomVerificationEmailTemplates()
        {
            return this._customVerificationEmailTemplates != null && this._customVerificationEmailTemplates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token indicating that there are additional custom verification email templates available
        /// to be listed. Pass this token to a subsequent call to <code>ListTemplates</code> to
        /// retrieve the next 50 custom verification email templates.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}