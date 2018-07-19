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
    /// This is the response object from the DescribeDRTAccess operation.
    /// </summary>
    public partial class DescribeDRTAccessResponse : AmazonWebServiceResponse
    {
        private List<string> _logBucketList = new List<string>();
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property LogBucketList. 
        /// <para>
        /// The list of Amazon S3 buckets accessed by the DRT.
        /// </para>
        /// </summary>
        public List<string> LogBucketList
        {
            get { return this._logBucketList; }
            set { this._logBucketList = value; }
        }

        // Check to see if LogBucketList property is set
        internal bool IsSetLogBucketList()
        {
            return this._logBucketList != null && this._logBucketList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role the DRT used to access your AWS account.
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

    }
}