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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// Represents a streaming image resource.
    /// 
    ///  
    /// <para>
    /// Streaming images are used by studio users to select which operating system and software
    /// they want to use in a Nimble Studio streaming session.
    /// </para>
    ///  
    /// <para>
    /// Amazon provides a number of streaming images that include popular 3rd-party software.
    /// </para>
    ///  
    /// <para>
    /// You can create your own streaming images using an Amazon EC2 machine image that you
    /// create for this purpose. You can also include software that your users require.
    /// </para>
    /// </summary>
    public partial class StreamingImage
    {
        private string _arn;
        private string _description;
        private string _ec2ImageId;
        private StreamingImageEncryptionConfiguration _encryptionConfiguration;
        private List<string> _eulaIds = new List<string>();
        private string _name;
        private string _owner;
        private string _platform;
        private StreamingImageState _state;
        private StreamingImageStatusCode _statusCode;
        private string _statusMessage;
        private string _streamingImageId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that is assigned to a studio resource and uniquely
        /// identifies it. ARNs are unique across all Regions.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of the streaming image.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=256)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2ImageId. 
        /// <para>
        /// The ID of an EC2 machine image with which to create the streaming image.
        /// </para>
        /// </summary>
        public string Ec2ImageId
        {
            get { return this._ec2ImageId; }
            set { this._ec2ImageId = value; }
        }

        // Check to see if Ec2ImageId property is set
        internal bool IsSetEc2ImageId()
        {
            return this._ec2ImageId != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfiguration. 
        /// <para>
        /// The encryption configuration.
        /// </para>
        /// </summary>
        public StreamingImageEncryptionConfiguration EncryptionConfiguration
        {
            get { return this._encryptionConfiguration; }
            set { this._encryptionConfiguration = value; }
        }

        // Check to see if EncryptionConfiguration property is set
        internal bool IsSetEncryptionConfiguration()
        {
            return this._encryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property EulaIds. 
        /// <para>
        /// The list of EULAs that must be accepted before a Streaming Session can be started
        /// using this streaming image.
        /// </para>
        /// </summary>
        public List<string> EulaIds
        {
            get { return this._eulaIds; }
            set { this._eulaIds = value; }
        }

        // Check to see if EulaIds property is set
        internal bool IsSetEulaIds()
        {
            return this._eulaIds != null && this._eulaIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A friendly name for a streaming image resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=64)]
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the streaming image, either the <code>studioId</code> that contains the
        /// streaming image, or <code>amazon</code> for images that are provided by Amazon Nimble
        /// Studio.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the streaming image, either Windows or Linux.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state.
        /// </para>
        /// </summary>
        public StreamingImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The status code.
        /// </para>
        /// </summary>
        public StreamingImageStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the streaming image.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingImageId. 
        /// <para>
        /// The ID of the streaming image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=22)]
        public string StreamingImageId
        {
            get { return this._streamingImageId; }
            set { this._streamingImageId = value; }
        }

        // Check to see if StreamingImageId property is set
        internal bool IsSetStreamingImageId()
        {
            return this._streamingImageId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of labels, in the form of key-value pairs, that apply to this resource.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}