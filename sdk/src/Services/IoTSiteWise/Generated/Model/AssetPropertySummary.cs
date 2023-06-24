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
    /// Contains a summary of a property associated with an asset.
    /// </summary>
    public partial class AssetPropertySummary
    {
        private string _alias;
        private string _assetCompositeModelId;
        private string _id;
        private PropertyNotification _notification;
        private string _unit;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The alias that identifies the property, such as an OPC-UA server data stream path
        /// (for example, <code>/company/windfarm/3/turbine/7/temperature</code>). For more information,
        /// see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/connect-data-streams.html">Mapping
        /// industrial data streams to asset properties</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModelId. 
        /// <para>
        ///  The ID of the composite model that contains the asset property. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string AssetCompositeModelId
        {
            get { return this._assetCompositeModelId; }
            set { this._assetCompositeModelId = value; }
        }

        // Check to see if AssetCompositeModelId property is set
        internal bool IsSetAssetCompositeModelId()
        {
            return this._assetCompositeModelId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the property.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Notification.
        /// </summary>
        public PropertyNotification Notification
        {
            get { return this._notification; }
            set { this._notification = value; }
        }

        // Check to see if Notification property is set
        internal bool IsSetNotification()
        {
            return this._notification != null;
        }

        /// <summary>
        /// Gets and sets the property Unit. 
        /// <para>
        ///  The unit of measure (such as Newtons or RPM) of the asset property. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }

        // Check to see if Unit property is set
        internal bool IsSetUnit()
        {
            return this._unit != null;
        }

    }
}