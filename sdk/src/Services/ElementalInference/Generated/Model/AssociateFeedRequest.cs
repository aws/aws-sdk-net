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
    /// Container for the parameters to the AssociateFeed operation.
    /// Associates a resource with the feed. The resource provides the input that Elemental
    /// Inference needs needs in order to perform an Elemental Inference feature, such as
    /// cropping video. You always provide the resource by associating it with a feed. You
    /// can associate only one resource with each feed.
    /// </summary>
    public partial class AssociateFeedRequest : AmazonElementalInferenceRequest
    {
        private string _associatedResourceName;
        private bool? _dryRun;
        private string _id;
        private List<CreateOutput> _outputs = AWSConfigs.InitializeCollections ? new List<CreateOutput>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResourceName. 
        /// <para>
        /// An identifier for the resource. If the resource is from an AWS service, this identifier
        /// must be the full ARN of that resource. Otherwise, the identifier is a name that you
        /// assign and that is appropriate for the application that owns the resource. This name
        /// must not resemble an ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string AssociatedResourceName
        {
            get { return this._associatedResourceName; }
            set { this._associatedResourceName = value; }
        }

        // Check to see if AssociatedResourceName property is set
        internal bool IsSetAssociatedResourceName()
        {
            return this._associatedResourceName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Set to true if you want to do a dry run of the associate action.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the feed.
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
        /// Gets and sets the property Outputs. 
        /// <para>
        /// The outputs to add to this feed. You must specify at least one output. You can later
        /// use the UpdateFeed action to change the list of outputs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CreateOutput> Outputs
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