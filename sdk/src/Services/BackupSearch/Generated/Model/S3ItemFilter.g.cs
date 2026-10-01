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
    /// This contains arrays of objects, which may include ObjectKeys, Sizes, CreationTimes,
    /// VersionIds, and/or Etags.
    /// </summary>
    public partial class S3ItemFilter
    {
        /// <summary>
        /// Gets and sets the property CreationTimes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
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
        /// Gets and sets the property ETags. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringCondition> ETags { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;

        /// <summary>
        /// Checks to see if the ETags property is set.
        /// </summary>
        internal bool IsSetETags() => this.ETags != null && (this.ETags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ObjectKeys. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringCondition> ObjectKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;

        /// <summary>
        /// Checks to see if the ObjectKeys property is set.
        /// </summary>
        internal bool IsSetObjectKeys() => this.ObjectKeys != null && (this.ObjectKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sizes. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
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

        /// <summary>
        /// Gets and sets the property VersionIds. 
        /// <para>
        /// You can include 1 to 10 values.
        /// </para>
        ///  
        /// <para>
        /// If one value is included, the results will return only items that match the value.
        /// </para>
        ///  
        /// <para>
        /// If more than one value is included, the results will return all items that match any
        /// of the values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<StringCondition> VersionIds { get; set; } = AWSConfigs.InitializeCollections ? new List<StringCondition>() : null;

        /// <summary>
        /// Checks to see if the VersionIds property is set.
        /// </summary>
        internal bool IsSetVersionIds() => this.VersionIds != null && (this.VersionIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
