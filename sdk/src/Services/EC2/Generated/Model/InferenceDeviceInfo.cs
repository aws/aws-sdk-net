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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the Inference accelerators for the instance type.
    /// </summary>
    public partial class InferenceDeviceInfo
    {
        private int? _count;
        private string _manufacturer;
        private string _name;

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of Inference accelerators for the instance type.
        /// </para>
        /// </summary>
        public int Count
        {
            get { return this._count.GetValueOrDefault(); }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Manufacturer. 
        /// <para>
        /// The manufacturer of the Inference accelerator.
        /// </para>
        /// </summary>
        public string Manufacturer
        {
            get { return this._manufacturer; }
            set { this._manufacturer = value; }
        }

        // Check to see if Manufacturer property is set
        internal bool IsSetManufacturer()
        {
            return this._manufacturer != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Inference accelerator.
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