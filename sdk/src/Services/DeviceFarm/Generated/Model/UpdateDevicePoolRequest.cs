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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDevicePool operation.
    /// Modifies the name, description, and rules in a device pool given the attributes and
    /// the pool ARN. Rule updates are all-or-nothing, meaning they can only be updated as
    /// a whole (or not at all).
    /// </summary>
    public partial class UpdateDevicePoolRequest : AmazonDeviceFarmRequest
    {
        private string _arn;
        private bool? _clearMaxDevices;
        private string _description;
        private int? _maxDevices;
        private string _name;
        private List<Rule> _rules = AWSConfigs.InitializeCollections ? new List<Rule>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Device Farm device pool to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClearMaxDevices. 
        /// <para>
        /// Sets whether the <c>maxDevices</c> parameter applies to your device pool. If you set
        /// this parameter to <c>true</c>, the <c>maxDevices</c> parameter does not apply, and
        /// Device Farm does not limit the number of devices that it adds to your device pool.
        /// In this case, Device Farm adds all available devices that meet the criteria specified
        /// in the <c>rules</c> parameter.
        /// </para>
        ///  
        /// <para>
        /// If you use this parameter in your request, you cannot use the <c>maxDevices</c> parameter
        /// in the same request.
        /// </para>
        /// </summary>
        public bool? ClearMaxDevices
        {
            get { return this._clearMaxDevices; }
            set { this._clearMaxDevices = value; }
        }

        // Check to see if ClearMaxDevices property is set
        internal bool IsSetClearMaxDevices()
        {
            return this._clearMaxDevices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the device pool to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
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
        /// Gets and sets the property MaxDevices. 
        /// <para>
        /// The number of devices that Device Farm can add to your device pool. Device Farm adds
        /// devices that are available and that meet the criteria that you assign for the <c>rules</c>
        /// parameter. Depending on how many devices meet these constraints, your device pool
        /// might contain fewer devices than the value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// By specifying the maximum number of devices, you can control the costs that you incur
        /// by running tests.
        /// </para>
        ///  
        /// <para>
        /// If you use this parameter in your request, you cannot use the <c>clearMaxDevices</c>
        /// parameter in the same request.
        /// </para>
        /// </summary>
        public int? MaxDevices
        {
            get { return this._maxDevices; }
            set { this._maxDevices = value; }
        }

        // Check to see if MaxDevices property is set
        internal bool IsSetMaxDevices()
        {
            return this._maxDevices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string that represents the name of the device pool to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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
        /// Gets and sets the property Rules. 
        /// <para>
        /// Represents the rules to modify for the device pool. Updating rules is optional. If
        /// you update rules for your request, the update replaces the existing rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && (this._rules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}