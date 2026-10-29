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
    /// Container for the parameters to the ListPolicyPrincipals operation. Lists the principals
    /// associated with the specified policy. <para> <b>Note:</b> This action is deprecated
    /// and works as expected for backward compatibility, but we won't add enhancements. Use
    /// <a>ListTargetsForPolicy</a> instead. </para> <para> Requires permission to access
    /// the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">ListPolicyPrincipals</a>
    /// action. </para>
    /// </summary>
    public partial class ListPolicyPrincipalsRequest : AmazonIoTRequest
    {
        /// <summary>
        /// Gets and sets the property AscendingOrder. 
        /// <para>
        /// Specifies the order for results. If true, the results are returned in ascending creation
        /// order.
        /// </para>
        /// </summary>
        public bool? AscendingOrder { get; set; }

        /// <summary>
        /// Checks to see if the AscendingOrder property is set.
        /// </summary>
        internal bool IsSetAscendingOrder() => this.AscendingOrder.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The result page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 250)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The policy name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
