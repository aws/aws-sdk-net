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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// Container for the parameters to the GetJobManifest operation.
    /// Returns a link to an Amazon S3 presigned URL for the manifest file associated with
    /// the specified <c>JobId</c> value. You can access the manifest file for up to 60 minutes
    /// after this request has been made. To access the manifest file after 60 minutes have
    /// passed, you'll have to make another call to the <c>GetJobManifest</c> action.
    /// 
    ///  
    /// <para>
    /// The manifest is an encrypted file that you can download after your job enters the
    /// <c>WithCustomer</c> status. This is the only valid status for calling this API as
    /// the manifest and <c>UnlockCode</c> code value are used for securing your device and
    /// should only be used when you have the device. The manifest is decrypted by using the
    /// <c>UnlockCode</c> code value, when you pass both values to the Snow device through
    /// the Snowball client when the client is started for the first time. 
    /// </para>
    ///  
    /// <para>
    /// As a best practice, we recommend that you don't save a copy of an <c>UnlockCode</c>
    /// value in the same location as the manifest file for that job. Saving these separately
    /// helps prevent unauthorized parties from gaining access to the Snow device associated
    /// with that job.
    /// </para>
    ///  
    /// <para>
    /// The credentials of a given job, including its manifest file and unlock code, expire
    /// 360 days after the job is created.
    /// </para>
    /// </summary>
    public partial class GetJobManifestRequest : AmazonSnowballRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for a job that you want to get the manifest file for, for example <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=39, Max=39)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}