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

namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// This is the response object from the InputAndOutputWithHeaders operation.
    /// </summary>
    public partial class InputAndOutputWithHeadersResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HeaderBooleanList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> HeaderBooleanList { get; set; } = AWSConfigs.InitializeCollections ? new List<bool>() : null;

        /// <summary>
        /// Checks to see if the HeaderBooleanList property is set.
        /// </summary>
        internal bool IsSetHeaderBooleanList() => this.HeaderBooleanList != null && (this.HeaderBooleanList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderByte.
        /// </summary>
        public int? HeaderByte { get; set; }

        /// <summary>
        /// Checks to see if the HeaderByte property is set.
        /// </summary>
        internal bool IsSetHeaderByte() => this.HeaderByte.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderDouble.
        /// </summary>
        public double? HeaderDouble { get; set; }

        /// <summary>
        /// Checks to see if the HeaderDouble property is set.
        /// </summary>
        internal bool IsSetHeaderDouble() => this.HeaderDouble.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderEnum.
        /// </summary>
        public FooEnum HeaderEnum { get; set; }

        /// <summary>
        /// Checks to see if the HeaderEnum property is set.
        /// </summary>
        internal bool IsSetHeaderEnum() => this.HeaderEnum != null;

        /// <summary>
        /// Gets and sets the property HeaderEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HeaderEnumList property is set.
        /// </summary>
        internal bool IsSetHeaderEnumList() => this.HeaderEnumList != null && (this.HeaderEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderFalseBool.
        /// </summary>
        public bool? HeaderFalseBool { get; set; }

        /// <summary>
        /// Checks to see if the HeaderFalseBool property is set.
        /// </summary>
        internal bool IsSetHeaderFalseBool() => this.HeaderFalseBool.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderFloat.
        /// </summary>
        public float? HeaderFloat { get; set; }

        /// <summary>
        /// Checks to see if the HeaderFloat property is set.
        /// </summary>
        internal bool IsSetHeaderFloat() => this.HeaderFloat.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderInteger.
        /// </summary>
        public int? HeaderInteger { get; set; }

        /// <summary>
        /// Checks to see if the HeaderInteger property is set.
        /// </summary>
        internal bool IsSetHeaderInteger() => this.HeaderInteger.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderIntegerEnum.
        /// </summary>
        public int? HeaderIntegerEnum { get; set; }

        /// <summary>
        /// Checks to see if the HeaderIntegerEnum property is set.
        /// </summary>
        internal bool IsSetHeaderIntegerEnum() => this.HeaderIntegerEnum.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderIntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HeaderIntegerEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the HeaderIntegerEnumList property is set.
        /// </summary>
        internal bool IsSetHeaderIntegerEnumList() => this.HeaderIntegerEnumList != null && (this.HeaderIntegerEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> HeaderIntegerList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the HeaderIntegerList property is set.
        /// </summary>
        internal bool IsSetHeaderIntegerList() => this.HeaderIntegerList != null && (this.HeaderIntegerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderLong.
        /// </summary>
        public long? HeaderLong { get; set; }

        /// <summary>
        /// Checks to see if the HeaderLong property is set.
        /// </summary>
        internal bool IsSetHeaderLong() => this.HeaderLong.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderShort.
        /// </summary>
        public int? HeaderShort { get; set; }

        /// <summary>
        /// Checks to see if the HeaderShort property is set.
        /// </summary>
        internal bool IsSetHeaderShort() => this.HeaderShort.HasValue;

        /// <summary>
        /// Gets and sets the property HeaderString.
        /// </summary>
        public string HeaderString { get; set; }

        /// <summary>
        /// Checks to see if the HeaderString property is set.
        /// </summary>
        internal bool IsSetHeaderString() => this.HeaderString != null;

        /// <summary>
        /// Gets and sets the property HeaderStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderStringList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HeaderStringList property is set.
        /// </summary>
        internal bool IsSetHeaderStringList() => this.HeaderStringList != null && (this.HeaderStringList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderStringSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> HeaderStringSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HeaderStringSet property is set.
        /// </summary>
        internal bool IsSetHeaderStringSet() => this.HeaderStringSet != null && (this.HeaderStringSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderTimestampList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> HeaderTimestampList { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the HeaderTimestampList property is set.
        /// </summary>
        internal bool IsSetHeaderTimestampList() => this.HeaderTimestampList != null && (this.HeaderTimestampList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HeaderTrueBool.
        /// </summary>
        public bool? HeaderTrueBool { get; set; }

        /// <summary>
        /// Checks to see if the HeaderTrueBool property is set.
        /// </summary>
        internal bool IsSetHeaderTrueBool() => this.HeaderTrueBool.HasValue;
    }
}
