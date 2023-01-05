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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// This is the response object from the CreateSubscriber operation.
    /// </summary>
    public partial class CreateSubscriberResponse : AmazonWebServiceResponse
    {
        private string _roleArn;
        private string _s3BucketArn;
        private string _snsArn;
        private string _subscriptionId;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) created by you to provide to the subscriber. For more
        /// information about ARNs and how to use them in policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_identifiers.html">IAM
        /// identifiers in the Identity and Access Management (IAM) User Guide</a>. .
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The ARN for the Amazon S3 bucket. 
        /// </para>
        /// </summary>
        public string S3BucketArn
        {
            get { return this._s3BucketArn; }
            set { this._s3BucketArn = value; }
        }

        // Check to see if S3BucketArn property is set
        internal bool IsSetS3BucketArn()
        {
            return this._s3BucketArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsArn. 
        /// <para>
        /// The ARN for the Amazon Simple Notification Service.
        /// </para>
        /// </summary>
        public string SnsArn
        {
            get { return this._snsArn; }
            set { this._snsArn = value; }
        }

        // Check to see if SnsArn property is set
        internal bool IsSetSnsArn()
        {
            return this._snsArn != null;
        }

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The <code>subscriptionId</code> created by the <code>CreateSubscriber</code> API call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SubscriptionId
        {
            get { return this._subscriptionId; }
            set { this._subscriptionId = value; }
        }

        // Check to see if SubscriptionId property is set
        internal bool IsSetSubscriptionId()
        {
            return this._subscriptionId != null;
        }

    }
}