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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeStorageConfiguration operation.
    /// </summary>
    public partial class DescribeStorageConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ConfigurationStatus.
        /// </summary>
        [AWSProperty(Required = true)]
        public ConfigurationStatus ConfigurationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationStatus property is set.
        /// </summary>
        internal bool IsSetConfigurationStatus() => this.ConfigurationStatus != null;

        /// <summary>
        /// Gets and sets the property DisallowIngestNullNaN. 
        /// <para>
        /// Describes the configuration for ingesting NULL and NaN data. By default the feature
        /// is allowed. The feature is disallowed if the value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? DisallowIngestNullNaN { get; set; }

        /// <summary>
        /// Checks to see if the DisallowIngestNullNaN property is set.
        /// </summary>
        internal bool IsSetDisallowIngestNullNaN() => this.DisallowIngestNullNaN.HasValue;

        /// <summary>
        /// Gets and sets the property DisassociatedDataStorage. 
        /// <para>
        /// Contains the storage configuration for time series (data streams) that aren't associated
        /// with asset properties. The <c>disassociatedDataStorage</c> can be one of the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> – IoT SiteWise accepts time series that aren't associated with asset
        /// properties.
        /// </para>
        ///  <important> 
        /// <para>
        /// After the <c>disassociatedDataStorage</c> is enabled, you can't disable it.
        /// </para>
        ///  </important> </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – IoT SiteWise doesn't accept time series (data streams) that aren't
        /// associated with asset properties.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/data-streams.html">Data
        /// streams</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public DisassociatedDataStorageState DisassociatedDataStorage { get; set; }

        /// <summary>
        /// Checks to see if the DisassociatedDataStorage property is set.
        /// </summary>
        internal bool IsSetDisassociatedDataStorage() => this.DisassociatedDataStorage != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the storage configuration was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property MultiLayerStorage. 
        /// <para>
        /// Contains information about the storage destination.
        /// </para>
        /// </summary>
        public MultiLayerStorage MultiLayerStorage { get; set; }

        /// <summary>
        /// Checks to see if the MultiLayerStorage property is set.
        /// </summary>
        internal bool IsSetMultiLayerStorage() => this.MultiLayerStorage != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The number of days your data is kept in the hot tier. By default, your data is kept
        /// indefinitely in the hot tier.
        /// </para>
        /// </summary>
        public RetentionPeriod RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage tier that you specified for your data. The <c>storageType</c> parameter
        /// can be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SITEWISE_DEFAULT_STORAGE</c> – IoT SiteWise saves your data into the hot tier.
        /// The hot tier is a service-managed database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTI_LAYER_STORAGE</c> – IoT SiteWise saves your data in both the cold tier and
        /// the hot tier. The cold tier is a customer-managed Amazon S3 bucket.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property WarmTier. 
        /// <para>
        /// A service managed storage tier optimized for analytical queries. It stores periodically
        /// uploaded, buffered and historical data ingested with the CreaeBulkImportJob API.
        /// </para>
        /// </summary>
        public WarmTierState WarmTier { get; set; }

        /// <summary>
        /// Checks to see if the WarmTier property is set.
        /// </summary>
        internal bool IsSetWarmTier() => this.WarmTier != null;

        /// <summary>
        /// Gets and sets the property WarmTierRetentionPeriod. 
        /// <para>
        /// Set this period to specify how long your data is stored in the warm tier before it
        /// is deleted. You can set this only if cold tier is enabled.
        /// </para>
        /// </summary>
        public WarmTierRetentionPeriod WarmTierRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the WarmTierRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetWarmTierRetentionPeriod() => this.WarmTierRetentionPeriod != null;
    }
}
