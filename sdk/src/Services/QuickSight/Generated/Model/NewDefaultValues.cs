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
    /// The configuration that overrides the existing default values for a dataset parameter
    /// that is inherited from another dataset.
    /// </summary>
    public partial class NewDefaultValues
    {
        private List<DateTime> _dateTimeStaticValues = AWSConfigs.InitializeCollections ? new List<DateTime>() : null;
        private List<double> _decimalStaticValues = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private List<long> _integerStaticValues = AWSConfigs.InitializeCollections ? new List<long>() : null;
        private List<string> _stringStaticValues = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DateTimeStaticValues. 
        /// <para>
        /// A list of static default values for a given date time parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<DateTime> DateTimeStaticValues
        {
            get { return this._dateTimeStaticValues; }
            set { this._dateTimeStaticValues = value; }
        }

        // Check to see if DateTimeStaticValues property is set
        internal bool IsSetDateTimeStaticValues()
        {
            return this._dateTimeStaticValues != null && (this._dateTimeStaticValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DecimalStaticValues. 
        /// <para>
        /// A list of static default values for a given decimal parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<double> DecimalStaticValues
        {
            get { return this._decimalStaticValues; }
            set { this._decimalStaticValues = value; }
        }

        // Check to see if DecimalStaticValues property is set
        internal bool IsSetDecimalStaticValues()
        {
            return this._decimalStaticValues != null && (this._decimalStaticValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegerStaticValues. 
        /// <para>
        /// A list of static default values for a given integer parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<long> IntegerStaticValues
        {
            get { return this._integerStaticValues; }
            set { this._integerStaticValues = value; }
        }

        // Check to see if IntegerStaticValues property is set
        internal bool IsSetIntegerStaticValues()
        {
            return this._integerStaticValues != null && (this._integerStaticValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StringStaticValues. 
        /// <para>
        /// A list of static default values for a given string parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public List<string> StringStaticValues
        {
            get { return this._stringStaticValues; }
            set { this._stringStaticValues = value; }
        }

        // Check to see if StringStaticValues property is set
        internal bool IsSetStringStaticValues()
        {
            return this._stringStaticValues != null && (this._stringStaticValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}