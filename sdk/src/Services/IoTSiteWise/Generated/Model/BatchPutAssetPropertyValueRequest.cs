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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the BatchPutAssetPropertyValue operation.
    /// Sends a list of asset property values to IoT SiteWise. Each value is a timestamp-quality-value
    /// (TQV) data point. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ingest-api.html">Ingesting
    /// data using the API</a> in the <i>IoT SiteWise User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To identify an asset property, you must specify one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <c>assetId</c> and <c>propertyId</c> of an asset property.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <c>propertyAlias</c>, which is a data stream alias (for example, <c>/company/windfarm/3/turbine/7/temperature</c>).
    /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// With respect to Unix epoch time, IoT SiteWise accepts only TQVs that have a timestamp
    /// of no more than 7 days in the past and no more than 10 minutes in the future. IoT
    /// SiteWise rejects timestamps outside of the inclusive range of [-7 days, +10 minutes]
    /// and returns a <c>TimestampOutOfRangeException</c> error.
    /// </para>
    ///  
    /// <para>
    /// For each asset property, IoT SiteWise overwrites TQVs with duplicate timestamps unless
    /// the newer TQV has a different quality. For example, if you store a TQV <c>{T1, GOOD,
    /// V1}</c>, then storing <c>{T1, GOOD, V2}</c> replaces the existing TQV.
    /// </para>
    ///  </important> 
    /// <para>
    /// IoT SiteWise authorizes access to each <c>BatchPutAssetPropertyValue</c> entry individually.
    /// For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-batchputassetpropertyvalue-action">BatchPutAssetPropertyValue
    /// authorization</a> in the <i>IoT SiteWise User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchPutAssetPropertyValueRequest : AmazonIoTSiteWiseRequest
    {
        private bool? _enablePartialEntryProcessing;
        private List<PutAssetPropertyValueEntry> _entries = AWSConfigs.InitializeCollections ? new List<PutAssetPropertyValueEntry>() : null;

        /// <summary>
        /// Gets and sets the property EnablePartialEntryProcessing. 
        /// <para>
        /// This setting enables partial ingestion at entry-level. If set to <c>true</c>, we ingest
        /// all TQVs not resulting in an error. If set to <c>false</c>, an invalid TQV fails ingestion
        /// of the entire entry that contains it.
        /// </para>
        /// </summary>
        public bool? EnablePartialEntryProcessing
        {
            get { return this._enablePartialEntryProcessing; }
            set { this._enablePartialEntryProcessing = value; }
        }

        // Check to see if EnablePartialEntryProcessing property is set
        internal bool IsSetEnablePartialEntryProcessing()
        {
            return this._enablePartialEntryProcessing.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of asset property value entries for the batch put request. You can specify
        /// up to 10 entries per request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PutAssetPropertyValueEntry> Entries
        {
            get { return this._entries; }
            set { this._entries = value; }
        }

        // Check to see if Entries property is set
        internal bool IsSetEntries()
        {
            return this._entries != null && (this._entries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}