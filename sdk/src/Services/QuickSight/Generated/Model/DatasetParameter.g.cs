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
    /// A parameter that is created in a dataset. The parameter can be a string, integer,
    /// decimal, or datetime data type.
    /// </summary>
    public partial class DatasetParameter
    {
        /// <summary>
        /// Gets and sets the property DateTimeDatasetParameter. 
        /// <para>
        /// A date time parameter that is created in the dataset.
        /// </para>
        /// </summary>
        public DateTimeDatasetParameter DateTimeDatasetParameter { get; set; }

        /// <summary>
        /// Checks to see if the DateTimeDatasetParameter property is set.
        /// </summary>
        internal bool IsSetDateTimeDatasetParameter() => this.DateTimeDatasetParameter != null;

        /// <summary>
        /// Gets and sets the property DecimalDatasetParameter. 
        /// <para>
        /// A decimal parameter that is created in the dataset.
        /// </para>
        /// </summary>
        public DecimalDatasetParameter DecimalDatasetParameter { get; set; }

        /// <summary>
        /// Checks to see if the DecimalDatasetParameter property is set.
        /// </summary>
        internal bool IsSetDecimalDatasetParameter() => this.DecimalDatasetParameter != null;

        /// <summary>
        /// Gets and sets the property IntegerDatasetParameter. 
        /// <para>
        /// An integer parameter that is created in the dataset.
        /// </para>
        /// </summary>
        public IntegerDatasetParameter IntegerDatasetParameter { get; set; }

        /// <summary>
        /// Checks to see if the IntegerDatasetParameter property is set.
        /// </summary>
        internal bool IsSetIntegerDatasetParameter() => this.IntegerDatasetParameter != null;

        /// <summary>
        /// Gets and sets the property StringDatasetParameter. 
        /// <para>
        /// A string parameter that is created in the dataset.
        /// </para>
        /// </summary>
        public StringDatasetParameter StringDatasetParameter { get; set; }

        /// <summary>
        /// Checks to see if the StringDatasetParameter property is set.
        /// </summary>
        internal bool IsSetStringDatasetParameter() => this.StringDatasetParameter != null;
    }
}
