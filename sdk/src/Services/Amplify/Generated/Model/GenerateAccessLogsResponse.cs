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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the generate access logs request.
    /// </summary>
    public partial class GenerateAccessLogsResponse : AmazonWebServiceResponse
    {
        private string _logUrl;

        /// <summary>
        /// Gets and sets the property LogUrl. 
        /// <para>
        ///  The pre-signed URL for the requested access logs. 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1000)]
        public string LogUrl
        {
            get { return this._logUrl; }
            set { this._logUrl = value; }
        }

        // Check to see if LogUrl property is set
        internal bool IsSetLogUrl()
        {
            return this._logUrl != null;
        }

    }
}