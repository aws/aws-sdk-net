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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// List of all failures.
    /// </summary>
    public partial class Failures
    {
        private string _exceptionMessage;
        private string _remediation;
        private DateTime? _timestamp;

        /// <summary>
        /// Gets and sets the property ExceptionMessage. 
        /// <para>
        /// List of all exception messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExceptionMessage
        {
            get { return this._exceptionMessage; }
            set { this._exceptionMessage = value; }
        }

        // Check to see if ExceptionMessage property is set
        internal bool IsSetExceptionMessage()
        {
            return this._exceptionMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Remediation. 
        /// <para>
        /// List of all remediation steps for failures.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Remediation
        {
            get { return this._remediation; }
            set { this._remediation = value; }
        }

        // Check to see if Remediation property is set
        internal bool IsSetRemediation()
        {
            return this._remediation != null;
        }

        /// <summary>
        /// Gets and sets the property Timestamp. 
        /// <para>
        /// This error can occur if you configure the wrong timestamp format, or if the subset
        /// of entries used for validation had errors or missing values.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime Timestamp
        {
            get { return this._timestamp.GetValueOrDefault(); }
            set { this._timestamp = value; }
        }

        // Check to see if Timestamp property is set
        internal bool IsSetTimestamp()
        {
            return this._timestamp.HasValue; 
        }

    }
}