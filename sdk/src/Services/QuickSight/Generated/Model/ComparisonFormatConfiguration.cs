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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The format of the comparison.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class ComparisonFormatConfiguration
    {
        private NumberDisplayFormatConfiguration _numberDisplayFormatConfiguration;
        private PercentageDisplayFormatConfiguration _percentageDisplayFormatConfiguration;

        /// <summary>
        /// Gets and sets the property NumberDisplayFormatConfiguration. 
        /// <para>
        /// The number display format.
        /// </para>
        /// </summary>
        public NumberDisplayFormatConfiguration NumberDisplayFormatConfiguration
        {
            get { return this._numberDisplayFormatConfiguration; }
            set { this._numberDisplayFormatConfiguration = value; }
        }

        // Check to see if NumberDisplayFormatConfiguration property is set
        internal bool IsSetNumberDisplayFormatConfiguration()
        {
            return this._numberDisplayFormatConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property PercentageDisplayFormatConfiguration. 
        /// <para>
        /// The percentage display format.
        /// </para>
        /// </summary>
        public PercentageDisplayFormatConfiguration PercentageDisplayFormatConfiguration
        {
            get { return this._percentageDisplayFormatConfiguration; }
            set { this._percentageDisplayFormatConfiguration = value; }
        }

        // Check to see if PercentageDisplayFormatConfiguration property is set
        internal bool IsSetPercentageDisplayFormatConfiguration()
        {
            return this._percentageDisplayFormatConfiguration != null;
        }

    }
}