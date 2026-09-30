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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeCanaries operation. This operation returns
    /// a list of the canaries in your account, along with full details about each canary.
    /// <para> This operation supports resource-level authorization using an IAM policy and
    /// the <c>Names</c> parameter. If you specify the <c>Names</c> parameter, the operation
    /// is successful only if you have authorization to view all the canaries that you specify
    /// in your request. If you do not have permission to view any of the canaries, the request
    /// fails with a 403 response. </para> <para> You are required to use the <c>Names</c>
    /// parameter if you are logged on to a user or role that has an IAM policy that restricts
    /// which canaries that you are allowed to view. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
    /// Limiting a user to viewing specific canaries</a>. </para>
    /// </summary>
    public partial class DescribeCanariesRequest : AmazonSyntheticsRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specify this parameter to limit how many canaries are returned each time you use the
        /// <c>DescribeCanaries</c> operation. If you omit this parameter, the default of 20 is
        /// used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Use this parameter to return only canaries that match the names that you specify here.
        /// You can specify as many as five canary names.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter, the operation is successful only if you have authorization
        /// to view all the canaries that you specify in your request. If you do not have permission
        /// to view any of the canaries, the request fails with a 403 response.
        /// </para>
        ///  
        /// <para>
        /// You are required to use this parameter if you are logged on to a user or role that
        /// has an IAM policy that restricts which canaries that you are allowed to view. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Restricted.html">
        /// Limiting a user to viewing specific canaries</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<string> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there is more data available. You can use this token in
        /// a subsequent operation to retrieve the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 4, Max = 252)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
