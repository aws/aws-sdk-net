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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// This is the response object from the CreateAddonInstance operation.
    /// </summary>
    public partial class CreateAddonInstanceResponse : AmazonWebServiceResponse
    {
        private string _addonInstanceId;

        /// <summary>
        /// Gets and sets the property AddonInstanceId. 
        /// <para>
        /// The unique ID of the Add On instance created by this API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=67)]
        public string AddonInstanceId
        {
            get { return this._addonInstanceId; }
            set { this._addonInstanceId = value; }
        }

        // Check to see if AddonInstanceId property is set
        internal bool IsSetAddonInstanceId()
        {
            return this._addonInstanceId != null;
        }

    }
}