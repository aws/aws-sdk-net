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

namespace Amazon.GlueDataBrew.Model
{
    /// <summary>
    /// Represents a set of options that define how DataBrew selects files for a given Amazon
    /// S3 path in a dataset.
    /// </summary>
    public partial class PathOptions
    {
        /// <summary>
        /// Gets and sets the property FilesLimit. 
        /// <para>
        /// If provided, this structure imposes a limit on a number of files that should be selected.
        /// </para>
        /// </summary>
        public FilesLimit FilesLimit { get; set; }

        /// <summary>
        /// Checks to see if the FilesLimit property is set.
        /// </summary>
        internal bool IsSetFilesLimit() => this.FilesLimit != null;

        /// <summary>
        /// Gets and sets the property LastModifiedDateCondition. 
        /// <para>
        /// If provided, this structure defines a date range for matching Amazon S3 objects based
        /// on their LastModifiedDate attribute in Amazon S3.
        /// </para>
        /// </summary>
        public FilterExpression LastModifiedDateCondition { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDateCondition property is set.
        /// </summary>
        internal bool IsSetLastModifiedDateCondition() => this.LastModifiedDateCondition != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A structure that maps names of parameters used in the Amazon S3 path of a dataset
        /// to their definitions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public Dictionary<string, DatasetParameter> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DatasetParameter>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
