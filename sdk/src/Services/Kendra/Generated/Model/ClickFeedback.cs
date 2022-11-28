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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Gathers information about when a particular result was clicked by a user. Your application
    /// uses the <code>SubmitFeedback</code> API to provide click information.
    /// </summary>
    public partial class ClickFeedback
    {
        private DateTime? _clickTime;
        private string _resultId;

        /// <summary>
        /// Gets and sets the property ClickTime. 
        /// <para>
        /// The Unix timestamp of the date and time that the result was clicked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime ClickTime
        {
            get { return this._clickTime.GetValueOrDefault(); }
            set { this._clickTime = value; }
        }

        // Check to see if ClickTime property is set
        internal bool IsSetClickTime()
        {
            return this._clickTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultId. 
        /// <para>
        /// The identifier of the search result that was clicked.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=73)]
        public string ResultId
        {
            get { return this._resultId; }
            set { this._resultId = value; }
        }

        // Check to see if ResultId property is set
        internal bool IsSetResultId()
        {
            return this._resultId != null;
        }

    }
}