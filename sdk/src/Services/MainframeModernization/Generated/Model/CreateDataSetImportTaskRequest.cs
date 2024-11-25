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
 * Do not modify this file. This file is generated from the m2-2021-04-28.normal.json service model.
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
namespace Amazon.MainframeModernization.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataSetImportTask operation.
    /// Starts a data set import task for a specific application.
    /// </summary>
    public partial class CreateDataSetImportTaskRequest : AmazonMainframeModernizationRequest
    {
        private string _applicationId;
        private string _clientToken;
        private DataSetImportConfig _importConfig;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The unique identifier of the application for which you want to import data sets.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  Unique, case-sensitive identifier you provide to ensure the idempotency of the request
        /// to create a data set import. The service generates the clientToken when the API call
        /// is triggered. The token expires after one hour, so if you retry the API within this
        /// timeframe with the same clientToken, you will get the same response. The service also
        /// handles deleting the clientToken after it expires. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ImportConfig. 
        /// <para>
        /// The data set import task configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSetImportConfig ImportConfig
        {
            get { return this._importConfig; }
            set { this._importConfig = value; }
        }

        // Check to see if ImportConfig property is set
        internal bool IsSetImportConfig()
        {
            return this._importConfig != null;
        }

    }
}