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
    /// A list of Quick Sight parameters and the list's override values.
    /// </summary>
    public partial class Parameters
    {
        /// <summary>
        /// Gets and sets the property DateTimeParameters. 
        /// <para>
        /// The parameters that have a data type of date-time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DateTimeParameter> DateTimeParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DateTimeParameter>() : null;

        /// <summary>
        /// Checks to see if the DateTimeParameters property is set.
        /// </summary>
        internal bool IsSetDateTimeParameters() => this.DateTimeParameters != null && (this.DateTimeParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DecimalParameters. 
        /// <para>
        /// The parameters that have a data type of decimal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<DecimalParameter> DecimalParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<DecimalParameter>() : null;

        /// <summary>
        /// Checks to see if the DecimalParameters property is set.
        /// </summary>
        internal bool IsSetDecimalParameters() => this.DecimalParameters != null && (this.DecimalParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IntegerParameters. 
        /// <para>
        /// The parameters that have a data type of integer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<IntegerParameter> IntegerParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<IntegerParameter>() : null;

        /// <summary>
        /// Checks to see if the IntegerParameters property is set.
        /// </summary>
        internal bool IsSetIntegerParameters() => this.IntegerParameters != null && (this.IntegerParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StringParameters. 
        /// <para>
        /// The parameters that have a data type of string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public List<StringParameter> StringParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<StringParameter>() : null;

        /// <summary>
        /// Checks to see if the StringParameters property is set.
        /// </summary>
        internal bool IsSetStringParameters() => this.StringParameters != null && (this.StringParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
