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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The Amazon Simple Notification Service topic to which Amazon Rekognition publishes
    /// the object detection results and completion status of a video analysis operation.
    /// 
    ///  
    /// <para>
    /// Amazon Rekognition publishes a notification the first time an object of interest or
    /// a person is detected in the video stream. For example, if Amazon Rekognition detects
    /// a person at second 2, a pet at second 4, and a person again at second 5, Amazon Rekognition
    /// sends 2 object class detected notifications, one for a person at second 2 and one
    /// for a pet at second 4.
    /// </para>
    ///  
    /// <para>
    /// Amazon Rekognition also publishes an an end-of-session notification with a summary
    /// when the stream processing session is complete.
    /// </para>
    /// </summary>
    public partial class StreamProcessorNotificationChannel
    {
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property SNSTopicArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the Amazon Amazon Simple Notification Service
        /// topic to which Amazon Rekognition posts the completion status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SNSTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SNSTopicArn property is set
        internal bool IsSetSNSTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}