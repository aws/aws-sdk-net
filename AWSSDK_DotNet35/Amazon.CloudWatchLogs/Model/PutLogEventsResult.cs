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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class PutLogEventsResult : AmazonWebServiceResponse
    {
        private string _nextSequenceToken;
        private RejectedLogEventsInfo _rejectedLogEventsInfo;

        /// <summary>
        /// Gets and sets the property NextSequenceToken.
        /// </summary>
        public string NextSequenceToken
        {
            get { return this._nextSequenceToken; }
            set { this._nextSequenceToken = value; }
        }

        // Check to see if NextSequenceToken property is set
        internal bool IsSetNextSequenceToken()
        {
            return this._nextSequenceToken != null;
        }

        /// <summary>
        /// Gets and sets the property RejectedLogEventsInfo.
        /// </summary>
        public RejectedLogEventsInfo RejectedLogEventsInfo
        {
            get { return this._rejectedLogEventsInfo; }
            set { this._rejectedLogEventsInfo = value; }
        }

        // Check to see if RejectedLogEventsInfo property is set
        internal bool IsSetRejectedLogEventsInfo()
        {
            return this._rejectedLogEventsInfo != null;
        }

    }
}