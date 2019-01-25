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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDevicePool operation.
    /// Creates a device pool.
    /// </summary>
    public partial class CreateDevicePoolRequest : AmazonDeviceFarmRequest
    {
        private string _description;
        private int? _maxDevices;
        private string _name;
        private string _projectArn;
        private List<Rule> _rules = new List<Rule>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The device pool's description.
        /// </para>
        /// </summary>
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
        /// devices that are available and that meet the criteria that you assign for the <code>rules</code>
        /// parameter. Depending on how many devices meet these constraints, your device pool
        /// might contain fewer devices than the value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// By specifying the maximum number of devices, you can control the costs that you incur
        /// by running tests.
        /// </para>
        /// </summary>
        public int MaxDevices
        {
            get { return this._maxDevices.GetValueOrDefault(); }
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
        /// The device pool's name.
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

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for the device pool.
        /// </para>
        /// </summary>
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Rules. 
        /// <para>
        /// The device pool's rules.
        /// </para>
        /// </summary>
        public List<Rule> Rules
        {
            get { return this._rules; }
            set { this._rules = value; }
        }

        // Check to see if Rules property is set
        internal bool IsSetRules()
        {
            return this._rules != null && this._rules.Count > 0; 
        }

    }
}