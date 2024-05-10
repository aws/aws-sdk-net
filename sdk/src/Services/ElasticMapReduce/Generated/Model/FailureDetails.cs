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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The details of the step failure. The service attempts to detect the root cause for
    /// many common failures.
    /// </summary>
    public partial class FailureDetails
    {
        private string _logFile;
        private string _message;
        private string _reason;

        /// <summary>
        /// Gets and sets the property LogFile. 
        /// <para>
        /// The path to the log file where the step failure root cause was originally recorded.
        /// </para>
        /// </summary>
        public string LogFile
        {
            get { return this._logFile; }
            set { this._logFile = value; }
        }

        // Check to see if LogFile property is set
        internal bool IsSetLogFile()
        {
            return this._logFile != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The descriptive message including the error the Amazon EMR service has identified
        /// as the cause of step failure. This is text from an error log that describes the root
        /// cause of the failure.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the step failure. In the case where the service cannot successfully
        /// determine the root cause of the failure, it returns "Unknown Error" as a reason.
        /// </para>
        /// </summary>
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}