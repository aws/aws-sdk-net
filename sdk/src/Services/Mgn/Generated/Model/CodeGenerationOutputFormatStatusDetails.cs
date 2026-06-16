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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Status details for a specific code generation output format.
    /// </summary>
    public partial class CodeGenerationOutputFormatStatusDetails
    {
        private CodeGenerationOutputFormatStatus _status;
        private string _statusDetailList;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the code generation for this output format.
        /// </para>
        /// </summary>
        public CodeGenerationOutputFormatStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusDetailList. 
        /// <para>
        /// A list of detailed status information for the code generation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public string StatusDetailList
        {
            get { return this._statusDetailList; }
            set { this._statusDetailList = value; }
        }

        // Check to see if StatusDetailList property is set
        internal bool IsSetStatusDetailList()
        {
            return this._statusDetailList != null;
        }

    }
}