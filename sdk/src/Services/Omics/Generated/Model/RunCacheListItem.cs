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
    /// List entry for one run cache.
    /// </summary>
    public partial class RunCacheListItem
    {
        private string _arn;
        private CacheBehavior _cacheBehavior;
        private string _caches3Uri;
        private DateTime? _creationTime;
        private string _id;
        private string _name;
        private RunCacheStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Unique resource identifier for the run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property CacheBehavior. 
        /// <para>
        /// Default cache behavior for the run cache.
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
        /// Gets and sets the property CacheS3Uri. 
        /// <para>
        /// The S3 uri for the run cache data.
        /// </para>
        /// </summary>
        public string CacheS3Uri
        {
            get { return this._caches3Uri; }
            set { this._caches3Uri = value; }
        }

        // Check to see if CacheS3Uri property is set
        internal bool IsSetCacheS3Uri()
        {
            return this._caches3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that this run cache was created (an ISO 8601 formatted string).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for this run cache.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=18)]
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
        /// The name of the run cache.
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The run cache status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public RunCacheStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}