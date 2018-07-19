/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateDRTLogBucket operation.
    /// Authorizes the DDoS Response team (DRT) to access the specified Amazon S3 bucket containing
    /// your flow logs. You can associate up to 10 Amazon S3 buckets with your subscription.
    /// 
    ///  
    /// <para>
    /// To use the services of the DRT and make an <code>AssociateDRTLogBucket</code> request,
    /// you must be subscribed to the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business
    /// Support plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
    /// Support plan</a>.
    /// </para>
    /// </summary>
    public partial class AssociateDRTLogBucketRequest : AmazonShieldRequest
    {
        private string _logBucket;

        /// <summary>
        /// Gets and sets the property LogBucket. 
        /// <para>
        /// The Amazon S3 bucket that contains your flow logs.
        /// </para>
        /// </summary>
        public string LogBucket
        {
            get { return this._logBucket; }
            set { this._logBucket = value; }
        }

        // Check to see if LogBucket property is set
        internal bool IsSetLogBucket()
        {
            return this._logBucket != null;
        }

    }
}