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
    /// Container for the parameters to the BatchPutAssetPropertyValue operation.
    /// Sends a list of asset property values to AWS IoT SiteWise. Each value is a timestamp-quality-value
    /// (TQV) data point. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/ingest-api.html">Ingesting
    /// data using the API</a> in the <i>AWS IoT SiteWise User Guide</i>.
    /// 
    ///  
    /// <para>
    /// To identify an asset property, you must specify one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The <code>assetId</code> and <code>propertyId</code> of an asset property.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <code>propertyAlias</code>, which is a data stream alias (for example, <code>/company/windfarm/3/turbine/7/temperature</code>).
    /// To define an asset property's alias, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_UpdateAssetProperty.html">UpdateAssetProperty</a>.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// With respect to Unix epoch time, AWS IoT SiteWise accepts only TQVs that have a timestamp
    /// of no more than 7 days in the past and no more than 5 minutes in the future. AWS IoT
    /// SiteWise rejects timestamps outside of the inclusive range of [-7 days, +5 minutes]
    /// and returns a <code>TimestampOutOfRangeException</code> error.
    /// </para>
    ///  
    /// <para>
    /// For each asset property, AWS IoT SiteWise overwrites TQVs with duplicate timestamps
    /// unless the newer TQV has a different quality. For example, if you store a TQV <code>{T1,
    /// GOOD, V1}</code>, then storing <code>{T1, GOOD, V2}</code> replaces the existing TQV.
    /// </para>
    ///  </important> 
    /// <para>
    /// AWS IoT SiteWise authorizes access to each <code>BatchPutAssetPropertyValue</code>
    /// entry individually. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-id-based-policies-batchputassetpropertyvalue-action">BatchPutAssetPropertyValue
    /// authorization</a> in the <i>AWS IoT SiteWise User Guide</i>.
    /// </para>
    /// </summary>
    public partial class BatchPutAssetPropertyValueRequest : AmazonIoTSiteWiseRequest
    {
        private List<PutAssetPropertyValueEntry> _entries = new List<PutAssetPropertyValueEntry>();

        /// <summary>
        /// Gets and sets the property Entries. 
        /// <para>
        /// The list of asset property value entries for the batch put request. You can specify
        /// up to 10 entries per request.
        /// </para>
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
            return this._entries != null && this._entries.Count > 0; 
        }

    }
}