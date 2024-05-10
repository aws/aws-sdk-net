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
    /// Container for the parameters to the GetJobUnlockCode operation.
    /// Returns the <c>UnlockCode</c> code value for the specified job. A particular <c>UnlockCode</c>
    /// value can be accessed for up to 360 days after the associated job has been created.
    /// 
    ///  
    /// <para>
    /// The <c>UnlockCode</c> value is a 29-character code with 25 alphanumeric characters
    /// and 4 hyphens. This code is used to decrypt the manifest file when it is passed along
    /// with the manifest to the Snow device through the Snowball client when the client is
    /// started for the first time. The only valid status for calling this API is <c>WithCustomer</c>
    /// as the manifest and <c>Unlock</c> code values are used for securing your device and
    /// should only be used when you have the device.
    /// </para>
    ///  
    /// <para>
    /// As a best practice, we recommend that you don't save a copy of the <c>UnlockCode</c>
    /// in the same location as the manifest file for that job. Saving these separately helps
    /// prevent unauthorized parties from gaining access to the Snow device associated with
    /// that job.
    /// </para>
    /// </summary>
    public partial class GetJobUnlockCodeRequest : AmazonSnowballRequest
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the job that you want to get the <c>UnlockCode</c> value for, for example
        /// <c>JID123e4567-e89b-12d3-a456-426655440000</c>.
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