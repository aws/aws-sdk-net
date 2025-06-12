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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the UpdateProvisionedProductProperties operation.
    /// </summary>
    public partial class UpdateProvisionedProductPropertiesResponse : AmazonWebServiceResponse
    {
        private string _provisionedProductId;
        private Dictionary<string, string> _provisionedProductProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _recordId;
        private RecordStatus _status;

        /// <summary>
        /// Gets and sets the property ProvisionedProductId. 
        /// <para>
        /// The provisioned product identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ProvisionedProductId
        {
            get { return this._provisionedProductId; }
            set { this._provisionedProductId = value; }
        }

        // Check to see if ProvisionedProductId property is set
        internal bool IsSetProvisionedProductId()
        {
            return this._provisionedProductId != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductProperties. 
        /// <para>
        /// A map that contains the properties updated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public Dictionary<string, string> ProvisionedProductProperties
        {
            get { return this._provisionedProductProperties; }
            set { this._provisionedProductProperties = value; }
        }

        // Check to see if ProvisionedProductProperties property is set
        internal bool IsSetProvisionedProductProperties()
        {
            return this._provisionedProductProperties != null && (this._provisionedProductProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RecordId. 
        /// <para>
        /// The identifier of the record.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string RecordId
        {
            get { return this._recordId; }
            set { this._recordId = value; }
        }

        // Check to see if RecordId property is set
        internal bool IsSetRecordId()
        {
            return this._recordId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the request.
        /// </para>
        /// </summary>
        public RecordStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}