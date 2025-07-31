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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateSessionLogger operation.
    /// Associates a session logger with a portal.
    /// </summary>
    public partial class AssociateSessionLoggerRequest : AmazonWorkSpacesWebRequest
    {
        private string _portalArn;
        private string _sessionLoggerArn;

        /// <summary>
        /// Gets and sets the property PortalArn. 
        /// <para>
        /// The ARN of the portal to associate to the session logger ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string PortalArn
        {
            get { return this._portalArn; }
            set { this._portalArn = value; }
        }

        // Check to see if PortalArn property is set
        internal bool IsSetPortalArn()
        {
            return this._portalArn != null;
        }

        /// <summary>
        /// Gets and sets the property SessionLoggerArn. 
        /// <para>
        /// The ARN of the session logger to associate to the portal ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SessionLoggerArn
        {
            get { return this._sessionLoggerArn; }
            set { this._sessionLoggerArn = value; }
        }

        // Check to see if SessionLoggerArn property is set
        internal bool IsSetSessionLoggerArn()
        {
            return this._sessionLoggerArn != null;
        }

    }
}