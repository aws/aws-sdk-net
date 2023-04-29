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
    /// Export errors data.
    /// </summary>
    public partial class ExportErrorData
    {
        private string _rawError;

        /// <summary>
        /// Gets and sets the property RawError. 
        /// <para>
        /// Export errors data raw error.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string RawError
        {
            get { return this._rawError; }
            set { this._rawError = value; }
        }

        // Check to see if RawError property is set
        internal bool IsSetRawError()
        {
            return this._rawError != null;
        }

    }
}