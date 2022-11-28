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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Textract.Model
{
    /// <summary>
    /// Sets whether or not your output will go to a user created bucket. Used to set the
    /// name of the bucket, and the prefix on the output file.
    /// 
    ///  
    /// <para>
    ///  <code>OutputConfig</code> is an optional parameter which lets you adjust where your
    /// output will be placed. By default, Amazon Textract will store the results internally
    /// and can only be accessed by the Get API operations. With <code>OutputConfig</code>
    /// enabled, you can set the name of the bucket the output will be sent to the file prefix
    /// of the results where you can download your results. Additionally, you can set the
    /// <code>KMSKeyID</code> parameter to a customer master key (CMK) to encrypt your output.
    /// Without this parameter set Amazon Textract will encrypt server-side using the AWS
    /// managed CMK for Amazon S3.
    /// </para>
    ///  
    /// <para>
    /// Decryption of Customer Content is necessary for processing of the documents by Amazon
    /// Textract. If your account is opted out under an AI services opt out policy then all
    /// unencrypted Customer Content is immediately and permanently deleted after the Customer
    /// Content has been processed by the service. No copy of of the output is retained by
    /// Amazon Textract. For information about how to opt out, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_ai-opt-out.html">
    /// Managing AI services opt-out policy. </a> 
    /// </para>
    ///  
    /// <para>
    /// For more information on data privacy, see the <a href="https://aws.amazon.com/compliance/data-privacy-faq/">Data
    /// Privacy FAQ</a>.
    /// </para>
    /// </summary>
    public partial class OutputConfig
    {
        private string _s3Bucket;
        private string _s3Prefix;

        /// <summary>
        /// Gets and sets the property S3Bucket. 
        /// <para>
        /// The name of the bucket your output will go to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string S3Bucket
        {
            get { return this._s3Bucket; }
            set { this._s3Bucket = value; }
        }

        // Check to see if S3Bucket property is set
        internal bool IsSetS3Bucket()
        {
            return this._s3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property S3Prefix. 
        /// <para>
        /// The prefix of the object key that the output will be saved to. When not enabled, the
        /// prefix will be “textract_output".
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3Prefix
        {
            get { return this._s3Prefix; }
            set { this._s3Prefix = value; }
        }

        // Check to see if S3Prefix property is set
        internal bool IsSetS3Prefix()
        {
            return this._s3Prefix != null;
        }

    }
}