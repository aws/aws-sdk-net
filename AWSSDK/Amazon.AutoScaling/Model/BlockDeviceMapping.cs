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

        /// <summary>
        /// Sets the VirtualName property
        /// </summary>
        /// <param name="virtualName">The value to set for the VirtualName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithVirtualName(string virtualName)
        {
            this.virtualName = virtualName;
            return this;
        }
            

        // Check to see if VirtualName property is set
        internal bool IsSetVirtualName()
        {
            return this.virtualName != null;
        }

        /// <summary>
        /// The name of the device within Amazon EC2.
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

        /// <summary>
        /// Sets the DeviceName property
        /// </summary>
        /// <param name="deviceName">The value to set for the DeviceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithDeviceName(string deviceName)
        {
            this.deviceName = deviceName;
            return this;
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

        /// <summary>
        /// Sets the Ebs property
        /// </summary>
        /// <param name="ebs">The value to set for the Ebs property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public BlockDeviceMapping WithEbs(Ebs ebs)
        {
            this.ebs = ebs;
            return this;
        }
            

        // Check to see if Ebs property is set
        internal bool IsSetEbs()
        {
            return this.ebs != null;
        }
    }
}
