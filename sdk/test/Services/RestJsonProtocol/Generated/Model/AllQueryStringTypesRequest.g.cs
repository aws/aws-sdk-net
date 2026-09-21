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
    /// Container for the parameters to the AllQueryStringTypes operation. This example uses
    /// all query string types.
    /// </summary>
    public partial class AllQueryStringTypesRequest : AmazonRestJsonProtocolRequest
    {
        /// <summary>
        /// Gets and sets the property QueryBoolean.
        /// </summary>
        public bool? QueryBoolean { get; set; }

        /// <summary>
        /// Checks to see if the QueryBoolean property is set.
        /// </summary>
        internal bool IsSetQueryBoolean() => this.QueryBoolean.HasValue;

        /// <summary>
        /// Gets and sets the property QueryBooleanList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<bool> QueryBooleanList { get; set; } = AWSConfigs.InitializeCollections ? new List<bool>() : null;

        /// <summary>
        /// Checks to see if the QueryBooleanList property is set.
        /// </summary>
        internal bool IsSetQueryBooleanList() => this.QueryBooleanList != null && (this.QueryBooleanList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryByte.
        /// </summary>
        public int? QueryByte { get; set; }

        /// <summary>
        /// Checks to see if the QueryByte property is set.
        /// </summary>
        internal bool IsSetQueryByte() => this.QueryByte.HasValue;

        /// <summary>
        /// Gets and sets the property QueryDouble.
        /// </summary>
        public double? QueryDouble { get; set; }

        /// <summary>
        /// Checks to see if the QueryDouble property is set.
        /// </summary>
        internal bool IsSetQueryDouble() => this.QueryDouble.HasValue;

        /// <summary>
        /// Gets and sets the property QueryDoubleList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> QueryDoubleList { get; set; } = AWSConfigs.InitializeCollections ? new List<double>() : null;

        /// <summary>
        /// Checks to see if the QueryDoubleList property is set.
        /// </summary>
        internal bool IsSetQueryDoubleList() => this.QueryDoubleList != null && (this.QueryDoubleList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryEnum.
        /// </summary>
        public FooEnum QueryEnum { get; set; }

        /// <summary>
        /// Checks to see if the QueryEnum property is set.
        /// </summary>
        internal bool IsSetQueryEnum() => this.QueryEnum != null;

        /// <summary>
        /// Gets and sets the property QueryEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryEnumList property is set.
        /// </summary>
        internal bool IsSetQueryEnumList() => this.QueryEnumList != null && (this.QueryEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryFloat.
        /// </summary>
        public float? QueryFloat { get; set; }

        /// <summary>
        /// Checks to see if the QueryFloat property is set.
        /// </summary>
        internal bool IsSetQueryFloat() => this.QueryFloat.HasValue;

        /// <summary>
        /// Gets and sets the property QueryInteger.
        /// </summary>
        public int? QueryInteger { get; set; }

        /// <summary>
        /// Checks to see if the QueryInteger property is set.
        /// </summary>
        internal bool IsSetQueryInteger() => this.QueryInteger.HasValue;

        /// <summary>
        /// Gets and sets the property QueryIntegerEnum.
        /// </summary>
        public int? QueryIntegerEnum { get; set; }

        /// <summary>
        /// Checks to see if the QueryIntegerEnum property is set.
        /// </summary>
        internal bool IsSetQueryIntegerEnum() => this.QueryIntegerEnum.HasValue;

        /// <summary>
        /// Gets and sets the property QueryIntegerEnumList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerEnumList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the QueryIntegerEnumList property is set.
        /// </summary>
        internal bool IsSetQueryIntegerEnumList() => this.QueryIntegerEnumList != null && (this.QueryIntegerEnumList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryIntegerList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerList { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the QueryIntegerList property is set.
        /// </summary>
        internal bool IsSetQueryIntegerList() => this.QueryIntegerList != null && (this.QueryIntegerList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryIntegerSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> QueryIntegerSet { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the QueryIntegerSet property is set.
        /// </summary>
        internal bool IsSetQueryIntegerSet() => this.QueryIntegerSet != null && (this.QueryIntegerSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryLong.
        /// </summary>
        public long? QueryLong { get; set; }

        /// <summary>
        /// Checks to see if the QueryLong property is set.
        /// </summary>
        internal bool IsSetQueryLong() => this.QueryLong.HasValue;

        /// <summary>
        /// Gets and sets the property QueryParamsMapOfStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, List<string>> QueryParamsMapOfStringList { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the QueryParamsMapOfStringList property is set.
        /// </summary>
        internal bool IsSetQueryParamsMapOfStringList() => this.QueryParamsMapOfStringList != null && (this.QueryParamsMapOfStringList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryShort.
        /// </summary>
        public int? QueryShort { get; set; }

        /// <summary>
        /// Checks to see if the QueryShort property is set.
        /// </summary>
        internal bool IsSetQueryShort() => this.QueryShort.HasValue;

        /// <summary>
        /// Gets and sets the property QueryString.
        /// </summary>
        public string QueryString { get; set; }

        /// <summary>
        /// Checks to see if the QueryString property is set.
        /// </summary>
        internal bool IsSetQueryString() => this.QueryString != null;

        /// <summary>
        /// Gets and sets the property QueryStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryStringList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryStringList property is set.
        /// </summary>
        internal bool IsSetQueryStringList() => this.QueryStringList != null && (this.QueryStringList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStringSet.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> QueryStringSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryStringSet property is set.
        /// </summary>
        internal bool IsSetQueryStringSet() => this.QueryStringSet != null && (this.QueryStringSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryTimestamp.
        /// </summary>
        public DateTime? QueryTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the QueryTimestamp property is set.
        /// </summary>
        internal bool IsSetQueryTimestamp() => this.QueryTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property QueryTimestampList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DateTime> QueryTimestampList { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;

        /// <summary>
        /// Checks to see if the QueryTimestampList property is set.
        /// </summary>
        internal bool IsSetQueryTimestampList() => this.QueryTimestampList != null && (this.QueryTimestampList.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
