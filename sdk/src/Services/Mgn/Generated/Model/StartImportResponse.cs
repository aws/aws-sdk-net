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
    /// Start import response.
    /// </summary>
    public partial class StartImportResponse : AmazonWebServiceResponse
    {
        private ImportTask _importTask;

        /// <summary>
        /// Gets and sets the property ImportTask. 
        /// <para>
        /// Start import response import task.
        /// </para>
        /// </summary>
        public ImportTask ImportTask
        {
            get { return this._importTask; }
            set { this._importTask = value; }
        }

        // Check to see if ImportTask property is set
        internal bool IsSetImportTask()
        {
            return this._importTask != null;
        }

    }
}