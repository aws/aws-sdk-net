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
    /// Container for the parameters to the PutStorageConfiguration operation.
    /// Configures storage settings for IoT SiteWise.
    /// </summary>
    public partial class PutStorageConfigurationRequest : AmazonIoTSiteWiseRequest
    {
        private DisassociatedDataStorageState _disassociatedDataStorage;
        private MultiLayerStorage _multiLayerStorage;
        private RetentionPeriod _retentionPeriod;
        private StorageType _storageType;

        /// <summary>
        /// Gets and sets the property DisassociatedDataStorage. 
        /// <para>
        /// Contains the storage configuration for time series (data streams) that aren't associated
        /// with asset properties. The <code>disassociatedDataStorage</code> can be one of the
        /// following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> – IoT SiteWise accepts time series that aren't associated with
        /// asset properties.
        /// </para>
        ///  <important> 
        /// <para>
        /// After the <code>disassociatedDataStorage</code> is enabled, you can't disable it.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> – IoT SiteWise doesn't accept time series (data streams) that
        /// aren't associated with asset properties.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/data-streams.html">Data
        /// streams</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public DisassociatedDataStorageState DisassociatedDataStorage
        {
            get { return this._disassociatedDataStorage; }
            set { this._disassociatedDataStorage = value; }
        }

        // Check to see if DisassociatedDataStorage property is set
        internal bool IsSetDisassociatedDataStorage()
        {
            return this._disassociatedDataStorage != null;
        }

        /// <summary>
        /// Gets and sets the property MultiLayerStorage. 
        /// <para>
        /// Identifies a storage destination. If you specified <code>MULTI_LAYER_STORAGE</code>
        /// for the storage type, you must specify a <code>MultiLayerStorage</code> object.
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
        /// Gets and sets the property RetentionPeriod.
        /// </summary>
        public RetentionPeriod RetentionPeriod
        {
            get { return this._retentionPeriod; }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage tier that you specified for your data. The <code>storageType</code> parameter
        /// can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SITEWISE_DEFAULT_STORAGE</code> – IoT SiteWise saves your data into the hot
        /// tier. The hot tier is a service-managed database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MULTI_LAYER_STORAGE</code> – IoT SiteWise saves your data in both the cold
        /// tier and the hot tier. The cold tier is a customer-managed Amazon S3 bucket.
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