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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the StartComposition operation.
    /// Starts a Composition from a stage based on the configuration provided in the request.
    /// 
    ///  
    /// <para>
    /// A Composition is an ephemeral resource that exists after this endpoint returns successfully.
    /// Composition stops and the resource is deleted:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When <a>StopComposition</a> is called.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After a 1-minute timeout, when all participants are disconnected from the stage.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// After a 1-minute timeout, if there are no participants in the stage when StartComposition
    /// is called.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When broadcasting to the IVS channel fails and all retries are exhausted.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When broadcasting is disconnected and all attempts to reconnect are exhausted.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartCompositionRequest : AmazonIVSRealTimeRequest
    {
        private List<DestinationConfiguration> _destinations = AWSConfigs.InitializeCollections ? new List<DestinationConfiguration>() : null;
        private string _idempotencyToken;
        private LayoutConfiguration _layout;
        private string _stageArn;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// Array of destination configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<DestinationConfiguration> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// Idempotency token.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// Layout object to configure composition parameters.
        /// </para>
        /// </summary>
        public LayoutConfiguration Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage to be used for compositing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string StageArn
        {
            get { return this._stageArn; }
            set { this._stageArn = value; }
        }

        // Check to see if StageArn property is set
        internal bool IsSetStageArn()
        {
            return this._stageArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of maps, each of the form <c>string:string (key:value)</c>.
        /// See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}