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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies settings for invoking an AWS Lambda function that customizes a segment for
    /// a campaign.
    /// </summary>
    public partial class CampaignHook
    {
        private string _lambdaFunctionName;
        private Mode _mode;
        private string _webUrl;

        /// <summary>
        /// Gets and sets the property LambdaFunctionName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AWS Lambda function that Amazon Pinpoint
        /// invokes to customize a segment for a campaign.
        /// </para>
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
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode that Amazon Pinpoint uses to invoke the AWS Lambda function. Possible values
        /// are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// FILTER - Invoke the function to customize the segment that's used by a campaign.
        /// </para>
        /// </li> <li>
        /// <para>
        /// DELIVERY - (Deprecated) Previously, invoked the function to send a campaign through
        /// a custom channel. This functionality is not supported anymore. To send a campaign
        /// through a custom channel, use the CustomDeliveryConfiguration and CampaignCustomMessage
        /// objects of the campaign.
        /// </para>
        /// </li></ul>
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
        /// Gets and sets the property WebUrl.  
        /// <para>
        /// The web URL that Amazon Pinpoint calls to invoke the AWS Lambda function over HTTPS.
        /// </para>
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