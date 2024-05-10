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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
    /// Details about the account that was not processed.
    /// </summary>
    public partial class Result
    {
        private string _accountId;
        private string _processingResult;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// An Amazon Web Services account ID of the account that was not processed.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ProcessingResult. 
        /// <para>
        /// The reason that the account was not processed.
        /// </para>
        /// </summary>
        public string ProcessingResult
        {
            get { return this._processingResult; }
            set { this._processingResult = value; }
        }

        // Check to see if ProcessingResult property is set
        internal bool IsSetProcessingResult()
        {
            return this._processingResult != null;
        }

    }
}