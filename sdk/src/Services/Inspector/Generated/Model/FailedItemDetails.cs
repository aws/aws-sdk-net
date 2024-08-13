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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// Includes details about the failed items.
    /// </summary>
    public partial class FailedItemDetails
    {
        private FailedItemErrorCode _failureCode;
        private bool? _retryable;

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The status code of a failed item.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FailedItemErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property Retryable. 
        /// <para>
        /// Indicates whether you can immediately retry a request for this item for a specified
        /// resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Retryable
        {
            get { return this._retryable; }
            set { this._retryable = value; }
        }

        // Check to see if Retryable property is set
        internal bool IsSetRetryable()
        {
            return this._retryable.HasValue; 
        }

    }
}