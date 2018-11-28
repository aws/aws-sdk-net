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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The account details that could not be processed.
    /// </summary>
    public partial class Result
    {
        private string _accountId;
        private string _processingResult;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// An ID of the AWS account that could not be processed. 
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
        /// The reason for why an account could not be processed.
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