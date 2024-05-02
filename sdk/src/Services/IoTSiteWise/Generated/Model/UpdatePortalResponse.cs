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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the UpdatePortal operation.
    /// </summary>
    public partial class UpdatePortalResponse : AmazonWebServiceResponse
    {
        private PortalStatus _portalStatus;

        /// <summary>
        /// Gets and sets the property PortalStatus. 
        /// <para>
        /// The status of the portal, which contains a state (<c>UPDATING</c> after successfully
        /// calling this operation) and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PortalStatus PortalStatus
        {
            get { return this._portalStatus; }
            set { this._portalStatus = value; }
        }

        // Check to see if PortalStatus property is set
        internal bool IsSetPortalStatus()
        {
            return this._portalStatus != null;
        }

    }
}