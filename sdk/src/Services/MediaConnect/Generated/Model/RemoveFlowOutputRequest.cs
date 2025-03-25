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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveFlowOutput operation.
    /// Removes an output from an existing flow. This request can be made only on an output
    /// that does not have an entitlement associated with it. If the output has an entitlement,
    /// you must revoke the entitlement instead. When an entitlement is revoked from a flow,
    /// the service automatically removes the associated output.
    /// </summary>
    public partial class RemoveFlowOutputRequest : AmazonMediaConnectRequest
    {
        private string _flowArn;
        private string _outputArn;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the flow that you want to remove an output from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputArn. 
        /// <para>
        ///  The ARN of the output that you want to remove. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputArn
        {
            get { return this._outputArn; }
            set { this._outputArn = value; }
        }

        // Check to see if OutputArn property is set
        internal bool IsSetOutputArn()
        {
            return this._outputArn != null;
        }

    }
}