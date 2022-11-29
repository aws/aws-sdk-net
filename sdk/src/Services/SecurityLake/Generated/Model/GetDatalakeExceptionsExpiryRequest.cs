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
    /// Container for the parameters to the GetDatalakeExceptionsExpiry operation.
    /// Retrieves the expiration period and time-to-live (TTL) for which the exception message
    /// will remain. Exceptions are stored by default, for a 2 week period of time from when
    /// a record was created in Security Lake. This API does not take input parameters. This
    /// API does not take input parameters.
    /// </summary>
    public partial class GetDatalakeExceptionsExpiryRequest : AmazonSecurityLakeRequest
    {

    }
}