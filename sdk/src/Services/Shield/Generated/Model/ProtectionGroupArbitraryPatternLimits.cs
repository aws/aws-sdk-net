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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Limits settings on protection groups with arbitrary pattern type.
    /// </summary>
    public partial class ProtectionGroupArbitraryPatternLimits
    {
        private long? _maxMembers;

        /// <summary>
        /// Gets and sets the property MaxMembers. 
        /// <para>
        /// The maximum number of resources you can specify for a single arbitrary pattern in
        /// a protection group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long MaxMembers
        {
            get { return this._maxMembers.GetValueOrDefault(); }
            set { this._maxMembers = value; }
        }

        // Check to see if MaxMembers property is set
        internal bool IsSetMaxMembers()
        {
            return this._maxMembers.HasValue; 
        }

    }
}