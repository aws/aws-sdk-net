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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Container for the parameters to the TerminateMicrovm operation.
    /// Terminates a MicroVM. This operation is idempotent; terminating a MicroVM that has
    /// already been terminated succeeds without error.
    /// </summary>
    public partial class TerminateMicrovmRequest : AmazonLambdaMicrovmsRequest
    {
        private string _microvmIdentifier;

        /// <summary>
        /// Gets and sets the property MicrovmIdentifier. 
        /// <para>
        /// The ID of the MicroVM to terminate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string MicrovmIdentifier
        {
            get { return this._microvmIdentifier; }
            set { this._microvmIdentifier = value; }
        }

        // Check to see if MicrovmIdentifier property is set
        internal bool IsSetMicrovmIdentifier()
        {
            return this._microvmIdentifier != null;
        }

    }
}