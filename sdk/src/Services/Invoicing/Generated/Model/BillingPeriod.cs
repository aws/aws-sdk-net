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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// The billing period for which you want to retrieve invoice-related documents.
    /// </summary>
    public partial class BillingPeriod
    {
        private int? _month;
        private int? _year;

        /// <summary>
        /// Gets and sets the property Month. 
        /// <para>
        ///  The billing period month. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=12)]
        public int? Month
        {
            get { return this._month; }
            set { this._month = value; }
        }

        // Check to see if Month property is set
        internal bool IsSetMonth()
        {
            return this._month.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Year. 
        /// <para>
        ///  The billing period year. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2005, Max=2050)]
        public int? Year
        {
            get { return this._year; }
            set { this._year = value; }
        }

        // Check to see if Year property is set
        internal bool IsSetYear()
        {
            return this._year.HasValue; 
        }

    }
}