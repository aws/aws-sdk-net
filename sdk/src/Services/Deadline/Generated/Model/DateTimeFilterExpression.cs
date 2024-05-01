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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
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
namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The time stamp in date-time format.
    /// </summary>
    public partial class DateTimeFilterExpression
    {
        private DateTime? _dateTime;
        private string _name;
        private ComparisonOperator _operator;

        /// <summary>
        /// Gets and sets the property DateTime. 
        /// <para>
        /// The date and time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? DateTime
        {
            get { return this._dateTime; }
            set { this._dateTime = value; }
        }

        // Check to see if DateTime property is set
        internal bool IsSetDateTime()
        {
            return this._dateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the date-time field to filter on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The type of comparison to use to filter the results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ComparisonOperator Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
        }

    }
}