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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the RetryBuildBatch operation.
    /// Restarts a failed batch build. Only batch builds that have failed can be retried.
    /// </summary>
    public partial class RetryBuildBatchRequest : AmazonCodeBuildRequest
    {
        private string _id;
        private string _idempotencyToken;
        private RetryBuildBatchType _retryType;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// Specifies the identifier of the batch build to restart.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case sensitive identifier you provide to ensure the idempotency of the <c>RetryBuildBatch</c>
        /// request. The token is included in the <c>RetryBuildBatch</c> request and is valid
        /// for five minutes. If you repeat the <c>RetryBuildBatch</c> request with the same token,
        /// but change a parameter, CodeBuild returns a parameter mismatch error.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property RetryType. 
        /// <para>
        /// Specifies the type of retry to perform.
        /// </para>
        /// </summary>
        public RetryBuildBatchType RetryType
        {
            get { return this._retryType; }
            set { this._retryType = value; }
        }

        // Check to see if RetryType property is set
        internal bool IsSetRetryType()
        {
            return this._retryType != null;
        }

    }
}