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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the GetGameSessionLogUrl operation.
    /// </summary>
    public partial class GetGameSessionLogUrlResponse : AmazonWebServiceResponse
    {
        private string _preSignedUrl;

        /// <summary>
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// Location of the requested game session logs, available for download. This URL is valid
        /// for 15 minutes, after which S3 will reject any download request using this URL. You
        /// can request a new URL any time within the 14-day period that the logs are retained.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

    }
}