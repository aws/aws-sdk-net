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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Provides details about execution input or output.
    /// </summary>
    public partial class CloudWatchEventsExecutionDataDetails
    {
        private bool? _included;

        /// <summary>
        /// Gets and sets the property Included. 
        /// <para>
        /// Indicates whether input or output was included in the response. Always <code>true</code>
        /// for API calls. 
        /// </para>
        /// </summary>
        public bool Included
        {
            get { return this._included.GetValueOrDefault(); }
            set { this._included = value; }
        }

        // Check to see if Included property is set
        internal bool IsSetIncluded()
        {
            return this._included.HasValue; 
        }

    }
}