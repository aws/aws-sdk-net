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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Container for the parameters to the NotifyWhenUploaded operation.
    /// Sends you notification through Amazon EventBridge when all files written to your file
    /// share have been uploaded to Amazon S3.
    /// 
    ///  
    /// <para>
    /// Storage Gateway can send a notification through Amazon EventBridge when all files
    /// written to your file share up to that point in time have been uploaded to Amazon S3.
    /// These files include files written to the file share up to the time that you make a
    /// request for notification. When the upload is done, Storage Gateway sends you notification
    /// through EventBridge. You can configure EventBridge to send the notification through
    /// event targets such as Amazon SNS or Lambda function. This operation is only supported
    /// for S3 File Gateways.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/filegateway/latest/files3/monitoring-file-gateway.html#get-notification">Getting
    /// file upload notification</a> in the <i>Amazon S3 File Gateway User Guide</i>.
    /// </para>
    /// </summary>
    public partial class NotifyWhenUploadedRequest : AmazonStorageGatewayRequest
    {
        private string _fileShareARN;

        /// <summary>
        /// Gets and sets the property FileShareARN.
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
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