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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
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
namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Extra details specific to a data update type notification.
    /// </summary>
    public partial class DataUpdateRequestDetails
    {
        private DateTime? _dataUpdatedAt;

        /// <summary>
        /// Gets and sets the property DataUpdatedAt. 
        /// <para>
        /// A datetime in the past when the data was updated. This typically means that the underlying
        /// resource supporting the data set was updated.
        /// </para>
        /// </summary>
        public DateTime? DataUpdatedAt
        {
            get { return this._dataUpdatedAt; }
            set { this._dataUpdatedAt = value; }
        }

        // Check to see if DataUpdatedAt property is set
        internal bool IsSetDataUpdatedAt()
        {
            return this._dataUpdatedAt.HasValue; 
        }

    }
}