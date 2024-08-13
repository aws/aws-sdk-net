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
    /// Container for the parameters to the CreateRemoteAccessSession operation.
    /// Specifies and starts a remote access session.
    /// </summary>
    public partial class CreateRemoteAccessSessionRequest : AmazonDeviceFarmRequest
    {
        private string _clientId;
        private CreateRemoteAccessSessionConfiguration _configuration;
        private string _deviceArn;
        private string _instanceArn;
        private InteractionMode _interactionMode;
        private string _name;
        private string _projectArn;
        private bool? _remoteDebugEnabled;
        private string _remoteRecordAppArn;
        private bool? _remoteRecordEnabled;
        private bool? _skipAppResign;
        private string _sshPublicKey;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// Unique identifier for the client. If you want access to multiple devices on the same
        /// client, you should pass the same <c>clientId</c> value in each call to <c>CreateRemoteAccessSession</c>.
        /// This identifier is required only if <c>remoteDebugEnabled</c> is set to <c>true</c>.
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
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration information for the remote access session request.
        /// </para>
        /// </summary>
        public CreateRemoteAccessSessionConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The ARN of the device for which you want to create a remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device instance for which you want to create
        /// a remote access session.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the remote access session to create.
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
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the project for which you want to create a remote
        /// access session.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
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
        /// Gets and sets the property RemoteDebugEnabled. 
        /// <para>
        /// Set to <c>true</c> if you want to access devices remotely for debugging in your remote
        /// access session.
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
        /// The Amazon Resource Name (ARN) for the app to be recorded in the remote access session.
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
        /// Set to <c>true</c> to enable remote recording for the remote access session.
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
        /// Gets and sets the property SshPublicKey. 
        /// <para>
        /// Ignored. The public key of the <c>ssh</c> key pair you want to use for connecting
        /// to remote devices in your remote debugging session. This key is required only if <c>remoteDebugEnabled</c>
        /// is set to <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// Remote debugging is <a href="https://docs.aws.amazon.com/devicefarm/latest/developerguide/history.html">no
        /// longer supported</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string SshPublicKey
        {
            get { return this._sshPublicKey; }
            set { this._sshPublicKey = value; }
        }

        // Check to see if SshPublicKey property is set
        internal bool IsSetSshPublicKey()
        {
            return this._sshPublicKey != null;
        }

    }
}