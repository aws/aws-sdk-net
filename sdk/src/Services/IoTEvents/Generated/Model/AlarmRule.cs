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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Defines when your alarm is invoked.
    /// </summary>
    public partial class AlarmRule
    {
        private SimpleRule _simpleRule;

        /// <summary>
        /// Gets and sets the property SimpleRule. 
        /// <para>
        /// A rule that compares an input property value to a threshold value with a comparison
        /// operator.
        /// </para>
        /// </summary>
        public SimpleRule SimpleRule
        {
            get { return this._simpleRule; }
            set { this._simpleRule = value; }
        }

        // Check to see if SimpleRule property is set
        internal bool IsSetSimpleRule()
        {
            return this._simpleRule != null;
        }

    }
}