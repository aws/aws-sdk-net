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
 * Do not modify this file. This file is generated from the ivs-realtime-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateStage operation.
    /// Creates a new stage (and optionally participant tokens).
    /// </summary>
    public partial class CreateStageRequest : AmazonIVSRealTimeRequest
    {
        private string _name;
        private List<ParticipantTokenConfiguration> _participantTokenConfigurations = new List<ParticipantTokenConfiguration>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Optional name that can be specified for the stage being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
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
        /// Gets and sets the property ParticipantTokenConfigurations. 
        /// <para>
        /// Array of participant token configuration objects to attach to the new stage.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=12)]
        public List<ParticipantTokenConfiguration> ParticipantTokenConfigurations
        {
            get { return this._participantTokenConfigurations; }
            set { this._participantTokenConfigurations = value; }
        }

        // Check to see if ParticipantTokenConfigurations property is set
        internal bool IsSetParticipantTokenConfigurations()
        {
            return this._participantTokenConfigurations != null && this._participantTokenConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of maps, each of the form <code>string:string
        /// (key:value)</code>. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> for details, including restrictions that apply to tags and "Tag
        /// naming limits and requirements"; Amazon IVS has no constraints on tags beyond what
        /// is documented there. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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