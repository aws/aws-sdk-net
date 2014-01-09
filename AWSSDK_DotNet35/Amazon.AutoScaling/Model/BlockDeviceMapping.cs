/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// <para> The <c>BlockDeviceMapping</c> data type. </para>
    /// </summary>
    public class BlockDeviceMapping
    {
        
        private string virtualName;
        private string deviceName;
        private Ebs ebs;
        private bool? noDevice;


        /// <summary>
        /// The virtual name associated with the device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VirtualName
        {
            get { return this.virtualName; }
            set { this.virtualName = value; }
        }

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this.virtualName != null;
        }

        /// <summary>
        /// The name of the device within Amazon EC2 (for example, /dev/sdh or xvdh).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string DeviceName
        {
            get { return this.deviceName; }
            set { this.deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this.deviceName != null;
        }

        /// <summary>
        /// The Elastic Block Storage volume information.
        ///  
        /// </summary>
        public Ebs Ebs
        {
            get { return this.ebs; }
            set { this.ebs = value; }
        }

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this.ebs != null;
        }

        /// <summary>
        /// Suppresses the device mapping.
        ///  
        /// </summary>
        public bool NoDevice
        {
            get { return this.noDevice ?? default(bool); }
            set { this.noDevice = value; }
        }

        // Check to see if NoDevice property is set
        internal bool IsSetNoDevice()
        {
            return this.noDevice.HasValue;
        }
    }
}
