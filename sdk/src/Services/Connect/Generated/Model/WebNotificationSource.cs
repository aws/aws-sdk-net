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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// The source of an outbound web notification. Identifies the campaign and outbound request
    /// that triggered the notification.
    /// </summary>
    public partial class WebNotificationSource
    {
        private SourceCampaign _sourceCampaign;

        /// <summary>
        /// Gets and sets the property SourceCampaign. 
        /// <para>
        /// Information about the campaign that triggered the web notification, including the
        /// campaign identifier and outbound request identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceCampaign SourceCampaign
        {
            get { return this._sourceCampaign; }
            set { this._sourceCampaign = value; }
        }

        // Check to see if SourceCampaign property is set
        internal bool IsSetSourceCampaign()
        {
            return this._sourceCampaign != null;
        }

    }
}