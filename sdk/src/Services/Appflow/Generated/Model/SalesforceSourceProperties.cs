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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The properties that are applied when Salesforce is being used as a source.
    /// </summary>
    public partial class SalesforceSourceProperties
    {
        private SalesforceDataTransferApi _dataTransferApi;
        private bool? _enableDynamicFieldUpdate;
        private bool? _includeDeletedRecords;
        private string _object;

        /// <summary>
        /// Gets and sets the property DataTransferApi. 
        /// <para>
        /// Specifies which Salesforce API is used by Amazon AppFlow when your flow transfers
        /// data from Salesforce.
        /// </para>
        ///  <dl> <dt>AUTOMATIC</dt> <dd> 
        /// <para>
        /// The default. Amazon AppFlow selects which API to use based on the number of records
        /// that your flow transfers from Salesforce. If your flow transfers fewer than 1,000,000
        /// records, Amazon AppFlow uses Salesforce REST API. If your flow transfers 1,000,000
        /// records or more, Amazon AppFlow uses Salesforce Bulk API 2.0.
        /// </para>
        ///  
        /// <para>
        /// Each of these Salesforce APIs structures data differently. If Amazon AppFlow selects
        /// the API automatically, be aware that, for recurring flows, the data output might vary
        /// from one flow run to the next. For example, if a flow runs daily, it might use REST
        /// API on one day to transfer 900,000 records, and it might use Bulk API 2.0 on the next
        /// day to transfer 1,100,000 records. For each of these flow runs, the respective Salesforce
        /// API formats the data differently. Some of the differences include how dates are formatted
        /// and null values are represented. Also, Bulk API 2.0 doesn't transfer Salesforce compound
        /// fields.
        /// </para>
        ///  
        /// <para>
        /// By choosing this option, you optimize flow performance for both small and large data
        /// transfers, but the tradeoff is inconsistent formatting in the output.
        /// </para>
        ///  </dd> <dt>BULKV2</dt> <dd> 
        /// <para>
        /// Amazon AppFlow uses only Salesforce Bulk API 2.0. This API runs asynchronous data
        /// transfers, and it's optimal for large sets of data. By choosing this option, you ensure
        /// that your flow writes consistent output, but you optimize performance only for large
        /// data transfers.
        /// </para>
        ///  
        /// <para>
        /// Note that Bulk API 2.0 does not transfer Salesforce compound fields.
        /// </para>
        ///  </dd> <dt>REST_SYNC</dt> <dd> 
        /// <para>
        /// Amazon AppFlow uses only Salesforce REST API. By choosing this option, you ensure
        /// that your flow writes consistent output, but you decrease performance for large data
        /// transfers that are better suited for Bulk API 2.0. In some cases, if your flow attempts
        /// to transfer a vary large set of data, it might fail wituh a timed out error.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public SalesforceDataTransferApi DataTransferApi
        {
            get { return this._dataTransferApi; }
            set { this._dataTransferApi = value; }
        }

        // Check to see if DataTransferApi property is set
        internal bool IsSetDataTransferApi()
        {
            return this._dataTransferApi != null;
        }

        /// <summary>
        /// Gets and sets the property EnableDynamicFieldUpdate. 
        /// <para>
        ///  The flag that enables dynamic fetching of new (recently added) fields in the Salesforce
        /// objects while running a flow. 
        /// </para>
        /// </summary>
        public bool? EnableDynamicFieldUpdate
        {
            get { return this._enableDynamicFieldUpdate; }
            set { this._enableDynamicFieldUpdate = value; }
        }

        // Check to see if EnableDynamicFieldUpdate property is set
        internal bool IsSetEnableDynamicFieldUpdate()
        {
            return this._enableDynamicFieldUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeDeletedRecords. 
        /// <para>
        ///  Indicates whether Amazon AppFlow includes deleted files in the flow run. 
        /// </para>
        /// </summary>
        public bool? IncludeDeletedRecords
        {
            get { return this._includeDeletedRecords; }
            set { this._includeDeletedRecords = value; }
        }

        // Check to see if IncludeDeletedRecords property is set
        internal bool IsSetIncludeDeletedRecords()
        {
            return this._includeDeletedRecords.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        ///  The object specified in the Salesforce flow source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

    }
}