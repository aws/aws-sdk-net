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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// The summary of the lifecycle policy preview request.
    /// </summary>
    public partial class LifecyclePolicyPreviewSummary
    {
        private int? _expiringImageTotalCount;

        /// <summary>
        /// Gets and sets the property ExpiringImageTotalCount. 
        /// <para>
        /// The number of expiring images.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? ExpiringImageTotalCount
        {
            get { return this._expiringImageTotalCount; }
            set { this._expiringImageTotalCount = value; }
        }

        // Check to see if ExpiringImageTotalCount property is set
        internal bool IsSetExpiringImageTotalCount()
        {
            return this._expiringImageTotalCount.HasValue; 
        }

    }
}