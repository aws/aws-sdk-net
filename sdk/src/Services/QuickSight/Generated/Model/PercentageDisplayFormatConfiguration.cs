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
    /// The options that determine the percentage display format configuration.
    /// </summary>
    public partial class PercentageDisplayFormatConfiguration
    {
        private DecimalPlacesConfiguration _decimalPlacesConfiguration;
        private NegativeValueConfiguration _negativeValueConfiguration;
        private NullValueFormatConfiguration _nullValueFormatConfiguration;
        private string _prefix;
        private NumericSeparatorConfiguration _separatorConfiguration;
        private string _suffix;

        /// <summary>
        /// Gets and sets the property DecimalPlacesConfiguration. 
        /// <para>
        /// The option that determines the decimal places configuration.
        /// </para>
        /// </summary>
        public DecimalPlacesConfiguration DecimalPlacesConfiguration
        {
            get { return this._decimalPlacesConfiguration; }
            set { this._decimalPlacesConfiguration = value; }
        }

        // Check to see if DecimalPlacesConfiguration property is set
        internal bool IsSetDecimalPlacesConfiguration()
        {
            return this._decimalPlacesConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NegativeValueConfiguration. 
        /// <para>
        /// The options that determine the negative value configuration.
        /// </para>
        /// </summary>
        public NegativeValueConfiguration NegativeValueConfiguration
        {
            get { return this._negativeValueConfiguration; }
            set { this._negativeValueConfiguration = value; }
        }

        // Check to see if NegativeValueConfiguration property is set
        internal bool IsSetNegativeValueConfiguration()
        {
            return this._negativeValueConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NullValueFormatConfiguration. 
        /// <para>
        /// The options that determine the null value format configuration.
        /// </para>
        /// </summary>
        public NullValueFormatConfiguration NullValueFormatConfiguration
        {
            get { return this._nullValueFormatConfiguration; }
            set { this._nullValueFormatConfiguration = value; }
        }

        // Check to see if NullValueFormatConfiguration property is set
        internal bool IsSetNullValueFormatConfiguration()
        {
            return this._nullValueFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Determines the prefix value of the percentage format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property SeparatorConfiguration. 
        /// <para>
        /// The options that determine the numeric separator configuration.
        /// </para>
        /// </summary>
        public NumericSeparatorConfiguration SeparatorConfiguration
        {
            get { return this._separatorConfiguration; }
            set { this._separatorConfiguration = value; }
        }

        // Check to see if SeparatorConfiguration property is set
        internal bool IsSetSeparatorConfiguration()
        {
            return this._separatorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// Determines the suffix value of the percentage format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string Suffix
        {
            get { return this._suffix; }
            set { this._suffix = value; }
        }

        // Check to see if Suffix property is set
        internal bool IsSetSuffix()
        {
            return this._suffix != null;
        }

    }
}