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
    /// An object that contains information about blacklist events.
    /// </summary>
    public partial class GetBlacklistReportsResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, List<BlacklistEntry>> _blacklistReport = new Dictionary<string, List<BlacklistEntry>>();

        /// <summary>
        /// Gets and sets the property BlacklistReport. 
        /// <para>
        /// An object that contains information about a blacklist that one of your dedicated IP
        /// addresses appears on.
        /// </para>
        /// </summary>
        public Dictionary<string, List<BlacklistEntry>> BlacklistReport
        {
            get { return this._blacklistReport; }
            set { this._blacklistReport = value; }
        }

        // Check to see if BlacklistReport property is set
        internal bool IsSetBlacklistReport()
        {
            return this._blacklistReport != null && this._blacklistReport.Count > 0; 
        }

    }
}