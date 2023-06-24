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
 * Do not modify this file. This file is generated from the gamesparks-2021-08-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameSparks.Model
{
    /// <summary>
    /// This is the response object from the StartGeneratedCodeJob operation.
    /// </summary>
    public partial class StartGeneratedCodeJobResponse : AmazonWebServiceResponse
    {
        private string _generatedCodeJobId;

        /// <summary>
        /// Gets and sets the property GeneratedCodeJobId. 
        /// <para>
        ///  The identifier of the code generation job. You can use this identifier in the <code>GetGeneratedCodeJob</code>
        /// operation. 
        /// </para>
        /// </summary>
        public string GeneratedCodeJobId
        {
            get { return this._generatedCodeJobId; }
            set { this._generatedCodeJobId = value; }
        }

        // Check to see if GeneratedCodeJobId property is set
        internal bool IsSetGeneratedCodeJobId()
        {
            return this._generatedCodeJobId != null;
        }

    }
}