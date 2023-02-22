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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the UpdateScheduledAction operation.
    /// </summary>
    public partial class UpdateScheduledActionResponse : AmazonWebServiceResponse
    {
        private ScheduledAction _scheduledAction;

        /// <summary>
        /// Gets and sets the property ScheduledAction. 
        /// <para>
        /// Information about the rescheduled action.
        /// </para>
        /// </summary>
        public ScheduledAction ScheduledAction
        {
            get { return this._scheduledAction; }
            set { this._scheduledAction = value; }
        }

        // Check to see if ScheduledAction property is set
        internal bool IsSetScheduledAction()
        {
            return this._scheduledAction != null;
        }

    }
}