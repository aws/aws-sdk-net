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

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePrincipalMapping operation. Describes
    /// the processing of <c>PUT</c> and <c>DELETE</c> actions for mapping users to their
    /// groups. This includes information on the status of actions currently processing or
    /// yet to be processed, when actions were last updated, when actions were received by
    /// Amazon Kendra, the latest action that should process and apply after other actions,
    /// and useful error messages if an action could not be processed. <para> <c>DescribePrincipalMapping</c>
    /// is currently not supported in the Amazon Web Services GovCloud (US-West) region. </para>
    /// </summary>
    public partial class DescribePrincipalMappingRequest : AmazonKendraRequest
    {
        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The identifier of the data source to check the processing of <c>PUT</c> and <c>DELETE</c>
        /// actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The identifier of the group required to check the processing of <c>PUT</c> and <c>DELETE</c>
        /// actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string GroupId { get; set; }

        /// <summary>
        /// Checks to see if the GroupId property is set.
        /// </summary>
        internal bool IsSetGroupId() => this.GroupId != null;

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index required to check the processing of <c>PUT</c> and <c>DELETE</c>
        /// actions for mapping users to their groups.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string IndexId { get; set; }

        /// <summary>
        /// Checks to see if the IndexId property is set.
        /// </summary>
        internal bool IsSetIndexId() => this.IndexId != null;
    }
}
