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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeyGroup operation.
    /// Creates a key group that you can use with <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">CloudFront
    /// signed URLs and signed cookies</a>.
    /// 
    ///  
    /// <para>
    /// To create a key group, you must specify at least one public key for the key group.
    /// After you create a key group, you can reference it from one or more cache behaviors.
    /// When you reference a key group in a cache behavior, CloudFront requires signed URLs
    /// or signed cookies for all requests that match the cache behavior. The URLs or cookies
    /// must be signed with a private key whose corresponding public key is in the key group.
    /// The signed URL or cookie contains information about which public key CloudFront should
    /// use to verify the signature. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/PrivateContent.html">Serving
    /// private content</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateKeyGroupRequest : AmazonCloudFrontRequest
    {
        private KeyGroupConfig _keyGroupConfig;

        /// <summary>
        /// Gets and sets the property KeyGroupConfig. 
        /// <para>
        /// A key group configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyGroupConfig KeyGroupConfig
        {
            get { return this._keyGroupConfig; }
            set { this._keyGroupConfig = value; }
        }

        // Check to see if KeyGroupConfig property is set
        internal bool IsSetKeyGroupConfig()
        {
            return this._keyGroupConfig != null;
        }

    }
}