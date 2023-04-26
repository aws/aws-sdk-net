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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Container for the parameters to the PutJobTagging operation.
    /// Sets the supplied tag-set on an S3 Batch Operations job.
    /// 
    ///  
    /// <para>
    /// A tag is a key-value pair. You can associate S3 Batch Operations tags with any job
    /// by sending a PUT request against the tagging subresource that is associated with the
    /// job. To modify the existing tag set, you can either replace the existing tag set entirely,
    /// or make changes within the existing tag set by retrieving the existing tag set using
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>,
    /// modify that tag set, and use this action to replace the tag set with the one you modified.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/batch-ops-managing-jobs.html#batch-ops-job-tags">Controlling
    /// access and labeling jobs using tags</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///   <note> <ul> <li> 
    /// <para>
    /// If you send this request with an empty tag set, Amazon S3 deletes the existing tag
    /// set on the Batch Operations job. If you use this method, you are charged for a Tier
    /// 1 Request (PUT). For more information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon
    /// S3 pricing</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For deleting existing tags for your Batch Operations job, a <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
    /// request is preferred because it achieves the same result without incurring charges.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A few things to consider about using tags:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon S3 limits the maximum number of tags to 50 tags per job.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can associate up to 50 tags with a job as long as they have unique tag keys.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A tag key can be up to 128 Unicode characters in length, and tag values can be up
    /// to 256 Unicode characters in length.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The key and values are case sensitive.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For tagging-related restrictions related to characters and encodings, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/allocation-tag-restrictions.html">User-Defined
    /// Tag Restrictions</a> in the <i>Billing and Cost Management User Guide</i>.
    /// </para>
    ///  </li> </ul> </li> </ul> </note>  
    /// <para>
    /// To use the <code>PutJobTagging</code> operation, you must have permission to perform
    /// the <code>s3:PutJobTagging</code> action.
    /// </para>
    ///  
    /// <para>
    /// Related actions include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateJob.html">CreateJob</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_GetJobTagging.html">GetJobTagging</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_DeleteJobTagging.html">DeleteJobTagging</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutJobTaggingRequest : AmazonS3ControlRequest
    {
        private string _accountId;
        private string _jobId;
        private List<S3Tag> _tags = new List<S3Tag>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID associated with the S3 Batch Operations job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID for the S3 Batch Operations job whose tags you want to replace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=36)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The set of tags to associate with the S3 Batch Operations job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<S3Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}