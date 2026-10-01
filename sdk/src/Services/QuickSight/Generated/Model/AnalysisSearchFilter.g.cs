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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A filter that you apply when searching for one or more analyses.
    /// </summary>
    public partial class AnalysisSearchFilter
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the value that you want to use as a filter, for example <c>"Name": "QUICKSIGHT_OWNER"</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>QUICKSIGHT_VIEWER_OR_OWNER</c>: Provide an ARN of a user or group, and any analyses
        /// with that ARN listed as one of the analysis' owners or viewers are returned. Implicit
        /// permissions from folders or groups are considered. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUICKSIGHT_OWNER</c>: Provide an ARN of a user or group, and any analyses with
        /// that ARN listed as one of the owners of the analyses are returned. Implicit permissions
        /// from folders or groups are considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECT_QUICKSIGHT_SOLE_OWNER</c>: Provide an ARN of a user or group, and any analyses
        /// with that ARN listed as the only owner of the analysis are returned. Implicit permissions
        /// from folders or groups are not considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECT_QUICKSIGHT_OWNER</c>: Provide an ARN of a user or group, and any analyses
        /// with that ARN listed as one of the owners of the analyses are returned. Implicit permissions
        /// from folders or groups are not considered.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DIRECT_QUICKSIGHT_VIEWER_OR_OWNER</c>: Provide an ARN of a user or group, and
        /// any analyses with that ARN listed as one of the owners or viewers of the analyses
        /// are returned. Implicit permissions from folders or groups are not considered. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ANALYSIS_NAME</c>: Any analyses whose names have a substring match to this value
        /// will be returned.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AnalysisFilterAttribute Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator that you want to use as a filter, for example <c>"Operator":
        /// "StringEquals"</c>. Valid values are <c>"StringEquals"</c> and <c>"StringLike"</c>.
        /// </para>
        ///  
        /// <para>
        /// If you set the operator value to <c>"StringEquals"</c>, you need to provide an ownership
        /// related filter in the <c>"NAME"</c> field and the arn of the user or group whose folders
        /// you want to search in the <c>"Value"</c> field. For example, <c>"Name":"DIRECT_QUICKSIGHT_OWNER",
        /// "Operator": "StringEquals", "Value": "arn:aws:quicksight:us-east-1:1:user/default/UserName1"</c>.
        /// </para>
        ///  
        /// <para>
        /// If you set the value to <c>"StringLike"</c>, you need to provide the name of the folders
        /// you are searching for. For example, <c>"Name":"ANALYSIS_NAME", "Operator": "StringLike",
        /// "Value": "Test"</c>. The <c>"StringLike"</c> operator only supports the <c>NAME</c>
        /// value <c>ANALYSIS_NAME</c>.
        /// </para>
        /// </summary>
        public FilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the named item, in this case <c>QUICKSIGHT_USER</c>, that you want to
        /// use as a filter, for example <c>"Value"</c>. An example is <c>"arn:aws:quicksight:us-east-1:1:user/default/UserName1"</c>.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
