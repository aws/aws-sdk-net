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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The status of a specified delivery channel.
    /// 
    ///  
    /// <para>
    /// Valid values: <c>Success</c> | <c>Failure</c> 
    /// </para>
    /// </summary>
    public partial class DeliveryChannelStatus
    {
        private ConfigExportDeliveryInfo _configHistoryDeliveryInfo;
        private ConfigExportDeliveryInfo _configSnapshotDeliveryInfo;
        private ConfigStreamDeliveryInfo _configStreamDeliveryInfo;
        private string _name;

        /// <summary>
        /// Gets and sets the property ConfigHistoryDeliveryInfo. 
        /// <para>
        /// A list that contains the status of the delivery of the configuration history to the
        /// specified Amazon S3 bucket.
        /// </para>
        /// </summary>
        public ConfigExportDeliveryInfo ConfigHistoryDeliveryInfo
        {
            get { return this._configHistoryDeliveryInfo; }
            set { this._configHistoryDeliveryInfo = value; }
        }

        // Check to see if ConfigHistoryDeliveryInfo property is set
        internal bool IsSetConfigHistoryDeliveryInfo()
        {
            return this._configHistoryDeliveryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigSnapshotDeliveryInfo. 
        /// <para>
        /// A list containing the status of the delivery of the snapshot to the specified Amazon
        /// S3 bucket.
        /// </para>
        /// </summary>
        public ConfigExportDeliveryInfo ConfigSnapshotDeliveryInfo
        {
            get { return this._configSnapshotDeliveryInfo; }
            set { this._configSnapshotDeliveryInfo = value; }
        }

        // Check to see if ConfigSnapshotDeliveryInfo property is set
        internal bool IsSetConfigSnapshotDeliveryInfo()
        {
            return this._configSnapshotDeliveryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigStreamDeliveryInfo. 
        /// <para>
        /// A list containing the status of the delivery of the configuration stream notification
        /// to the specified Amazon SNS topic.
        /// </para>
        /// </summary>
        public ConfigStreamDeliveryInfo ConfigStreamDeliveryInfo
        {
            get { return this._configStreamDeliveryInfo; }
            set { this._configStreamDeliveryInfo = value; }
        }

        // Check to see if ConfigStreamDeliveryInfo property is set
        internal bool IsSetConfigStreamDeliveryInfo()
        {
            return this._configStreamDeliveryInfo != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the delivery channel.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}