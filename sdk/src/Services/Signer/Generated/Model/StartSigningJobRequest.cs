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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the StartSigningJob operation.
    /// Initiates a signing job to be performed on the code provided. Signing jobs are viewable
    /// by the <c>ListSigningJobs</c> operation for two years after they are performed. Note
    /// the following requirements: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  You must create an Amazon S3 source bucket. For more information, see <a href="http://docs.aws.amazon.com/AmazonS3/latest/gsg/CreatingABucket.html">Creating
    /// a Bucket</a> in the <i>Amazon S3 Getting Started Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your S3 source bucket must be version enabled.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must create an S3 destination bucket. AWS Signer uses your S3 destination bucket
    /// to write your signed code.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You specify the name of the source and destination buckets when calling the <c>StartSigningJob</c>
    /// operation.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must ensure the S3 buckets are from the same Region as the signing profile. Cross-Region
    /// signing isn't supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You must also specify a request token that identifies your request to Signer.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can call the <a>DescribeSigningJob</a> and the <a>ListSigningJobs</a> actions
    /// after you call <c>StartSigningJob</c>.
    /// </para>
    ///  
    /// <para>
    /// For a Java example that shows how to use this action, see <a href="https://docs.aws.amazon.com/signer/latest/developerguide/api-startsigningjob.html">StartSigningJob</a>.
    /// </para>
    /// </summary>
    public partial class StartSigningJobRequest : AmazonSignerRequest
    {
        private string _clientRequestToken;
        private Destination _destination;
        private string _profileName;
        private string _profileOwner;
        private Source _source;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// String that identifies the signing request. All calls after the first that use this
        /// token return the same response as the first call.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The S3 bucket in which to save your signed object. The destination contains the name
        /// of your bucket and an optional prefix.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Destination Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property ProfileOwner. 
        /// <para>
        /// The AWS account ID of the signing profile owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ProfileOwner
        {
            get { return this._profileOwner; }
            set { this._profileOwner = value; }
        }

        // Check to see if ProfileOwner property is set
        internal bool IsSetProfileOwner()
        {
            return this._profileOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The S3 bucket that contains the object to sign or a BLOB that contains your raw code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}