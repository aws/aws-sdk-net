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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// This is the response object from the NotifyWhenUploaded operation.
    /// </summary>
    public partial class NotifyWhenUploadedResponse : AmazonWebServiceResponse
    {
        private string _fileShareARN;
        private string _notificationId;

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Min=50, Max=500)]
        public string FileShareARN
        {
            get { return this._fileShareARN; }
            set { this._fileShareARN = value; }
        }

        // Check to see if FileShareARN property is set
        internal bool IsSetFileShareARN()
        {
            return this._fileShareARN != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationId.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NotificationId
        {
            get { return this._notificationId; }
            set { this._notificationId = value; }
        }

        // Check to see if NotificationId property is set
        internal bool IsSetNotificationId()
        {
            return this._notificationId != null;
        }

    }
}