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

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListBuildsForProject operation. Gets a list of
    /// build identifiers for the specified build project, with each build identifier representing
    /// a single build.
    /// </summary>
    public partial class ListBuildsForProjectRequest : AmazonCodeBuildRequest
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// During a previous call, if there are more than 100 items in the list, only the first
        /// 100 items are returned, along with a unique string called a <i>nextToken</i>. To get
        /// the next batch of items in the list, call this operation again, adding the next token
        /// to the call. To get all of the items in the list, keep calling this operation with
        /// each subsequent next token that is returned, until no more next tokens are returned.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the CodeBuild project.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Checks to see if the ProjectName property is set.
        /// </summary>
        internal bool IsSetProjectName() => this.ProjectName != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order to sort the results in. The results are sorted by build number, not the
        /// build identifier. If this is not specified, the results are sorted in descending order.
        /// </para>
        ///  
        /// <para>
        /// Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ASCENDING</c>: List the build identifiers in ascending order, by build number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DESCENDING</c>: List the build identifiers in descending order, by build number.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the project has more than 100 builds, setting the sort order will result in an
        /// error. 
        /// </para>
        /// </summary>
        public SortOrderType SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
