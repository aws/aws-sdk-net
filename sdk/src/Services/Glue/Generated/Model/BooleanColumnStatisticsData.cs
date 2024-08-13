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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines column statistics supported for Boolean data columns.
    /// </summary>
    public partial class BooleanColumnStatisticsData
    {
        private long? _numberOfFalses;
        private long? _numberOfNulls;
        private long? _numberOfTrues;

        /// <summary>
        /// Gets and sets the property NumberOfFalses. 
        /// <para>
        /// The number of false values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? NumberOfFalses
        {
            get { return this._numberOfFalses; }
            set { this._numberOfFalses = value; }
        }

        // Check to see if NumberOfFalses property is set
        internal bool IsSetNumberOfFalses()
        {
            return this._numberOfFalses.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfNulls. 
        /// <para>
        /// The number of null values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? NumberOfNulls
        {
            get { return this._numberOfNulls; }
            set { this._numberOfNulls = value; }
        }

        // Check to see if NumberOfNulls property is set
        internal bool IsSetNumberOfNulls()
        {
            return this._numberOfNulls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfTrues. 
        /// <para>
        /// The number of true values in the column.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? NumberOfTrues
        {
            get { return this._numberOfTrues; }
            set { this._numberOfTrues = value; }
        }

        // Check to see if NumberOfTrues property is set
        internal bool IsSetNumberOfTrues()
        {
            return this._numberOfTrues.HasValue; 
        }

    }
}