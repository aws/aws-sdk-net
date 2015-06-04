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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains directory limit information for a region.
    /// </summary>
    public partial class DirectoryLimits
    {
        private int? _cloudOnlyDirectoriesCurrentCount;
        private int? _cloudOnlyDirectoriesLimit;
        private bool? _cloudOnlyDirectoriesLimitReached;
        private int? _connectedDirectoriesCurrentCount;
        private int? _connectedDirectoriesLimit;
        private bool? _connectedDirectoriesLimitReached;

        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesCurrentCount. 
        /// <para>
        /// The current number of cloud directories in the region.
        /// </para>
        /// </summary>
        public int CloudOnlyDirectoriesCurrentCount
        {
            get { return this._cloudOnlyDirectoriesCurrentCount.GetValueOrDefault(); }
            set { this._cloudOnlyDirectoriesCurrentCount = value; }
        }

        // Check to see if CloudOnlyDirectoriesCurrentCount property is set
        internal bool IsSetCloudOnlyDirectoriesCurrentCount()
        {
            return this._cloudOnlyDirectoriesCurrentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesLimit. 
        /// <para>
        /// The maximum number of cloud directories allowed in the region.
        /// </para>
        /// </summary>
        public int CloudOnlyDirectoriesLimit
        {
            get { return this._cloudOnlyDirectoriesLimit.GetValueOrDefault(); }
            set { this._cloudOnlyDirectoriesLimit = value; }
        }

        // Check to see if CloudOnlyDirectoriesLimit property is set
        internal bool IsSetCloudOnlyDirectoriesLimit()
        {
            return this._cloudOnlyDirectoriesLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CloudOnlyDirectoriesLimitReached. 
        /// <para>
        /// Indicates if the cloud directory limit has been reached.
        /// </para>
        /// </summary>
        public bool CloudOnlyDirectoriesLimitReached
        {
            get { return this._cloudOnlyDirectoriesLimitReached.GetValueOrDefault(); }
            set { this._cloudOnlyDirectoriesLimitReached = value; }
        }

        // Check to see if CloudOnlyDirectoriesLimitReached property is set
        internal bool IsSetCloudOnlyDirectoriesLimitReached()
        {
            return this._cloudOnlyDirectoriesLimitReached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesCurrentCount. 
        /// <para>
        /// The current number of connected directories in the region.
        /// </para>
        /// </summary>
        public int ConnectedDirectoriesCurrentCount
        {
            get { return this._connectedDirectoriesCurrentCount.GetValueOrDefault(); }
            set { this._connectedDirectoriesCurrentCount = value; }
        }

        // Check to see if ConnectedDirectoriesCurrentCount property is set
        internal bool IsSetConnectedDirectoriesCurrentCount()
        {
            return this._connectedDirectoriesCurrentCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesLimit. 
        /// <para>
        /// The maximum number of connected directories allowed in the region.
        /// </para>
        /// </summary>
        public int ConnectedDirectoriesLimit
        {
            get { return this._connectedDirectoriesLimit.GetValueOrDefault(); }
            set { this._connectedDirectoriesLimit = value; }
        }

        // Check to see if ConnectedDirectoriesLimit property is set
        internal bool IsSetConnectedDirectoriesLimit()
        {
            return this._connectedDirectoriesLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConnectedDirectoriesLimitReached. 
        /// <para>
        /// Indicates if the connected directory limit has been reached.
        /// </para>
        /// </summary>
        public bool ConnectedDirectoriesLimitReached
        {
            get { return this._connectedDirectoriesLimitReached.GetValueOrDefault(); }
            set { this._connectedDirectoriesLimitReached = value; }
        }

        // Check to see if ConnectedDirectoriesLimitReached property is set
        internal bool IsSetConnectedDirectoriesLimitReached()
        {
            return this._connectedDirectoriesLimitReached.HasValue; 
        }

    }
}