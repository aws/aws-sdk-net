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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRunCache operation.
    /// Updates a run cache using its ID and returns a response with no body if the operation
    /// is successful. You can update the run cache description, name, or the default run
    /// cache behavior with <c>CACHE_ON_FAILURE</c> or <c>CACHE_ALWAYS</c>. To confirm that
    /// your run cache settings have been properly updated, use the <c>GetRunCache</c> API
    /// operation.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/omics/latest/dev/how-run-cache.html">How
    /// call caching works</a> in the <i>Amazon Web Services HealthOmics User Guide</i>.
    /// </para>
    /// </summary>
    public partial class UpdateRunCacheRequest : AmazonOmicsRequest
    {
        private CacheBehavior _cacheBehavior;
        private string _description;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// Update the default run cache behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public CacheBehavior CacheBehavior
        {
            get { return this._cacheBehavior; }
            set { this._cacheBehavior = value; }
        }

        // Check to see if CacheBehavior property is set
        internal bool IsSetCacheBehavior()
        {
            return this._cacheBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Update the run cache description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the run cache you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
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
        /// Update the name of the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}