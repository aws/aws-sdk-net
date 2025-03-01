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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBucketAccessKey operation.
    /// Creates a new access key for the specified Amazon Lightsail bucket. Access keys consist
    /// of an access key ID and corresponding secret access key.
    /// 
    ///  
    /// <para>
    /// Access keys grant full programmatic access to the specified bucket and its objects.
    /// You can have a maximum of two access keys per bucket. Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetBucketAccessKeys.html">GetBucketAccessKeys</a>
    /// action to get a list of current access keys for a specific bucket. For more information
    /// about access keys, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-creating-bucket-access-keys">Creating
    /// access keys for a bucket in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The <c>secretAccessKey</c> value is returned only in response to the <c>CreateBucketAccessKey</c>
    /// action. You can get a secret access key only when you first create an access key;
    /// you cannot get the secret access key later. If you lose the secret access key, you
    /// must create a new access key.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CreateBucketAccessKeyRequest : AmazonLightsailRequest
    {
        private string _bucketName;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that the new access key will belong to, and grant access to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=54)]
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

    }
}