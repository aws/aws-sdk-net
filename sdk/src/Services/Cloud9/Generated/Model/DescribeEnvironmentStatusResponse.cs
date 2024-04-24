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
 * Do not modify this file. This file is generated from the cloud9-2017-09-23.normal.json service model.
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
namespace Amazon.Cloud9.Model
{
    /// <summary>
    /// This is the response object from the DescribeEnvironmentStatus operation.
    /// </summary>
    public partial class DescribeEnvironmentStatusResponse : AmazonWebServiceResponse
    {
        private string _message;
        private EnvironmentStatus _status;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Any informational message about the status of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the environment. Available values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>connecting</c>: The environment is connecting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>creating</c>: The environment is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>deleting</c>: The environment is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>error</c>: The environment is in an error state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ready</c>: The environment is ready.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopped</c>: The environment is stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>stopping</c>: The environment is stopping.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EnvironmentStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}