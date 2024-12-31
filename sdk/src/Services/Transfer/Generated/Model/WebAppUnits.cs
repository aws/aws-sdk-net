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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains an integer value that represents the value for number of concurrent connections
    /// or the user sessions on your web app.
    /// </summary>
    public partial class WebAppUnits
    {
        private int? _provisioned;

        /// <summary>
        /// Gets and sets the property Provisioned. 
        /// <para>
        /// An integer that represents the number of units for your desired number of concurrent
        /// connections, or the number of user sessions on your web app at the same time.
        /// </para>
        ///  
        /// <para>
        /// Each increment allows an additional 250 concurrent sessions: a value of <c>1</c> sets
        /// the number of concurrent sessions to 250; <c>2</c> sets a value of 500, and so on.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Provisioned
        {
            get { return this._provisioned; }
            set { this._provisioned = value; }
        }

        // Check to see if Provisioned property is set
        internal bool IsSetProvisioned()
        {
            return this._provisioned.HasValue; 
        }

    }
}