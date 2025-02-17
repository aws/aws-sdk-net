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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// This is the response object from the GetTableMaintenanceConfiguration operation.
    /// </summary>
    public partial class GetTableMaintenanceConfigurationResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, TableMaintenanceConfigurationValue> _configuration = AWSConfigs.InitializeCollections ? new Dictionary<string, TableMaintenanceConfigurationValue>() : null;
        private string _tablearn;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Details about the maintenance configuration for the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, TableMaintenanceConfigurationValue> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && (this._configuration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TableARN
        {
            get { return this._tablearn; }
            set { this._tablearn = value; }
        }

        // Check to see if TableARN property is set
        internal bool IsSetTableARN()
        {
            return this._tablearn != null;
        }

    }
}