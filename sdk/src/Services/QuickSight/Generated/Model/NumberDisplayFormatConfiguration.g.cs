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
    /// The options that determine the number display format configuration.
    /// </summary>
    public partial class NumberDisplayFormatConfiguration
    {
        /// <summary>
        /// Gets and sets the property DecimalPlacesConfiguration. 
        /// <para>
        /// The option that determines the decimal places configuration.
        /// </para>
        /// </summary>
        public DecimalPlacesConfiguration DecimalPlacesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DecimalPlacesConfiguration property is set.
        /// </summary>
        internal bool IsSetDecimalPlacesConfiguration() => this.DecimalPlacesConfiguration != null;

        /// <summary>
        /// Gets and sets the property NegativeValueConfiguration. 
        /// <para>
        /// The options that determine the negative value configuration.
        /// </para>
        /// </summary>
        public NegativeValueConfiguration NegativeValueConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NegativeValueConfiguration property is set.
        /// </summary>
        internal bool IsSetNegativeValueConfiguration() => this.NegativeValueConfiguration != null;

        /// <summary>
        /// Gets and sets the property NullValueFormatConfiguration. 
        /// <para>
        /// The options that determine the null value format configuration.
        /// </para>
        /// </summary>
        public NullValueFormatConfiguration NullValueFormatConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NullValueFormatConfiguration property is set.
        /// </summary>
        internal bool IsSetNullValueFormatConfiguration() => this.NullValueFormatConfiguration != null;

        /// <summary>
        /// Gets and sets the property NumberScale. 
        /// <para>
        /// Determines the number scale value of the number format.
        /// </para>
        /// </summary>
        public NumberScale NumberScale { get; set; }

        /// <summary>
        /// Checks to see if the NumberScale property is set.
        /// </summary>
        internal bool IsSetNumberScale() => this.NumberScale != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// Determines the prefix value of the number format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property SeparatorConfiguration. 
        /// <para>
        /// The options that determine the numeric separator configuration.
        /// </para>
        /// </summary>
        public NumericSeparatorConfiguration SeparatorConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SeparatorConfiguration property is set.
        /// </summary>
        internal bool IsSetSeparatorConfiguration() => this.SeparatorConfiguration != null;

        /// <summary>
        /// Gets and sets the property Suffix. 
        /// <para>
        /// Determines the suffix value of the number format.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string Suffix { get; set; }

        /// <summary>
        /// Checks to see if the Suffix property is set.
        /// </summary>
        internal bool IsSetSuffix() => this.Suffix != null;
    }
}
