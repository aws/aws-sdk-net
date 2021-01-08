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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the status of a sensitive data finding.
    /// </summary>
    public partial class ClassificationResultStatus
    {
        private string _code;
        private string _reason;

        /// <summary>
        /// Gets and sets the property Code.  
        /// <para>
        /// The status of the finding. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// COMPLETE - Amazon Macie successfully completed its analysis of the object that the
        /// finding applies to.
        /// </para>
        /// </li> <li>
        /// <para>
        /// PARTIAL - Macie analyzed only a subset of the data in the object that the finding
        /// applies to. For example, the object is an archive file that contains files in an unsupported
        /// format.
        /// </para>
        /// </li> <li>
        /// <para>
        /// SKIPPED - Macie wasn't able to analyze the object that the finding applies to. For
        /// example, the object is a malformed file or a file that uses an unsupported format.
        /// </para>
        /// </li></ul>
        /// </summary>
        public string Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// A brief description of the status of the finding. Amazon Macie uses this value to
        /// notify you of any errors, warnings, or considerations that might impact your analysis
        /// of the finding.
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