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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorageConfiguration operation.
    /// </summary>
    public partial class DescribeStorageConfigurationResponse : AmazonWebServiceResponse
    {
        private ConfigurationStatus _configurationStatus;
        private DateTime? _lastUpdateDate;
        private MultiLayerStorage _multiLayerStorage;
        private StorageType _storageType;

        /// <summary>
        /// Gets and sets the property ConfigurationStatus.
        /// </summary>
        [AWSProperty(Required=true)]
        public ConfigurationStatus ConfigurationStatus
        {
            get { return this._configurationStatus; }
            set { this._configurationStatus = value; }
        }

        // Check to see if ConfigurationStatus property is set
        internal bool IsSetConfigurationStatus()
        {
            return this._configurationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the storage configuration was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate.GetValueOrDefault(); }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MultiLayerStorage. 
        /// <para>
        /// Contains information about the storage destination.
        /// </para>
        /// </summary>
        public MultiLayerStorage MultiLayerStorage
        {
            get { return this._multiLayerStorage; }
            set { this._multiLayerStorage = value; }
        }

        // Check to see if MultiLayerStorage property is set
        internal bool IsSetMultiLayerStorage()
        {
            return this._multiLayerStorage != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage that you specified for your data. The storage type can be one
        /// of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SITEWISE_DEFAULT_STORAGE</code> – IoT SiteWise replicates your data into a
        /// service managed database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MULTI_LAYER_STORAGE</code> – IoT SiteWise replicates your data into a service
        /// managed database and saves a copy of your raw data and metadata in an Amazon S3 object
        /// that you specified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public StorageType StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}