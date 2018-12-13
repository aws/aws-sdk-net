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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.PinpointEmail.Model
{
    /// <summary>
    /// Container for the parameters to the GetBlacklistReports operation.
    /// Retrieve a list of the blacklists that your dedicated IP addresses appear on.
    /// </summary>
    public partial class GetBlacklistReportsRequest : AmazonPinpointEmailRequest
    {
        private List<string> _blacklistItemNames = new List<string>();

        /// <summary>
        /// Gets and sets the property BlacklistItemNames. 
        /// <para>
        /// A list of IP addresses that you want to retrieve blacklist information about. You
        /// can only specify the dedicated IP addresses that you use to send email using Amazon
        /// Pinpoint or Amazon SES.
        /// </para>
        /// </summary>
        public List<string> BlacklistItemNames
        {
            get { return this._blacklistItemNames; }
            set { this._blacklistItemNames = value; }
        }

        // Check to see if BlacklistItemNames property is set
        internal bool IsSetBlacklistItemNames()
        {
            return this._blacklistItemNames != null && this._blacklistItemNames.Count > 0; 
        }

    }
}