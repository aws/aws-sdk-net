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
    /// Container for the parameters to the GetParametersByPath operation. Retrieve information
    /// about one or more parameters under a specified level in a hierarchy. <para> Request
    /// results are returned on a best-effort basis. If you specify <c>MaxResults</c> in the
    /// request, the response includes information up to the limit specified. The number of
    /// items returned, however, can be between zero and the value of <c>MaxResults</c>. If
    /// the service reaches an internal limit while processing the results, it stops the operation
    /// and returns the matching values up to that point and a <c>NextToken</c>. You can specify
    /// the <c>NextToken</c> in a subsequent call to get the next set of results. </para>
    /// <para> Parameter names can't contain spaces. The service removes any spaces specified
    /// for the beginning or end of a parameter name. If the specified name for a parameter
    /// contains spaces between characters, the request fails with a <c>ValidationException</c>
    /// error. </para>
    /// </summary>
    public partial class GetParametersByPathRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to start the list. Use this token to get the next set of results. 
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
        ///  <note> 
        /// <para>
        /// The following <c>Key</c> values are supported for <c>GetParametersByPath</c>: <c>Type</c>,
        /// <c>KeyId</c>, and <c>Label</c>.
        /// </para>
        ///  
        /// <para>
        /// The following <c>Key</c> values aren't supported for <c>GetParametersByPath</c>: <c>tag</c>,
        /// <c>DataType</c>, <c>Name</c>, <c>Path</c>, and <c>Tier</c>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property Path. 
        /// <para>
        /// The hierarchy for the parameter. Hierarchies start with a forward slash (/). The hierarchy
        /// is the parameter name except the last part of the parameter. For the API call to succeed,
        /// the last part of the parameter name can't be in the path. A parameter name hierarchy
        /// can have a maximum of 15 levels. Here is an example of a hierarchy: <c>/Finance/Prod/IAD/WinServ2016/license33
        /// </c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// Retrieve all parameters within a hierarchy.
        /// </para>
        ///  <important> 
        /// <para>
        /// If a user has access to a path, then the user can access all levels of that path.
        /// For example, if a user has permission to access path <c>/a</c>, then the user can
        /// also access <c>/a/b</c>. Even if a user has explicitly been denied access in IAM for
        /// parameter <c>/a/b</c>, they can still call the GetParametersByPath API operation recursively
        /// for <c>/a</c> and view <c>/a/b</c>.
        /// </para>
        ///  </important>
        /// </summary>
        public bool? Recursive { get; set; }

        /// <summary>
        /// Checks to see if the Recursive property is set.
        /// </summary>
        internal bool IsSetRecursive() => this.Recursive.HasValue;

        /// <summary>
        /// Gets and sets the property WithDecryption. 
        /// <para>
        /// Retrieve all parameters in a hierarchy with their value decrypted.
        /// </para>
        /// </summary>
        public bool? WithDecryption { get; set; }

        /// <summary>
        /// Checks to see if the WithDecryption property is set.
        /// </summary>
        internal bool IsSetWithDecryption() => this.WithDecryption.HasValue;
    }
}
