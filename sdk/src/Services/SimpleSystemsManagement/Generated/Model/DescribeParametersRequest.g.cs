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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeParameters operation. Lists the parameters
    /// in your Amazon Web Services account or the parameters shared with you when you enable
    /// the <a href="https://docs.aws.amazon.com/systems-manager/latest/APIReference/API_DescribeParameters.html#systemsmanager-DescribeParameters-request-Shared">Shared</a>
    /// option. <para> Request results are returned on a best-effort basis. If you specify
    /// <c>MaxResults</c> in the request, the response includes information up to the limit
    /// specified. The number of items returned, however, can be between zero and the value
    /// of <c>MaxResults</c>. If the service reaches an internal limit while processing the
    /// results, it stops the operation and returns the matching values up to that point and
    /// a <c>NextToken</c>. You can specify the <c>NextToken</c> in a subsequent call to get
    /// the next set of results. </para> <para> Parameter names can't contain spaces. The
    /// service removes any spaces specified for the beginning or end of a parameter name.
    /// If the specified name for a parameter contains spaces between characters, the request
    /// fails with a <c>ValidationException</c> error. </para> <important> <para> If you change
    /// the KMS key alias for the KMS key used to encrypt a parameter, then you must also
    /// update the key alias the parameter uses to reference KMS. Otherwise, <c>DescribeParameters</c>
    /// retrieves whatever the original key alias was referencing. </para> </important>
    /// </summary>
    public partial class DescribeParametersRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// This data type is deprecated. Instead, use <c>ParameterFilters</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParametersFilter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<ParametersFilter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ParameterFilters. 
        /// <para>
        /// Filters to limit the request results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ParameterStringFilter> ParameterFilters { get; set; } = AWSConfigs.InitializeCollections ? new List<ParameterStringFilter>() : null;

        /// <summary>
        /// Checks to see if the ParameterFilters property is set.
        /// </summary>
        internal bool IsSetParameterFilters() => this.ParameterFilters != null && (this.ParameterFilters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Shared. 
        /// <para>
        /// Lists parameters that are shared with you.
        /// </para>
        ///  <note> 
        /// <para>
        /// By default when using this option, the command returns parameters that have been shared
        /// using a standard Resource Access Manager Resource Share. In order for a parameter
        /// that was shared using the <a>PutResourcePolicy</a> command to be returned, the associated
        /// <c>RAM Resource Share Created From Policy</c> must have been promoted to a standard
        /// Resource Share using the RAM <a href="https://docs.aws.amazon.com/ram/latest/APIReference/API_PromoteResourceShareCreatedFromPolicy.html">PromoteResourceShareCreatedFromPolicy</a>
        /// API operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about sharing parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/parameter-store-shared-parameters.html">Working
        /// with shared parameters</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Shared { get; set; }

        /// <summary>
        /// Checks to see if the Shared property is set.
        /// </summary>
        internal bool IsSetShared() => this.Shared.HasValue;
    }
}
