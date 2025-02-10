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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// A filter that can be used to list command executions for a device that started or
    /// completed before or after a particular date and time.
    /// </summary>
    public partial class TimeFilter
    {
        private string _after;
        private string _before;

        /// <summary>
        /// Gets and sets the property After. 
        /// <para>
        /// Filter to display command executions that started or completed only after a particular
        /// date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string After
        {
            get { return this._after; }
            set { this._after = value; }
        }

        // Check to see if After property is set
        internal bool IsSetAfter()
        {
            return this._after != null;
        }

        /// <summary>
        /// Gets and sets the property Before. 
        /// <para>
        /// Filter to display command executions that started or completed only before a particular
        /// date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Before
        {
            get { return this._before; }
            set { this._before = value; }
        }

        // Check to see if Before property is set
        internal bool IsSetBefore()
        {
            return this._before != null;
        }

    }
}