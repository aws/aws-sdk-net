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
    /// Container for the parameters to the DeleteUserAccessLoggingSettings operation.
    /// Deletes user access logging settings.
    /// </summary>
    public partial class DeleteUserAccessLoggingSettingsRequest : AmazonWorkSpacesWebRequest
    {
        private string _userAccessLoggingSettingsArn;

        /// <summary>
        /// Gets and sets the property UserAccessLoggingSettingsArn. 
        /// <para>
        /// The ARN of the user access logging settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string UserAccessLoggingSettingsArn
        {
            get { return this._userAccessLoggingSettingsArn; }
            set { this._userAccessLoggingSettingsArn = value; }
        }

        // Check to see if UserAccessLoggingSettingsArn property is set
        internal bool IsSetUserAccessLoggingSettingsArn()
        {
            return this._userAccessLoggingSettingsArn != null;
        }

    }
}