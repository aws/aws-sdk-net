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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// An object that represents the metadata and configuration settings for services on
    /// an Amazon Web Services Snow Family device.
    /// </summary>
    public partial class OnDeviceServiceConfiguration
    {
        /// <summary>
        /// Gets and sets the property EKSOnDeviceService. 
        /// <para>
        /// The configuration of EKS Anywhere on the Snow Family device.
        /// </para>
        /// </summary>
        public EKSOnDeviceServiceConfiguration EKSOnDeviceService { get; set; }

        /// <summary>
        /// Checks to see if the EKSOnDeviceService property is set.
        /// </summary>
        internal bool IsSetEKSOnDeviceService() => this.EKSOnDeviceService != null;

        /// <summary>
        /// Gets and sets the property NFSOnDeviceService. 
        /// <para>
        /// Represents the NFS (Network File System) service on a Snow Family device.
        /// </para>
        /// </summary>
        public NFSOnDeviceServiceConfiguration NFSOnDeviceService { get; set; }

        /// <summary>
        /// Checks to see if the NFSOnDeviceService property is set.
        /// </summary>
        internal bool IsSetNFSOnDeviceService() => this.NFSOnDeviceService != null;

        /// <summary>
        /// Gets and sets the property S3OnDeviceService. 
        /// <para>
        /// Configuration for Amazon S3 compatible storage on Snow family devices.
        /// </para>
        /// </summary>
        public S3OnDeviceServiceConfiguration S3OnDeviceService { get; set; }

        /// <summary>
        /// Checks to see if the S3OnDeviceService property is set.
        /// </summary>
        internal bool IsSetS3OnDeviceService() => this.S3OnDeviceService != null;

        /// <summary>
        /// Gets and sets the property TGWOnDeviceService. 
        /// <para>
        /// Represents the Storage Gateway service Tape Gateway type on a Snow Family device.
        /// </para>
        /// </summary>
        public TGWOnDeviceServiceConfiguration TGWOnDeviceService { get; set; }

        /// <summary>
        /// Checks to see if the TGWOnDeviceService property is set.
        /// </summary>
        internal bool IsSetTGWOnDeviceService() => this.TGWOnDeviceService != null;
    }
}
