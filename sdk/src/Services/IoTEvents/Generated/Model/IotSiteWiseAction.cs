/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Sends information about the detector model instance and the event that triggered the
    /// action to a specified asset property in AWS IoT SiteWise.
    /// 
    ///  <important> 
    /// <para>
    /// You must specify either <code>propertyAlias</code> or both <code>assetId</code> and
    /// <code>propertyId</code> to identify the target asset property in AWS IoT SiteWise.
    /// </para>
    ///  </important> 
    /// <para>
    /// For parameters that are string data type, you can specify the following options: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use a string. For example, the <code>propertyAlias</code> value can be <code>'/company/windfarm/3/turbine/7/temperature'</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use an expression. For example, the <code>propertyAlias</code> value can be <code>'company/windfarm/${$input.TemperatureInput.sensorData.windfarmID}/turbine/${$input.TemperatureInput.sensorData.turbineID}/temperature'</code>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/iotevents-expressions.html">Expressions</a>
    /// in the <i>AWS IoT Events Developer Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class IotSiteWiseAction
    {
        private string _assetId;
        private string _entryId;
        private string _propertyAlias;
        private string _propertyId;
        private AssetPropertyValue _propertyValue;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset that has the specified property. You can specify an expression.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EntryId. 
        /// <para>
        /// A unique identifier for this entry. You can use the entry ID to track which data entry
        /// causes an error in case of failure. The default is a new unique identifier. You can
        /// also specify an expression.
        /// </para>
        /// </summary>
        public string EntryId
        {
            get { return this._entryId; }
            set { this._entryId = value; }
        }

        // Check to see if EntryId property is set
        internal bool IsSetEntryId()
        {
            return this._entryId != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The alias of the asset property. You can also specify an expression.
        /// </para>
        /// </summary>
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
        /// The ID of the asset property. You can specify an expression.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PropertyValue. 
        /// <para>
        /// The value to send to the asset property. This value contains timestamp, quality, and
        /// value (TQV) information. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetPropertyValue PropertyValue
        {
            get { return this._propertyValue; }
            set { this._propertyValue = value; }
        }

        // Check to see if PropertyValue property is set
        internal bool IsSetPropertyValue()
        {
            return this._propertyValue != null;
        }

    }
}