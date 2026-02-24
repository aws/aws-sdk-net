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
    /// Filters opportunities based on their target close date.
    /// </summary>
    public partial class TargetCloseDateFilter
    {
        private string _afterTargetCloseDate;
        private string _beforeTargetCloseDate;

        /// <summary>
        /// Gets and sets the property AfterTargetCloseDate. 
        /// <para>
        /// Filters opportunities with a target close date after this date. Use the <c>YYYY-MM-DD</c>
        /// format.
        /// </para>
        /// </summary>
        public string AfterTargetCloseDate
        {
            get { return this._afterTargetCloseDate; }
            set { this._afterTargetCloseDate = value; }
        }

        // Check to see if AfterTargetCloseDate property is set
        internal bool IsSetAfterTargetCloseDate()
        {
            return this._afterTargetCloseDate != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeTargetCloseDate. 
        /// <para>
        /// Filters opportunities with a target close date before this date. Use the <c>YYYY-MM-DD</c>
        /// format.
        /// </para>
        /// </summary>
        public string BeforeTargetCloseDate
        {
            get { return this._beforeTargetCloseDate; }
            set { this._beforeTargetCloseDate = value; }
        }

        // Check to see if BeforeTargetCloseDate property is set
        internal bool IsSetBeforeTargetCloseDate()
        {
            return this._beforeTargetCloseDate != null;
        }

    }
}