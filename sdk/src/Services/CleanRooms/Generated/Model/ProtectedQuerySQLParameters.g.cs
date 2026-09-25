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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The parameters for the SQL type Protected Query.
    /// </summary>
    public partial class ProtectedQuerySQLParameters
    {
        /// <summary>
        /// Gets and sets the property AnalysisTemplateArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) associated with the analysis template within a collaboration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string AnalysisTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisTemplateArn property is set.
        /// </summary>
        internal bool IsSetAnalysisTemplateArn() => this.AnalysisTemplateArn != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The protected query SQL parameters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string to be submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 500000)]
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;
    }
}
