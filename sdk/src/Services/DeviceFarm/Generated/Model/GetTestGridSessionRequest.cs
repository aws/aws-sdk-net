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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the GetTestGridSession operation.
    /// A session is an instance of a browser created through a <c>RemoteWebDriver</c> with
    /// the URL from <a>CreateTestGridUrlResult$url</a>. You can use the following to look
    /// up sessions:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// The session ARN (<a>GetTestGridSessionRequest$sessionArn</a>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The project ARN and a session ID (<a>GetTestGridSessionRequest$projectArn</a> and
    /// <a>GetTestGridSessionRequest$sessionId</a>).
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetTestGridSessionRequest : AmazonDeviceFarmRequest
    {
        private string _projectArn;
        private string _sessionArn;
        private string _sessionId;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN for the project that this session belongs to. See <a>CreateTestGridProject</a>
        /// and <a>ListTestGridProjects</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionArn. 
        /// <para>
        /// An ARN that uniquely identifies a <a>TestGridSession</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string SessionArn
        {
            get { return this._sessionArn; }
            set { this._sessionArn = value; }
        }

        // Check to see if SessionArn property is set
        internal bool IsSetSessionArn()
        {
            return this._sessionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// An ID associated with this session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

    }
}