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
    /// Represents information about the remote access session.
    /// </summary>
    public partial class RemoteAccessSession
    {
        private string _arn;
        private BillingMethod _billingMethod;
        private string _clientId;
        private DateTime? _created;
        private Device _device;
        private DeviceMinutes _deviceMinutes;
        private DeviceProxy _deviceProxy;
        private string _deviceUdid;
        private string _endpoint;
        private string _hostAddress;
        private string _instanceArn;
        private InteractionMode _interactionMode;
        private string _message;
        private string _name;
        private bool? _remoteDebugEnabled;
        private string _remoteRecordAppArn;
        private bool? _remoteRecordEnabled;
        private ExecutionResult _result;
        private bool? _skipAppResign;
        private DateTime? _started;
        private ExecutionStatus _status;
        private DateTime? _stopped;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
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
        /// Gets and sets the property BillingMethod. 
        /// <para>
        /// The billing method of the remote access session. Possible values include <c>METERED</c>
        /// or <c>UNMETERED</c>. For more information about metered devices, see <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/welcome.html#welcome-terminology">AWS
        /// Device Farm terminology</a>.
        /// </para>
        /// </summary>
        public BillingMethod BillingMethod
        {
            get { return this._billingMethod; }
            set { this._billingMethod = value; }
        }

        // Check to see if BillingMethod property is set
        internal bool IsSetBillingMethod()
        {
            return this._billingMethod != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Unique identifier of your client for the remote access session. Only returned if remote
        /// debugging is enabled for the remote access session.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The date and time the remote access session was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// The device (phone or tablet) used in the remote access session.
        /// </para>
        /// </summary>
        public Device Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// The number of minutes a device is used in a remote access session (including setup
        /// and teardown minutes).
        /// </para>
        /// </summary>
        public DeviceMinutes DeviceMinutes
        {
            get { return this._deviceMinutes; }
            set { this._deviceMinutes = value; }
        }

        // Check to see if DeviceMinutes property is set
        internal bool IsSetDeviceMinutes()
        {
            return this._deviceMinutes != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceProxy. 
        /// <para>
        /// The device proxy configured for the remote access session.
        /// </para>
        /// </summary>
        public DeviceProxy DeviceProxy
        {
            get { return this._deviceProxy; }
            set { this._deviceProxy = value; }
        }

        // Check to see if DeviceProxy property is set
        internal bool IsSetDeviceProxy()
        {
            return this._deviceProxy != null;
        }

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
        public string DeviceUdid
        {
            get { return this._deviceUdid; }
            set { this._deviceUdid = value; }
        }

        // Check to see if DeviceUdid property is set
        internal bool IsSetDeviceUdid()
        {
            return this._deviceUdid != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint for the remote access sesssion.
        /// </para>
        /// </summary>
        public string Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property HostAddress. 
        /// <para>
        /// IP address of the EC2 host where you need to connect to remotely debug devices. Only
        /// returned if remote debugging is enabled for the remote access session.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string HostAddress
        {
            get { return this._hostAddress; }
            set { this._hostAddress = value; }
        }

        // Check to see if HostAddress property is set
        internal bool IsSetHostAddress()
        {
            return this._hostAddress != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InteractionMode. 
        /// <para>
        /// The interaction mode of the remote access session. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// INTERACTIVE: You can interact with the iOS device by viewing, touching, and rotating
        /// the screen. You cannot run XCUITest framework-based tests in this mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// NO_VIDEO: You are connected to the device, but cannot interact with it or view the
        /// screen. This mode has the fastest test execution speed. You can run XCUITest framework-based
        /// tests in this mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// VIDEO_ONLY: You can view the screen, but cannot touch or rotate it. You can run XCUITest
        /// framework-based tests and watch the screen in this mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public InteractionMode InteractionMode
        {
            get { return this._interactionMode; }
            set { this._interactionMode = value; }
        }

        // Check to see if InteractionMode property is set
        internal bool IsSetInteractionMode()
        {
            return this._interactionMode != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the remote access session.
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
        /// Gets and sets the property RemoteDebugEnabled. 
        /// <para>
        /// This flag is set to <c>true</c> if remote debugging is enabled for the remote access
        /// session.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        public bool? RemoteDebugEnabled
        {
            get { return this._remoteDebugEnabled; }
            set { this._remoteDebugEnabled = value; }
        }

        // Check to see if RemoteDebugEnabled property is set
        internal bool IsSetRemoteDebugEnabled()
        {
            return this._remoteDebugEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoteRecordAppArn. 
        /// <para>
        /// The ARN for the app to be recorded in the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string RemoteRecordAppArn
        {
            get { return this._remoteRecordAppArn; }
            set { this._remoteRecordAppArn = value; }
        }

        // Check to see if RemoteRecordAppArn property is set
        internal bool IsSetRemoteRecordAppArn()
        {
            return this._remoteRecordAppArn != null;
        }

        /// <summary>
        /// Gets and sets the property RemoteRecordEnabled. 
        /// <para>
        /// This flag is set to <c>true</c> if remote recording is enabled for the remote access
        /// session.
        /// </para>
        /// </summary>
        public bool? RemoteRecordEnabled
        {
            get { return this._remoteRecordEnabled; }
            set { this._remoteRecordEnabled = value; }
        }

        // Check to see if RemoteRecordEnabled property is set
        internal bool IsSetRemoteRecordEnabled()
        {
            return this._remoteRecordEnabled.HasValue; 
        }

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
        public ExecutionResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

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
        public bool? SkipAppResign
        {
            get { return this._skipAppResign; }
            set { this._skipAppResign = value; }
        }

        // Check to see if SkipAppResign property is set
        internal bool IsSetSkipAppResign()
        {
            return this._skipAppResign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The date and time the remote access session was started.
        /// </para>
        /// </summary>
        public DateTime? Started
        {
            get { return this._started; }
            set { this._started = value; }
        }

        // Check to see if Started property is set
        internal bool IsSetStarted()
        {
            return this._started.HasValue; 
        }

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
        public ExecutionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The date and time the remote access session was stopped.
        /// </para>
        /// </summary>
        public DateTime? Stopped
        {
            get { return this._stopped; }
            set { this._stopped = value; }
        }

        // Check to see if Stopped property is set
        internal bool IsSetStopped()
        {
            return this._stopped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC security groups and subnets that are attached to a project.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}