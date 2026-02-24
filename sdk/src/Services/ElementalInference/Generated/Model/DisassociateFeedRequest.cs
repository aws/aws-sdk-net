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
    /// Container for the parameters to the DisassociateFeed operation.
    /// Releases the resource (for example, an MediaLive channel) that is associated with
    /// this feed. The outputs in the feed become disabled.
    /// </summary>
    public partial class DisassociateFeedRequest : AmazonElementalInferenceRequest
    {
        private string _associatedResourceName;
        private bool? _dryRun;
        private string _id;

        /// <summary>
        /// Gets and sets the property AssociatedResourceName. 
        /// <para>
        /// The name of the resource currently associated with the feed'.
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
        /// Set to true if you want to do a dry run of the disassociate action.
        /// </para>
        /// </summary>
        public bool DryRun
        {
            get { return this._dryRun.GetValueOrDefault(); }
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
        /// The ID of the feed where you want to release the resource.
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

    }
}