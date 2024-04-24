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
    /// Container for the parameters to the UpdateAssetProperty operation.
    /// Updates an asset property's alias and notification state.
    /// 
    ///  <important> 
    /// <para>
    /// This operation overwrites the property's existing alias and notification state. To
    /// keep your existing property's alias or notification state, you must include the existing
    /// values in the UpdateAssetProperty request. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/APIReference/API_DescribeAssetProperty.html">DescribeAssetProperty</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateAssetPropertyRequest : AmazonIoTSiteWiseRequest
    {
        private string _assetId;
        private string _clientToken;
        private string _propertyAlias;
        private string _propertyId;
        private PropertyNotificationState _propertyNotificationState;
        private string _propertyUnit;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset to be updated. This can be either the actual ID in UUID format,
        /// or else <c>externalId:</c> followed by the external ID, if it has one. For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique case-sensitive identifier that you can provide to ensure the idempotency
        /// of the request. Don't reuse this client token if a new idempotent request is required.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
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
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <c>/company/windfarm/3/turbine/7/temperature</c>). For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the alias is removed from the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyId. 
        /// <para>
        /// The ID of the asset property to be updated. This can be either the actual ID in UUID
        /// format, or else <c>externalId:</c> followed by the external ID, if it has one. For
        /// more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-id-references">Referencing
        /// objects with external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=13, Max=139)]
        public string PropertyId
        {
            get { return this._propertyId; }
            set { this._propertyId = value; }
        }

        // Check to see if PropertyId property is set
        internal bool IsSetPropertyId()
        {
            return this._propertyId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyNotificationState. 
        /// <para>
        /// The MQTT notification state (enabled or disabled) for this asset property. When the
        /// notification state is enabled, IoT SiteWise publishes property value updates to a
        /// unique MQTT topic. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/interact-with-other-services.html">Interacting
        /// with other services</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the notification state is set to <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public PropertyNotificationState PropertyNotificationState
        {
            get { return this._propertyNotificationState; }
            set { this._propertyNotificationState = value; }
        }

        // Check to see if PropertyNotificationState property is set
        internal bool IsSetPropertyNotificationState()
        {
            return this._propertyNotificationState != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyUnit. 
        /// <para>
        /// The unit of measure (such as Newtons or RPM) of the asset property. If you don't specify
        /// a value for this parameter, the service uses the value of the <c>assetModelProperty</c>
        /// in the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PropertyUnit
        {
            get { return this._propertyUnit; }
            set { this._propertyUnit = value; }
        }

        // Check to see if PropertyUnit property is set
        internal bool IsSetPropertyUnit()
        {
            return this._propertyUnit != null;
        }

    }
}