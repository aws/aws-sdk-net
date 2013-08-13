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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVirtualMFADevice operation.
    /// <para>Creates a new virtual MFA device for the AWS account. After creating the virtual MFA, use EnableMFADevice to attach the MFA device to
    /// an IAM user. For more information about creating and working with virtual MFA devices, go to Using a Virtual MFA Device in <i>Using AWS
    /// Identity and Access Management</i> .</para> <para>For information about limits on the number of MFA devices you can create, see Limitations
    /// on Entities in <i>Using AWS Identity and Access Management</i> .</para> <para><b>IMPORTANT:</b>The seed information contained in the QR code
    /// and the Base32 string should be treated like any other secret access information, such as your AWS access keys or your passwords. After you
    /// provision your virtual device, you should ensure that the information is destroyed following secure procedures.</para>
    /// </summary>
    /// <seealso cref="Amazon.IdentityManagement.AmazonIdentityManagementService.CreateVirtualMFADevice"/>
    public class CreateVirtualMFADeviceRequest : AmazonWebServiceRequest
    {
        private string path;
        private string virtualMFADeviceName;

        /// <summary>
        /// The path for the virtual MFA device. For more information about paths, see <a
        /// href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM
        /// Entities</a> in <i>Using AWS Identity and Access Management</i>. This parameter is optional. If it is not included, it defaults to a slash
        /// (/).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(\u002F)|(\u002F[\u0021-\u007F]+\u002F)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVirtualMFADeviceRequest WithPath(string path)
        {
            this.path = path;
            return this;
        }
            

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;       
        }

        /// <summary>
        /// The name of the virtual MFA device. Use with path to uniquely identify a virtual MFA device.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - </description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string VirtualMFADeviceName
        {
            get { return this.virtualMFADeviceName; }
            set { this.virtualMFADeviceName = value; }
        }

        /// <summary>
        /// Sets the VirtualMFADeviceName property
        /// </summary>
        /// <param name="virtualMFADeviceName">The value to set for the VirtualMFADeviceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVirtualMFADeviceRequest WithVirtualMFADeviceName(string virtualMFADeviceName)
        {
            this.virtualMFADeviceName = virtualMFADeviceName;
            return this;
        }
            

        // Check to see if VirtualMFADeviceName property is set
        internal bool IsSetVirtualMFADeviceName()
        {
            return this.virtualMFADeviceName != null;       
        }
    }
}
    
