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
    /// Creates a new virtual MFA device for the AWS account. After creating the virtual MFA,
    /// use <a href="http://docs.aws.amazon.com/IAM/latest/APIReference/API_EnableMFADevice.html"
    /// target="_blank">EnableMFADevice</a> to attach the MFA device to an IAM user. For more
    /// information about            creating and working with virtual MFA devices, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_VirtualMFA.html"
    /// target="_blank">Using a Virtual MFA Device</a> in <i>Using AWS Identity and Access
    /// Management</i>.
    /// 
    ///         
    /// <para>
    /// For information about limits on the number of MFA devices you can create, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html"
    /// target="_blank">Limitations on Entities</a> in <i>Using AWS Identity and Access                Management</i>.
    /// </para>
    ///         <important>The seed information contained in the QR code and the Base32 string should
    /// be treated            like any other secret access information, such as your AWS access keys
    /// or your passwords.            After you provision your virtual device, you should ensure that
    /// the information is destroyed            following secure procedures.</important>
    /// </summary>
    public partial class CreateVirtualMFADeviceRequest : AmazonWebServiceRequest
    {
        private string _path;
        private string _virtualMFADeviceName;


        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path for the virtual MFA device. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html"
        /// target="_blank">Identifiers for IAM Entities</a> in <i>Using AWS Identity and Access                Management</i>.
        /// </para>
        ///         
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }


        /// <summary>
        /// Sets the Path property
        /// </summary>
        /// <param name="path">The value to set for the Path property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVirtualMFADeviceRequest WithPath(string path)
        {
            this._path = path;
            return this;
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }


        /// <summary>
        /// Gets and sets the property VirtualMFADeviceName. 
        /// <para>
        /// The name of the virtual MFA device. Use with path to uniquely identify a virtual MFA            device.
        /// </para>
        /// </summary>
        public string VirtualMFADeviceName
        {
            get { return this._virtualMFADeviceName; }
            set { this._virtualMFADeviceName = value; }
        }


        /// <summary>
        /// Sets the VirtualMFADeviceName property
        /// </summary>
        /// <param name="virtualMFADeviceName">The value to set for the VirtualMFADeviceName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateVirtualMFADeviceRequest WithVirtualMFADeviceName(string virtualMFADeviceName)
        {
            this._virtualMFADeviceName = virtualMFADeviceName;
            return this;
        }

        // Check to see if VirtualMFADeviceName property is set
        internal bool IsSetVirtualMFADeviceName()
        {
            return this._virtualMFADeviceName != null;
        }

    }
}