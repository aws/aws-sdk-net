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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Filter for opportunities based on creation date range.
    /// </summary>
    public partial class CreatedDateFilter
    {
        private DateTime? _afterCreatedDate;
        private DateTime? _beforeCreatedDate;

        /// <summary>
        /// Gets and sets the property AfterCreatedDate. 
        /// <para>
        /// Filter opportunities created after this date.
        /// </para>
        /// </summary>
        public DateTime AfterCreatedDate
        {
            get { return this._afterCreatedDate.GetValueOrDefault(); }
            set { this._afterCreatedDate = value; }
        }

        // Check to see if AfterCreatedDate property is set
        internal bool IsSetAfterCreatedDate()
        {
            return this._afterCreatedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeCreatedDate. 
        /// <para>
        /// Filter opportunities created before this date.
        /// </para>
        /// </summary>
        public DateTime BeforeCreatedDate
        {
            get { return this._beforeCreatedDate.GetValueOrDefault(); }
            set { this._beforeCreatedDate = value; }
        }

        // Check to see if BeforeCreatedDate property is set
        internal bool IsSetBeforeCreatedDate()
        {
            return this._beforeCreatedDate.HasValue; 
        }

    }
}