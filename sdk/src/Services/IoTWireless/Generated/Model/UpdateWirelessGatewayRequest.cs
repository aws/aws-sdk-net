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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWirelessGateway operation.
    /// Updates properties of a wireless gateway.
    /// </summary>
    public partial class UpdateWirelessGatewayRequest : AmazonIoTWirelessRequest
    {
        private string _description;
        private string _id;
        private List<List<string>> _joinEuiFilters = AWSConfigs.InitializeCollections ? new List<List<string>>() : null;
        private float? _maxEirp;
        private string _name;
        private List<string> _netIdFilters = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A new description of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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
        /// Gets and sets the property JoinEuiFilters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<List<string>> JoinEuiFilters
        {
            get { return this._joinEuiFilters; }
            set { this._joinEuiFilters = value; }
        }

        // Check to see if JoinEuiFilters property is set
        internal bool IsSetJoinEuiFilters()
        {
            return this._joinEuiFilters != null && (this._joinEuiFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxEirp. 
        /// <para>
        /// The MaxEIRP value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public float? MaxEirp
        {
            get { return this._maxEirp; }
            set { this._maxEirp = value; }
        }

        // Check to see if MaxEirp property is set
        internal bool IsSetMaxEirp()
        {
            return this._maxEirp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new name of the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following special characters aren't accepted: <c>&lt;&gt;^#~$</c> 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
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

        /// <summary>
        /// Gets and sets the property NetIdFilters.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> NetIdFilters
        {
            get { return this._netIdFilters; }
            set { this._netIdFilters = value; }
        }

        // Check to see if NetIdFilters property is set
        internal bool IsSetNetIdFilters()
        {
            return this._netIdFilters != null && (this._netIdFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}