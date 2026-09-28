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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This contains arrays of objects, which may include CreationTimes time condition objects,
    /// FilePaths string objects, LastModificationTimes time condition objects,
    /// </summary>
    public partial class EBSItemFilter
    {
        /// <summary>
        /// Gets and sets the property CreationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<TimeCondition> CreationTimes { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeCondition>() : null;

        /// <summary>
        /// Checks to see if the CreationTimes property is set.
        /// </summary>
        internal bool IsSetCreationTimes() => this.CreationTimes != null && (this.CreationTimes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FilePaths. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one file path is included, the results will return only items that match the file
        /// path.
        /// </para>
        ///  
        /// <para>
        /// If more than one file path is included, the results will return all items that match
        /// any of the file paths.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringCondition> FilePaths { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;

        /// <summary>
        /// Checks to see if the FilePaths property is set.
        /// </summary>
        internal bool IsSetFilePaths() => this.FilePaths != null && (this.FilePaths.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastModificationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<TimeCondition> LastModificationTimes { get; set; } = AWSConfigs.InitializeCollections ? new List<TimeCondition>() : null;

        /// <summary>
        /// Checks to see if the LastModificationTimes property is set.
        /// </summary>
        internal bool IsSetLastModificationTimes() => this.LastModificationTimes != null && (this.LastModificationTimes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sizes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one is included, the results will return only items that match.
        /// </para>
        ///  
        /// <para>
        /// If more than one is included, the results will return all items that match any of
        /// the included values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<LongCondition> Sizes { get; set; } = AWSConfigs.InitializeCollections ? new List<LongCondition>() : null;

        /// <summary>
        /// Checks to see if the Sizes property is set.
        /// </summary>
        internal bool IsSetSizes() => this.Sizes != null && (this.Sizes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
