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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the GetConnection operation.
    /// <note> 
    /// <para>
    ///  Amazon Web Services uses this action to install Outpost servers.
    /// </para>
    ///  </note> 
    /// <para>
    ///  Gets information about the specified connection. 
    /// </para>
    ///  
    /// <para>
    ///  Use CloudTrail to monitor this action or Amazon Web Services managed policy for Amazon
    /// Web Services Outposts to secure it. For more information, see <a href="https://docs.aws.amazon.com/outposts/latest/userguide/security-iam-awsmanpol.html">
    /// Amazon Web Services managed policies for Amazon Web Services Outposts</a> and <a href="https://docs.aws.amazon.com/outposts/latest/userguide/logging-using-cloudtrail.html">
    /// Logging Amazon Web Services Outposts API calls with Amazon Web Services CloudTrail</a>
    /// in the <i>Amazon Web Services Outposts User Guide</i>. 
    /// </para>
    /// </summary>
    public partial class GetConnectionRequest : AmazonOutpostsRequest
    {
        private string _connectionId;

        /// <summary>
        /// Gets and sets the property ConnectionId. 
        /// <para>
        ///  The ID of the connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConnectionId
        {
            get { return this._connectionId; }
            set { this._connectionId = value; }
        }

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this._connectionId != null;
        }

    }
}