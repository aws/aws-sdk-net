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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRemoteAccessSession operation. Specifies
    /// and starts a remote access session.
    /// </summary>
    public partial class CreateRemoteAccessSessionRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app to create the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration information for the remote access session request.
        /// </para>
        /// </summary>
        public CreateRemoteAccessSessionConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device for which you want to create a remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device instance for which you want to create
        /// a remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property InteractionMode. 
        /// <para>
        /// The interaction mode of the remote access session. Changing the interactive mode of
        /// remote access sessions is no longer available.
        /// </para>
        /// </summary>
        [Obsolete("Changing the interactive mode of Remote Access sessions is no longer available.")]
        [AWSProperty(Min = 0, Max = 64)]
        public InteractionMode InteractionMode { get; set; }

        /// <summary>
        /// Checks to see if the InteractionMode property is set.
        /// </summary>
        internal bool IsSetInteractionMode() => this.InteractionMode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the remote access session to create.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project for which you want to create a remote
        /// access session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <c>true</c>, for private devices, Device Farm does not sign your app again.
        /// For public devices, Device Farm always signs your apps again.
        /// </para>
        ///  
        /// <para>
        /// For more information on how Device Farm modifies your uploads during tests, see <a
        /// href="http://aws.amazon.com/device-farm/faqs/">Do you modify my app?</a> 
        /// </para>
        /// </summary>
        public bool? SkipAppResign { get; set; }

        /// <summary>
        /// Checks to see if the SkipAppResign property is set.
        /// </summary>
        internal bool IsSetSkipAppResign() => this.SkipAppResign.HasValue;
    }
}
