/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Glacier.Model
{
    /// <summary>
    /// <para>Provides options for specifying a range inventory retrieval job.</para>
    /// </summary>
    public partial class InventoryRetrievalJobInput
    {
        
        private string startDate;
        private string endDate;
        private string limit;
        private string marker;

        /// <summary>
        /// The start of the date range in UTC for vault inventory retrieval that includes archives created on or after this date. A string
        /// representation of ISO 8601 date format, for example, 2013-03-20T17:03:43Z.
        ///  
        /// </summary>
        public string StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        /// <summary>
        /// Sets the StartDate property
        /// </summary>
        /// <param name="startDate">The value to set for the StartDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InventoryRetrievalJobInput WithStartDate(string startDate)
        {
            this.startDate = startDate;
            return this;
        }
            

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this.startDate != null;
        }

        /// <summary>
        /// The end of the date range in UTC for vault inventory retrieval that includes archives created before this date. A string representation of
        /// ISO 8601 date format, for example, 2013-03-20T17:03:43Z.
        ///  
        /// </summary>
        public string EndDate
        {
            get { return this.endDate; }
            set { this.endDate = value; }
        }

        /// <summary>
        /// Sets the EndDate property
        /// </summary>
        /// <param name="endDate">The value to set for the EndDate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InventoryRetrievalJobInput WithEndDate(string endDate)
        {
            this.endDate = endDate;
            return this;
        }
            

        // Check to see if EndDate property is set
        internal bool IsSetEndDate()
        {
            return this.endDate != null;
        }

        /// <summary>
        /// Specifies the maximum number of inventory items returned per vault inventory retrieval request. Valid values are greater than or equal to 1.
        ///  
        /// </summary>
        public string Limit
        {
            get { return this.limit; }
            set { this.limit = value; }
        }

        /// <summary>
        /// Sets the Limit property
        /// </summary>
        /// <param name="limit">The value to set for the Limit property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InventoryRetrievalJobInput WithLimit(string limit)
        {
            this.limit = limit;
            return this;
        }
            

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this.limit != null;
        }

        /// <summary>
        /// An opaque string that represents where to continue pagination of the vault inventory retrieval results. You use the marker in a new
        /// <b>InitiateJob</b> request to obtain additional inventory items. If there are no more inventory items, this value is <c>null</c>.
        ///  
        /// </summary>
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public InventoryRetrievalJobInput WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;
        }
    }
}
