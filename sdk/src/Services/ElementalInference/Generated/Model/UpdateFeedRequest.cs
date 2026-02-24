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
 * Do not modify this file. This file is generated from the elementalinference-2018-11-14.normal.json service model.
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
namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateFeed operation.
    /// Updates the name and/or outputs in a feed.
    /// </summary>
    public partial class UpdateFeedRequest : AmazonElementalInferenceRequest
    {
        private string _id;
        private string _name;
        private List<UpdateOutput> _outputs = AWSConfigs.InitializeCollections ? new List<UpdateOutput>() : null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the feed to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Required. You can specify the existing name (to leave it unchanged) or a new name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Required. You can specify the existing array of outputs (to leave outputs unchanged)
        /// or you can specify a new array. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<UpdateOutput> Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }

        // Check to see if Outputs property is set
        internal bool IsSetOutputs()
        {
            return this._outputs != null && (this._outputs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}