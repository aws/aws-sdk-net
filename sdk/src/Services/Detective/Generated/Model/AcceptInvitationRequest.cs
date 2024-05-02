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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptInvitation operation.
    /// Accepts an invitation for the member account to contribute data to a behavior graph.
    /// This operation can only be called by an invited member account. 
    /// 
    ///  
    /// <para>
    /// The request provides the ARN of behavior graph.
    /// </para>
    ///  
    /// <para>
    /// The member account status in the graph must be <c>INVITED</c>.
    /// </para>
    /// </summary>
    public partial class AcceptInvitationRequest : AmazonDetectiveRequest
    {
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph that the member account is accepting the invitation
        /// for.
        /// </para>
        ///  
        /// <para>
        /// The member account status in the behavior graph must be <c>INVITED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

    }
}