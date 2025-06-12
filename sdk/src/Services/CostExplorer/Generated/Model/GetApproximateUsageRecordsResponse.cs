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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// This is the response object from the GetApproximateUsageRecords operation.
    /// </summary>
    public partial class GetApproximateUsageRecordsResponse : AmazonWebServiceResponse
    {
        private DateInterval _lookbackPeriod;
        private Dictionary<string, long> _services = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;
        private long? _totalRecords;

        /// <summary>
        /// Gets and sets the property LookbackPeriod. 
        /// <para>
        /// The lookback period that's used for the estimation.
        /// </para>
        /// </summary>
        public DateInterval LookbackPeriod
        {
            get { return this._lookbackPeriod; }
            set { this._lookbackPeriod = value; }
        }

        // Check to see if LookbackPeriod property is set
        internal bool IsSetLookbackPeriod()
        {
            return this._lookbackPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property Services. 
        /// <para>
        /// The service metadata for the service or services in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, long> Services
        {
            get { return this._services; }
            set { this._services = value; }
        }

        // Check to see if Services property is set
        internal bool IsSetServices()
        {
            return this._services != null && (this._services.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalRecords. 
        /// <para>
        /// The total number of usage records for all services in the services list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? TotalRecords
        {
            get { return this._totalRecords; }
            set { this._totalRecords = value; }
        }

        // Check to see if TotalRecords property is set
        internal bool IsSetTotalRecords()
        {
            return this._totalRecords.HasValue; 
        }

    }
}