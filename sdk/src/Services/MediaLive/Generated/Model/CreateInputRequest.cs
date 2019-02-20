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

/*
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInput operation.
    /// Create an input
    /// </summary>
    public partial class CreateInputRequest : AmazonMediaLiveRequest
    {
        private List<InputDestinationRequest> _destinations = new List<InputDestinationRequest>();
        private List<string> _inputSecurityGroups = new List<string>();
        private List<MediaConnectFlowRequest> _mediaConnectFlows = new List<MediaConnectFlowRequest>();
        private string _name;
        private string _requestId;
        private string _roleArn;
        private List<InputSourceRequest> _sources = new List<InputSourceRequest>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private InputType _type;
        private InputVpcRequest _vpc;

        /// <summary>
        /// Gets and sets the property Destinations. Destination settings for PUSH type inputs.
        /// </summary>
        public List<InputDestinationRequest> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputSecurityGroups. A list of security groups referenced
        /// by IDs to attach to the input.
        /// </summary>
        public List<string> InputSecurityGroups
        {
            get { return this._inputSecurityGroups; }
            set { this._inputSecurityGroups = value; }
        }

        // Check to see if InputSecurityGroups property is set
        internal bool IsSetInputSecurityGroups()
        {
            return this._inputSecurityGroups != null && this._inputSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MediaConnectFlows. A list of the MediaConnect Flows that
        /// you want to use in this input. You can specify as few as oneFlow and presently, as
        /// many as two. The only requirement is when you have more than one is that each Flow
        /// is in aseparate Availability Zone as this ensures your EML input is redundant to AZ
        /// issues.
        /// </summary>
        public List<MediaConnectFlowRequest> MediaConnectFlows
        {
            get { return this._mediaConnectFlows; }
            set { this._mediaConnectFlows = value; }
        }

        // Check to see if MediaConnectFlows property is set
        internal bool IsSetMediaConnectFlows()
        {
            return this._mediaConnectFlows != null && this._mediaConnectFlows.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. Name of the input.
        /// </summary>
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
        /// Gets and sets the property RequestId. Unique identifier of the request to ensure the
        /// request is handledexactly once in case of retries.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. The Amazon Resource Name (ARN) of the role this
        /// input assumes during and after creation.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. The source URLs for a PULL-type input. Every PULL
        /// type input needsexactly two source URLs for redundancy.Only specify sources for PULL
        /// type Inputs. Leave Destinations empty.
        /// </summary>
        public List<InputSourceRequest> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. A collection of key-value pairs.
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

        /// <summary>
        /// Gets and sets the property Type.
        /// </summary>
        public InputType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Vpc.
        /// </summary>
        public InputVpcRequest Vpc
        {
            get { return this._vpc; }
            set { this._vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this._vpc != null;
        }

    }
}