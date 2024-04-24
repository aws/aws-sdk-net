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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A rule for configuring how Amazon Q Business responds when it encounters a a blocked
    /// topic. You can configure a custom message to inform your end users that they have
    /// asked about a restricted topic and suggest any next steps they should take.
    /// </summary>
    public partial class ContentBlockerRule
    {
        private string _systemMessageOverride;

        /// <summary>
        /// Gets and sets the property SystemMessageOverride. 
        /// <para>
        /// The configured custom message displayed to an end user informing them that they've
        /// used a blocked phrase during chat.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=350)]
        public string SystemMessageOverride
        {
            get { return this._systemMessageOverride; }
            set { this._systemMessageOverride = value; }
        }

        // Check to see if SystemMessageOverride property is set
        internal bool IsSetSystemMessageOverride()
        {
            return this._systemMessageOverride != null;
        }

    }
}