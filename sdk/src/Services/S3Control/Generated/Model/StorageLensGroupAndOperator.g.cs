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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// A logical operator that allows multiple filter conditions to be joined for more complex
    /// comparisons of Storage Lens group data.
    /// </summary>
    public partial class StorageLensGroupAndOperator
    {
        /// <summary>
        /// Gets and sets the property MatchAnyPrefix. 
        /// <para>
        ///  Contains a list of prefixes. At least one prefix must be specified. Up to 10 prefixes
        /// are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnyPrefix { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnyPrefix property is set.
        /// </summary>
        internal bool IsSetMatchAnyPrefix() => this.MatchAnyPrefix != null && (this.MatchAnyPrefix.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchAnySuffix. 
        /// <para>
        ///  Contains a list of suffixes. At least one suffix must be specified. Up to 10 suffixes
        /// are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> MatchAnySuffix { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MatchAnySuffix property is set.
        /// </summary>
        internal bool IsSetMatchAnySuffix() => this.MatchAnySuffix != null && (this.MatchAnySuffix.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchAnyTag. 
        /// <para>
        ///  Contains the list of object tags. At least one object tag must be specified. Up to
        /// 10 object tags are allowed. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<S3Tag> MatchAnyTag { get; set; } = AWSConfigs.InitializeCollections ? new List<S3Tag>() : null;

        /// <summary>
        /// Checks to see if the MatchAnyTag property is set.
        /// </summary>
        internal bool IsSetMatchAnyTag() => this.MatchAnyTag != null && (this.MatchAnyTag.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MatchObjectAge. 
        /// <para>
        ///  Contains <c>DaysGreaterThan</c> and <c>DaysLessThan</c> to define the object age
        /// range (minimum and maximum number of days). 
        /// </para>
        /// </summary>
        public MatchObjectAge MatchObjectAge { get; set; }

        /// <summary>
        /// Checks to see if the MatchObjectAge property is set.
        /// </summary>
        internal bool IsSetMatchObjectAge() => this.MatchObjectAge != null;

        /// <summary>
        /// Gets and sets the property MatchObjectSize. 
        /// <para>
        ///  Contains <c>BytesGreaterThan</c> and <c>BytesLessThan</c> to define the object size
        /// range (minimum and maximum number of Bytes). 
        /// </para>
        /// </summary>
        public MatchObjectSize MatchObjectSize { get; set; }

        /// <summary>
        /// Checks to see if the MatchObjectSize property is set.
        /// </summary>
        internal bool IsSetMatchObjectSize() => this.MatchObjectSize != null;
    }
}
