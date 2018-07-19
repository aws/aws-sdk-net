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
    /// Container for the parameters to the DisassociateDRTLogBucket operation.
    /// Removes the DDoS Response team's (DRT) access to the specified Amazon S3 bucket containing
    /// your flow logs.
    /// 
    ///  
    /// <para>
    /// To make a <code>DisassociateDRTLogBucket</code> request, you must be subscribed to
    /// the <a href="https://aws.amazon.com/premiumsupport/business-support/">Business Support
    /// plan</a> or the <a href="https://aws.amazon.com/premiumsupport/enterprise-support/">Enterprise
    /// Support plan</a>. However, if you are not subscribed to one of these support plans,
    /// but had been previously and had granted the DRT access to your account, you can submit
    /// a <code>DisassociateDRTLogBucket</code> request to remove this access.
    /// </para>
    /// </summary>
    public partial class DisassociateDRTLogBucketRequest : AmazonShieldRequest
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