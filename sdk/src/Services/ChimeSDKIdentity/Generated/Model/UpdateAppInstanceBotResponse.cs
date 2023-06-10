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
 * Do not modify this file. This file is generated from the chime-sdk-identity-2021-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKIdentity.Model
{
    /// <summary>
    /// This is the response object from the UpdateAppInstanceBot operation.
    /// </summary>
    public partial class UpdateAppInstanceBotResponse : AmazonWebServiceResponse
    {
        private string _appInstanceBotArn;

        /// <summary>
        /// Gets and sets the property AppInstanceBotArn. 
        /// <para>
        /// The ARN of the <code>AppInstanceBot</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=1600)]
        public string AppInstanceBotArn
        {
            get { return this._appInstanceBotArn; }
            set { this._appInstanceBotArn = value; }
        }

        // Check to see if AppInstanceBotArn property is set
        internal bool IsSetAppInstanceBotArn()
        {
            return this._appInstanceBotArn != null;
        }

    }
}