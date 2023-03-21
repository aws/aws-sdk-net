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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Export task error.
    /// </summary>
    public partial class ExportTaskError
    {
        private ExportErrorData _errorData;
        private string _errorDateTime;

        /// <summary>
        /// Gets and sets the property ErrorData. 
        /// <para>
        /// Export task error data.
        /// </para>
        /// </summary>
        public ExportErrorData ErrorData
        {
            get { return this._errorData; }
            set { this._errorData = value; }
        }

        // Check to see if ErrorData property is set
        internal bool IsSetErrorData()
        {
            return this._errorData != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorDateTime. 
        /// <para>
        /// Export task error datetime.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string ErrorDateTime
        {
            get { return this._errorDateTime; }
            set { this._errorDateTime = value; }
        }

        // Check to see if ErrorDateTime property is set
        internal bool IsSetErrorDateTime()
        {
            return this._errorDateTime != null;
        }

    }
}