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
 * Do not modify this file. This file is generated from the cloudcontrol-2021-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudControlApi.Model
{
    /// <summary>
    /// Container for the parameters to the CancelResourceRequest operation.
    /// Cancels the specified resource operation request. For more information, see <a href="https://docs.aws.amazon.com/cloudcontrolapi/latest/userguide/resource-operations-manage-requests.html#resource-operations-manage-requests-cancel">Canceling
    /// resource operation requests</a> in the <i>Amazon Web Services Cloud Control API User
    /// Guide</i>.
    /// 
    ///  
    /// <para>
    /// Only resource operations requests with a status of <code>PENDING</code> or <code>IN_PROGRESS</code>
    /// can be cancelled.
    /// </para>
    /// </summary>
    public partial class CancelResourceRequestRequest : AmazonCloudControlApiRequest
    {
        private string _requestToken;

        /// <summary>
        /// Gets and sets the property RequestToken. 
        /// <para>
        /// The <code>RequestToken</code> of the <code>ProgressEvent</code> object returned by
        /// the resource operation request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string RequestToken
        {
            get { return this._requestToken; }
            set { this._requestToken = value; }
        }

        // Check to see if RequestToken property is set
        internal bool IsSetRequestToken()
        {
            return this._requestToken != null;
        }

    }
}