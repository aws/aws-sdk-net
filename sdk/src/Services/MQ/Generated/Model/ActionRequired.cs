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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
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
namespace Amazon.MQ.Model
{
    /// <summary>
    /// Action required for a broker.
    /// </summary>
    public partial class ActionRequired
    {
        private string _actionRequiredCode;
        private string _actionRequiredInfo;

        /// <summary>
        /// Gets and sets the property ActionRequiredCode. 
        /// <para>
        /// The code you can use to find instructions on the action required to resolve your broker
        /// issue.
        /// </para>
        /// </summary>
        public string ActionRequiredCode
        {
            get { return this._actionRequiredCode; }
            set { this._actionRequiredCode = value; }
        }

        // Check to see if ActionRequiredCode property is set
        internal bool IsSetActionRequiredCode()
        {
            return this._actionRequiredCode != null;
        }

        /// <summary>
        /// Gets and sets the property ActionRequiredInfo. 
        /// <para>
        /// Information about the action required to resolve your broker issue.
        /// </para>
        /// </summary>
        public string ActionRequiredInfo
        {
            get { return this._actionRequiredInfo; }
            set { this._actionRequiredInfo = value; }
        }

        // Check to see if ActionRequiredInfo property is set
        internal bool IsSetActionRequiredInfo()
        {
            return this._actionRequiredInfo != null;
        }

    }
}