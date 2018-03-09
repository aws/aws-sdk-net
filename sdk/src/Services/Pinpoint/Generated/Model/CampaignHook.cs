/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CampaignHook
    {
        private string _lambdaFunctionName;
        private Mode _mode;
        private string _webUrl;

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. Lambda function name or arn to be called
        /// for delivery
        /// </summary>
        public string LambdaFunctionName
        {
            get { return this._lambdaFunctionName; }
            set { this._lambdaFunctionName = value; }
        }

        // Check to see if LambdaFunctionName property is set
        internal bool IsSetLambdaFunctionName()
        {
            return this._lambdaFunctionName != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. What mode Lambda should be invoked in.
        /// </summary>
        public Mode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property WebUrl. Web URL to call for hook. If the URL has authentication
        /// specified it will be added as authentication to the request
        /// </summary>
        public string WebUrl
        {
            get { return this._webUrl; }
            set { this._webUrl = value; }
        }

        // Check to see if WebUrl property is set
        internal bool IsSetWebUrl()
        {
            return this._webUrl != null;
        }

    }
}