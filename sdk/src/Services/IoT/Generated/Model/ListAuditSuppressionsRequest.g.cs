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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditSuppressions operation. Lists your Device
    /// Defender audit listings. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListAuditSuppressions</a>
    /// action. </para>
    /// </summary>
    public partial class ListAuditSuppressionsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AscendingOrder. 
        /// <para>
        ///  Determines whether suppressions are listed in ascending order by expiration date
        /// or not. If parameter isn't provided, <c>ascendingOrder=true</c>. 
        /// </para>
        /// </summary>
        public bool? AscendingOrder { get; set; }

        /// <summary>
        /// Checks to see if the AscendingOrder property is set.
        /// </summary>
        internal bool IsSetAscendingOrder() => this.AscendingOrder.HasValue;

        /// <summary>
        /// Gets and sets the property CheckName.
        /// </summary>
        public string CheckName { get; set; }

        /// <summary>
        /// Checks to see if the CheckName property is set.
        /// </summary>
        internal bool IsSetCheckName() => this.CheckName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        ///  The maximum number of results to return at one time. The default is 25. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  The token for the next set of results. 
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceIdentifier.
        /// </summary>
        public ResourceIdentifier ResourceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ResourceIdentifier property is set.
        /// </summary>
        internal bool IsSetResourceIdentifier() => this.ResourceIdentifier != null;
    }
}
