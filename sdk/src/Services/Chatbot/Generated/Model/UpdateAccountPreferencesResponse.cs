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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
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
namespace Amazon.Chatbot.Model
{
    /// <summary>
    /// This is the response object from the UpdateAccountPreferences operation.
    /// </summary>
    public partial class UpdateAccountPreferencesResponse : AmazonWebServiceResponse
    {
        private AccountPreferences _accountPreferences;

        /// <summary>
        /// Gets and sets the property AccountPreferences. 
        /// <para>
        /// Preferences related to AWS Chatbot usage in the calling AWS account.
        /// </para>
        /// </summary>
        public AccountPreferences AccountPreferences
        {
            get { return this._accountPreferences; }
            set { this._accountPreferences = value; }
        }

        // Check to see if AccountPreferences property is set
        internal bool IsSetAccountPreferences()
        {
            return this._accountPreferences != null;
        }

    }
}