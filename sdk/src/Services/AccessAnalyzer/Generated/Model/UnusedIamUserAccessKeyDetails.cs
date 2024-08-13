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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an unused access finding for an IAM user access key. IAM
    /// Access Analyzer charges for unused access analysis based on the number of IAM roles
    /// and users analyzed per month. For more details on pricing, see <a href="https://aws.amazon.com/iam/access-analyzer/pricing">IAM
    /// Access Analyzer pricing</a>.
    /// </summary>
    public partial class UnusedIamUserAccessKeyDetails
    {
        private string _accessKeyId;
        private DateTime? _lastAccessed;

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The ID of the access key for which the unused access finding was generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessKeyId
        {
            get { return this._accessKeyId; }
            set { this._accessKeyId = value; }
        }

        // Check to see if AccessKeyId property is set
        internal bool IsSetAccessKeyId()
        {
            return this._accessKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property LastAccessed. 
        /// <para>
        /// The time at which the access key was last accessed.
        /// </para>
        /// </summary>
        public DateTime? LastAccessed
        {
            get { return this._lastAccessed; }
            set { this._lastAccessed = value; }
        }

        // Check to see if LastAccessed property is set
        internal bool IsSetLastAccessed()
        {
            return this._lastAccessed.HasValue; 
        }

    }
}