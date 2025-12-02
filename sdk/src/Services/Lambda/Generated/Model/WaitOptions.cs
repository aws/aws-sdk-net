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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Specifies how long to pause the durable execution.
    /// </summary>
    public partial class WaitOptions
    {
        private int? _waitSeconds;

        /// <summary>
        /// Gets and sets the property WaitSeconds. 
        /// <para>
        /// The duration to wait, in seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=31622400)]
        public int WaitSeconds
        {
            get { return this._waitSeconds.GetValueOrDefault(); }
            set { this._waitSeconds = value; }
        }

        // Check to see if WaitSeconds property is set
        internal bool IsSetWaitSeconds()
        {
            return this._waitSeconds.HasValue; 
        }

    }
}