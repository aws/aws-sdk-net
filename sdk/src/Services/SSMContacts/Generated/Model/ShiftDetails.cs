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
 * Do not modify this file. This file is generated from the ssm-contacts-2021-05-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SSMContacts.Model
{
    /// <summary>
    /// Information about overrides to an on-call rotation shift.
    /// </summary>
    public partial class ShiftDetails
    {
        private List<string> _overriddenContactIds = new List<string>();

        /// <summary>
        /// Gets and sets the property OverriddenContactIds. 
        /// <para>
        /// The Amazon Resources Names (ARNs) of the contacts who were replaced in a shift when
        /// an override was created. If the override is deleted, these contacts are restored to
        /// the shift.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=25)]
        public List<string> OverriddenContactIds
        {
            get { return this._overriddenContactIds; }
            set { this._overriddenContactIds = value; }
        }

        // Check to see if OverriddenContactIds property is set
        internal bool IsSetOverriddenContactIds()
        {
            return this._overriddenContactIds != null && this._overriddenContactIds.Count > 0; 
        }

    }
}