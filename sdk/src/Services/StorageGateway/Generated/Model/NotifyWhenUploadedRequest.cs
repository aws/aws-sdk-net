/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyWhenUploaded operation.
    /// Sends you notification through CloudWatch Events when all files written to your NFS
    /// file share have been uploaded to Amazon S3.
    /// 
    ///  
    /// <para>
    /// AWS Storage Gateway can send a notification through Amazon CloudWatch Events when
    /// all files written to your file share up to that point in time have been uploaded to
    /// Amazon S3. These files include files written to the NFS file share up to the time
    /// that you make a request for notification. When the upload is done, Storage Gateway
    /// sends you notification through an Amazon CloudWatch Event. You can configure CloudWatch
    /// Events to send the notification through event targets such as Amazon SNS or AWS Lambda
    /// function. This operation is only supported in the file gateway type.
    /// </para>
    ///  
    /// <para>
    /// For more information, see Getting File Upload Notification in the Storage Gateway
    /// User Guide (https://docs.aws.amazon.com/storagegateway/latest/userguide/monitoring-file-gateway.html#get-upload-notification).
    /// 
    /// </para>
    /// </summary>
    public partial class NotifyWhenUploadedRequest : AmazonStorageGatewayRequest
    {
        private string _fileShareARN;

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
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

    }
}