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
    /// Defines a filter to retrieve opportunities based on the last modified date. This filter
    /// is useful for tracking changes or updates to opportunities over time.
    /// </summary>
    public partial class LastModifiedDate
    {
        private DateTime? _afterLastModifiedDate;
        private DateTime? _beforeLastModifiedDate;

        /// <summary>
        /// Gets and sets the property AfterLastModifiedDate. 
        /// <para>
        /// Specifies the date after which the opportunities were modified. Use this filter to
        /// retrieve only those opportunities that were modified after a given timestamp.
        /// </para>
        /// </summary>
        public DateTime? AfterLastModifiedDate
        {
            get { return this._afterLastModifiedDate; }
            set { this._afterLastModifiedDate = value; }
        }

        // Check to see if AfterLastModifiedDate property is set
        internal bool IsSetAfterLastModifiedDate()
        {
            return this._afterLastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeLastModifiedDate. 
        /// <para>
        /// Specifies the date before which the opportunities were modified. Use this filter to
        /// retrieve only those opportunities that were modified before a given timestamp.
        /// </para>
        /// </summary>
        public DateTime? BeforeLastModifiedDate
        {
            get { return this._beforeLastModifiedDate; }
            set { this._beforeLastModifiedDate = value; }
        }

        // Check to see if BeforeLastModifiedDate property is set
        internal bool IsSetBeforeLastModifiedDate()
        {
            return this._beforeLastModifiedDate.HasValue; 
        }

    }
}