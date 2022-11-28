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
    /// Container for the parameters to the PutSinkPolicy operation.
    /// Creates or updates the resource policy that grants permissions to source accounts
    /// to link to the monitoring account sink. When you create a sink policy, you can grant
    /// permissions to all accounts in an organization or to individual accounts.
    /// 
    ///  
    /// <para>
    /// You can also use a sink policy to limit the types of data that is shared. The three
    /// types that you can allow or deny are:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Metrics</b> - Specify with <code>AWS::CloudWatch::Metric</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Log groups</b> - Specify with <code>AWS::Logs::LogGroup</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Traces</b> - Specify with <code>AWS::XRay::Trace</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// See the examples in this section to see how to specify permitted source accounts and
    /// data types.
    /// </para>
    /// </summary>
    public partial class PutSinkPolicyRequest : AmazonOAMRequest
    {
        private string _policy;
        private string _sinkIdentifier;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The JSON policy to use. If you are updating an existing policy, the entire existing
        /// policy is replaced by what you specify here.
        /// </para>
        ///  
        /// <para>
        /// The policy must be in JSON string format with quotation marks escaped and no newlines.
        /// </para>
        ///  
        /// <para>
        /// For examples of different types of policies, see the <b>Examples</b> section on this
        /// page.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property SinkIdentifier. 
        /// <para>
        /// The ARN of the sink to attach this policy to.
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