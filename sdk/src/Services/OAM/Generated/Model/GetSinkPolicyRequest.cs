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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetSinkPolicy operation.
    /// Returns the current sink policy attached to this sink. The sink policy specifies what
    /// accounts can attach to this sink as source accounts, and what types of data they can
    /// share.
    /// </summary>
    public partial class GetSinkPolicyRequest : AmazonOAMRequest
    {
        private string _sinkIdentifier;

        /// <summary>
        /// Gets and sets the property SinkIdentifier. 
        /// <para>
        /// The ARN of the sink to retrieve the policy of.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SinkIdentifier
        {
            get { return this._sinkIdentifier; }
            set { this._sinkIdentifier = value; }
        }

        // Check to see if SinkIdentifier property is set
        internal bool IsSetSinkIdentifier()
        {
            return this._sinkIdentifier != null;
        }

    }
}