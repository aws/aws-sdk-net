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
 * Do not modify this file. This file is generated from the personalize-2018-05-22.normal.json service model.
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
namespace Amazon.Personalize.Model
{
    /// <summary>
    /// The training data configuration to use when creating a domain recommender or custom
    /// solution version (trained model).
    /// </summary>
    public partial class TrainingDataConfig
    {
        private Dictionary<string, List<string>> _excludedDatasetColumns = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;
        private Dictionary<string, List<string>> _includedDatasetColumns = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Gets and sets the property ExcludedDatasetColumns. 
        /// <para>
        /// Specifies the columns to exclude from training. Each key is a dataset type, and each
        /// value is a list of columns. Exclude columns to control what data Amazon Personalize
        /// uses to generate recommendations.
        /// </para>
        ///  
        /// <para>
        ///  For example, you might have a column that you want to use only to filter recommendations.
        /// You can exclude this column from training and Amazon Personalize considers it only
        /// when filtering. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public Dictionary<string, List<string>> ExcludedDatasetColumns
        {
            get { return this._excludedDatasetColumns; }
            set { this._excludedDatasetColumns = value; }
        }

        // Check to see if ExcludedDatasetColumns property is set
        internal bool IsSetExcludedDatasetColumns()
        {
            return this._excludedDatasetColumns != null && (this._excludedDatasetColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IncludedDatasetColumns. 
        /// <para>
        /// A map that specifies which columns to include from each dataset during training. The
        /// map can contain up to 3 entries, where each key is a dataset name (maximum length
        /// of 256 characters, must contain only letters and underscores) and each value is an
        /// array of up to 50 column names. Column names can be up to 150 characters long, must
        /// start with a letter or underscore, and can contain only letters, numbers, and underscores.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public Dictionary<string, List<string>> IncludedDatasetColumns
        {
            get { return this._includedDatasetColumns; }
            set { this._includedDatasetColumns = value; }
        }

        // Check to see if IncludedDatasetColumns property is set
        internal bool IsSetIncludedDatasetColumns()
        {
            return this._includedDatasetColumns != null && (this._includedDatasetColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}