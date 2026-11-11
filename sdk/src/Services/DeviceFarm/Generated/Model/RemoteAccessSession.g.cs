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
    /// Represents information about the remote access session.
    /// </summary>
    public partial class RemoteAccessSession
    {
        /// <summary>
        /// Gets and sets the property AppUpload. 
        /// <para>
        /// The ARN for the app to be installed onto your device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string AppUpload { get; set; }

        /// <summary>
        /// Checks to see if the AppUpload property is set.
        /// </summary>
        internal bool IsSetAppUpload() => this.AppUpload != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// The billing method of the remote access session. Possible values include <c>METERED</c>
        /// or <c>UNMETERED</c>. For more information about metered devices, see <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/welcome.html#welcome-terminology">AWS
        /// Device Farm terminology</a>.
        /// </para>
        /// </summary>
        public BillingMethod BillingMethod { get; set; }

        /// <summary>
        /// Checks to see if the BillingMethod property is set.
        /// </summary>
        internal bool IsSetBillingMethod() => this.BillingMethod != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the remote access session was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device (phone or tablet) used in the remote access session.
        /// </para>
        /// </summary>
        public Device Device { get; set; }

        /// <summary>
        /// Checks to see if the Device property is set.
        /// </summary>
        internal bool IsSetDevice() => this.Device != null;

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// The number of minutes a device is used in a remote access session (including setup
        /// and teardown minutes).
        /// </para>
        /// </summary>
        public DeviceMinutes DeviceMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DeviceMinutes property is set.
        /// </summary>
        internal bool IsSetDeviceMinutes() => this.DeviceMinutes != null;

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy configured for the remote access session.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy { get; set; }

        /// <summary>
        /// Checks to see if the DeviceProxy property is set.
        /// </summary>
        internal bool IsSetDeviceProxy() => this.DeviceProxy != null;

        /// <summary>
        /// Gets and sets the property DeviceUdid. 
        /// <para>
        /// Unique device identifier for the remote device. Only returned if remote debugging
        /// is enabled for the remote access session.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        public string DeviceUdid { get; set; }

        /// <summary>
        /// Checks to see if the DeviceUdid property is set.
        /// </summary>
        internal bool IsSetDeviceUdid() => this.DeviceUdid != null;

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the remote access session. This field is deprecated, and is replaced
        /// by the new <c>endpoints.interactiveEndpoint</c> field.
        /// </para>
        /// </summary>
        [Obsolete("This field is deprecated, and is replaced by the new endpoints.interactiveEndpoint field.")]
        public string Endpoint { get; set; }

        /// <summary>
        /// Checks to see if the Endpoint property is set.
        /// </summary>
        internal bool IsSetEndpoint() => this.Endpoint != null;

        /// <summary>
        /// Gets and sets the property Endpoints.
        /// </summary>
        public RemoteAccessEndpoints Endpoints { get; set; }

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance.
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
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the remote access session. Can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PASSED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARNED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SKIPPED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERRORED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property SkipAppResign. 
        /// <para>
        /// When set to <c>true</c>, for private devices, Device Farm does not sign your app again.
        /// For public devices, Device Farm always signs your apps again.
        /// </para>
        ///  
        /// <para>
        /// For more information about how Device Farm re-signs your apps, see <a href="http://aws.amazon.com/device-farm/faqs/">Do
        /// you modify my app?</a> in the <i>AWS Device Farm FAQs</i>.
        /// </para>
        /// </summary>
        public bool? SkipAppResign { get; set; }

        /// <summary>
        /// Checks to see if the SkipAppResign property is set.
        /// </summary>
        internal bool IsSetSkipAppResign() => this.SkipAppResign.HasValue;

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The date and time the remote access session was started.
        /// </para>
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Checks to see if the Started property is set.
        /// </summary>
        internal bool IsSetStarted() => this.Started.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the remote access session. Can be any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_CONCURRENCY.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_DEVICE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCHEDULING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PREPARING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPING.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The date and time the remote access session was stopped.
        /// </para>
        /// </summary>
        public DateTime? Stopped { get; set; }

        /// <summary>
        /// Checks to see if the Stopped property is set.
        /// </summary>
        internal bool IsSetStopped() => this.Stopped.HasValue;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC security groups and subnets that are attached to a project.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
