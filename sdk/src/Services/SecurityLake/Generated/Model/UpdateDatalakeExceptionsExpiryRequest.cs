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
    /// Container for the parameters to the UpdateDatalakeExceptionsExpiry operation.
    /// Update the expiration period for the exception message to your preferred time, and
    /// control the time-to-live (TTL) for the exception message to remain. Exceptions are
    /// stored by default for 2 weeks from when a record was created in Amazon Security Lake.
    /// </summary>
    public partial class UpdateDatalakeExceptionsExpiryRequest : AmazonSecurityLakeRequest
    {
        private long? _exceptionMessageExpiry;

        /// <summary>
        /// Gets and sets the property ExceptionMessageExpiry. 
        /// <para>
        /// The time-to-live (TTL) for the exception message to remain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long ExceptionMessageExpiry
        {
            get { return this._exceptionMessageExpiry.GetValueOrDefault(); }
            set { this._exceptionMessageExpiry = value; }
        }

        // Check to see if ExceptionMessageExpiry property is set
        internal bool IsSetExceptionMessageExpiry()
        {
            return this._exceptionMessageExpiry.HasValue; 
        }

    }
}