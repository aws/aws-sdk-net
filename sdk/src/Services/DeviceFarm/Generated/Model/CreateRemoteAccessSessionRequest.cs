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
        private string _appArn;
        private CreateRemoteAccessSessionConfiguration _configuration;
        private string _deviceArn;
        private string _instanceArn;
        private InteractionMode _interactionMode;
        private string _name;
        private string _projectArn;
        private bool? _skipAppResign;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the app to create the remote access session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
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
        /// The interaction mode of the remote access session. Changing the interactive mode of
        /// remote access sessions is no longer available.
        /// </para>
        /// </summary>
        [Obsolete("Changing the interactive mode of Remote Access sessions is no longer available.")]
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
        public bool SkipAppResign
        {
            get { return this._skipAppResign.GetValueOrDefault(); }
            set { this._skipAppResign = value; }
        }

        // Check to see if SkipAppResign property is set
        internal bool IsSetSkipAppResign()
        {
            return this._skipAppResign.HasValue; 
        }

    }
}