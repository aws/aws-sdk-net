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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
    /// A list of QuickSight parameters and the list's override values.
    /// </summary>
    public partial class Parameters
    {
        private List<DateTimeParameter> _dateTimeParameters = AWSConfigs.InitializeCollections ? new List<DateTimeParameter>() : null;
        private List<DecimalParameter> _decimalParameters = AWSConfigs.InitializeCollections ? new List<DecimalParameter>() : null;
        private List<IntegerParameter> _integerParameters = AWSConfigs.InitializeCollections ? new List<IntegerParameter>() : null;
        private List<StringParameter> _stringParameters = AWSConfigs.InitializeCollections ? new List<StringParameter>() : null;

        /// <summary>
        /// Gets and sets the property DateTimeParameters. 
        /// <para>
        /// The parameters that have a data type of date-time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DateTimeParameter> DateTimeParameters
        {
            get { return this._dateTimeParameters; }
            set { this._dateTimeParameters = value; }
        }

        // Check to see if DateTimeParameters property is set
        internal bool IsSetDateTimeParameters()
        {
            return this._dateTimeParameters != null && (this._dateTimeParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DecimalParameters. 
        /// <para>
        /// The parameters that have a data type of decimal.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<DecimalParameter> DecimalParameters
        {
            get { return this._decimalParameters; }
            set { this._decimalParameters = value; }
        }

        // Check to see if DecimalParameters property is set
        internal bool IsSetDecimalParameters()
        {
            return this._decimalParameters != null && (this._decimalParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerParameters. 
        /// <para>
        /// The parameters that have a data type of integer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<IntegerParameter> IntegerParameters
        {
            get { return this._integerParameters; }
            set { this._integerParameters = value; }
        }

        // Check to see if IntegerParameters property is set
        internal bool IsSetIntegerParameters()
        {
            return this._integerParameters != null && (this._integerParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringParameters. 
        /// <para>
        /// The parameters that have a data type of string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=100)]
        public List<StringParameter> StringParameters
        {
            get { return this._stringParameters; }
            set { this._stringParameters = value; }
        }

        // Check to see if StringParameters property is set
        internal bool IsSetStringParameters()
        {
            return this._stringParameters != null && (this._stringParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}