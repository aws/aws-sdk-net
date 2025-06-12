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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes an action to send data from an MQTT message that triggered the rule to IoT
    /// SiteWise asset properties.
    /// </summary>
    public partial class IotSiteWiseAction
    {
        private List<PutAssetPropertyValueEntry> _putAssetPropertyValueEntries = AWSConfigs.InitializeCollections ? new List<PutAssetPropertyValueEntry>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property PutAssetPropertyValueEntries. 
        /// <para>
        /// A list of asset property value entries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<PutAssetPropertyValueEntry> PutAssetPropertyValueEntries
        {
            get { return this._putAssetPropertyValueEntries; }
            set { this._putAssetPropertyValueEntries = value; }
        }

        // Check to see if PutAssetPropertyValueEntries property is set
        internal bool IsSetPutAssetPropertyValueEntries()
        {
            return this._putAssetPropertyValueEntries != null && (this._putAssetPropertyValueEntries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants IoT permission to send an asset property value to
        /// IoT SiteWise. (<c>"Action": "iotsitewise:BatchPutAssetPropertyValue"</c>). The trust
        /// policy can restrict access to specific asset hierarchy paths.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}