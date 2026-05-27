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
    /// Inference needs in order to perform an Elemental Inference feature, such as cropping
    /// video. You always provide the resource by associating it with a feed. You can associate
    /// only one resource with each feed. With an association, a specific source media is
    /// claiming ownership of the feed. 
    /// 
    ///  
    /// <para>
    /// AssociateFeed is a PATCH operation, which means that you can include only parameters
    /// that you want to change. Parameters that you don't include will not be affected by
    /// the operation. 
    /// </para>
    ///  
    /// <para>
    /// Specifically:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can add more outputs to the existing outputs. New outputs will be appended.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't modify an existing output (for example to change its name). Instead, use
    /// UpdateFeed. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't delete an existing output. Instead, use UpdateFeed.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Also note that you can't change the feed name with AssociateFeed. Instead, use UpdateFeed.
    /// 
    /// </para>
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
        /// An identifier for the resource. This name must not resemble an ARN.
        /// </para>
        ///  
        /// <para>
        /// The resource is the source media that the feed will process. The name you assign should
        /// help you to later identify the source media that belongs to the feed. In this way,
        /// you will know which source media to push to the feed (using PutMedia). 
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
        ///  
        /// <para>
        /// Elemental Inference will validate that the real request would succeed without actually
        /// making any changes. A dry run catches errors such as missing IAM permissions, quota
        /// limits exceeded, conflicting outputs, and so on. If the dry run fails, the action
        /// returns a 4xx error code. After you've fixed the errors, resubmit the request. 
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
        /// An array of one or more outputs that you want to add to this feed now, to supplement
        /// any outputs that you specified when you created or updated the feed. 
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