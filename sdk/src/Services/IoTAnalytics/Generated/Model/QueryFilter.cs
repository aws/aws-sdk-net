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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// Information that is used to filter message data, to segregate it according to the
    /// timeframe in which it arrives.
    /// </summary>
    public partial class QueryFilter
    {
        private DeltaTime _deltaTime;

        /// <summary>
        /// Gets and sets the property DeltaTime. 
        /// <para>
        /// Used to limit data to that which has arrived since the last execution of the action.
        /// </para>
        /// </summary>
        public DeltaTime DeltaTime
        {
            get { return this._deltaTime; }
            set { this._deltaTime = value; }
        }

        // Check to see if DeltaTime property is set
        internal bool IsSetDeltaTime()
        {
            return this._deltaTime != null;
        }

    }
}