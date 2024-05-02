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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
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
namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Information about a filter to apply to the list of returned targets. You can filter
    /// by target type, address, or status. For example, to filter results to notification
    /// rules that have active Chatbot topics as targets, you could specify a ListTargetsFilter
    /// Name as <c>TargetType</c> and a Value of <c>SNS</c>, and a Name of <c>TARGET_STATUS</c>
    /// and a Value of <c>ACTIVE</c>.
    /// </summary>
    public partial class ListTargetsFilter
    {
        private ListTargetsFilterName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the attribute you want to use to filter the returned targets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ListTargetsFilterName Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the attribute you want to use to filter the returned targets. For example,
        /// if you specify <c>SNS</c> for the Target type, you could specify an Amazon Resource
        /// Name (ARN) for a topic as the value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}