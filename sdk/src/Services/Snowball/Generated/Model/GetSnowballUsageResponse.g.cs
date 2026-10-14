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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// This is the response object from the GetSnowballUsage operation.
    /// </summary>
    public partial class GetSnowballUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SnowballLimit. 
        /// <para>
        /// The service limit for number of Snow devices this account can have at once. The default
        /// service limit is 1 (one).
        /// </para>
        /// </summary>
        public int? SnowballLimit { get; set; }

        /// <summary>
        /// Checks to see if the SnowballLimit property is set.
        /// </summary>
        internal bool IsSetSnowballLimit() => this.SnowballLimit.HasValue;

        /// <summary>
        /// Gets and sets the property SnowballsInUse. 
        /// <para>
        /// The number of Snow devices that this account is currently using.
        /// </para>
        /// </summary>
        public int? SnowballsInUse { get; set; }

        /// <summary>
        /// Checks to see if the SnowballsInUse property is set.
        /// </summary>
        internal bool IsSetSnowballsInUse() => this.SnowballsInUse.HasValue;
    }
}
