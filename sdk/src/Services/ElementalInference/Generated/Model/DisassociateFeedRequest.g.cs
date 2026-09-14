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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DisassociateFeed operation. Releases the resource
    /// (the source media) that is associated with this feed. The outputs in the feed become
    /// DISABLED.
    /// </summary>
    public partial class DisassociateFeedRequest : AmazonElementalInferenceRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatedResourceName. 
        /// <para>
        /// The name of the resource currently associated with the feed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string AssociatedResourceName { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceName property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceName() => this.AssociatedResourceName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Set to true if you want to do a dry run of the disassociate action.
        /// </para>
        ///  
        /// <para>
        /// Elemental Inference will validate that the real request would succeed without actually
        /// making any changes. A dry run catches errors such as missing IAM permissions. If the
        /// dry run fails, the action returns a 4xx error code. 
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the feed where you want to release the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;
    }
}
