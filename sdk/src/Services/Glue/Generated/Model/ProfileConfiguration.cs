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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies the job and session values that an admin configures in an Glue usage profile.
    /// </summary>
    public partial class ProfileConfiguration
    {
        private Dictionary<string, ConfigurationObject> _jobConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, ConfigurationObject>() : null;
        private Dictionary<string, ConfigurationObject> _sessionConfiguration = AWSConfigs.InitializeCollections ? new Dictionary<string, ConfigurationObject>() : null;

        /// <summary>
        /// Gets and sets the property JobConfiguration. 
        /// <para>
        /// A key-value map of configuration parameters for Glue jobs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ConfigurationObject> JobConfiguration
        {
            get { return this._jobConfiguration; }
            set { this._jobConfiguration = value; }
        }

        // Check to see if JobConfiguration property is set
        internal bool IsSetJobConfiguration()
        {
            return this._jobConfiguration != null && (this._jobConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionConfiguration. 
        /// <para>
        /// A key-value map of configuration parameters for Glue sessions. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ConfigurationObject> SessionConfiguration
        {
            get { return this._sessionConfiguration; }
            set { this._sessionConfiguration = value; }
        }

        // Check to see if SessionConfiguration property is set
        internal bool IsSetSessionConfiguration()
        {
            return this._sessionConfiguration != null && (this._sessionConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}