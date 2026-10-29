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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListContainerGroupDefinitions operation. <b>This
    /// API works with the following fleet types:</b> Container <para> Retrieves container
    /// group definitions for the Amazon Web Services account and Amazon Web Services Region.
    /// Use the pagination parameters to retrieve results in a set of sequential pages. </para>
    /// <para> This operation returns only the latest version of each definition. To retrieve
    /// all versions of a container group definition, use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListContainerGroupDefinitionVersions.html">ListContainerGroupDefinitionVersions</a>.
    /// </para> <para> <b>Request options:</b> </para> <ul> <li> <para> Retrieve the most
    /// recent versions of all container group definitions. </para> </li> <li> <para> Retrieve
    /// the most recent versions of all container group definitions, filtered by type. Specify
    /// the container group type to filter on. </para> </li> </ul> <para> <b>Results:</b>
    /// </para> <para> If successful, this operation returns the complete properties of a
    /// set of container group definition versions that match the request. </para> <note>
    /// <para> This operation returns the list of container group definitions in no particular
    /// order. </para> </note>
    /// </summary>
    public partial class ListContainerGroupDefinitionsRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerGroupType. 
        /// <para>
        /// The type of container group to retrieve. Container group type determines how Amazon
        /// GameLift Servers deploys the container group on each fleet instance.
        /// </para>
        /// </summary>
        public ContainerGroupType ContainerGroupType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerGroupType property is set.
        /// </summary>
        internal bool IsSetContainerGroupType() => this.ContainerGroupType != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <c>NextToken</c>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
