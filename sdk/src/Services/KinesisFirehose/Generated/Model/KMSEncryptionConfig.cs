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
 * Do not modify this file. This file is generated from the firehose-2015-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisFirehose.Model
{
    /// <summary>
    /// Describes an encryption key for a destination in Amazon S3.
    /// </summary>
    public partial class KMSEncryptionConfig
    {
        private string _awskmsKeyARN;

        /// <summary>
        /// Gets and sets the property AWSKMSKeyARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the encryption key. Must belong to the same Amazon
        /// Web Services Region as the destination Amazon S3 bucket. For more information, see
        /// <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AWSKMSKeyARN
        {
            get { return this._awskmsKeyARN; }
            set { this._awskmsKeyARN = value; }
        }

        // Check to see if AWSKMSKeyARN property is set
        internal bool IsSetAWSKMSKeyARN()
        {
            return this._awskmsKeyARN != null;
        }

    }
}