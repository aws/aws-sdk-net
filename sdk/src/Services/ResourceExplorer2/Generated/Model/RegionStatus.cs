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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Contains information about the status of Resource Explorer configuration in a specific
    /// Amazon Web Services Region.
    /// </summary>
    public partial class RegionStatus
    {
        private IndexStatus _index;
        private string _region;
        private ViewStatus _view;

        /// <summary>
        /// Gets and sets the property Index. 
        /// <para>
        /// The status information for the Resource Explorer index in this Region.
        /// </para>
        /// </summary>
        public IndexStatus Index
        {
            get { return this._index; }
            set { this._index = value; }
        }

        // Check to see if Index property is set
        internal bool IsSetIndex()
        {
            return this._index != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region for which this status information applies.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property View. 
        /// <para>
        /// The status information for the Resource Explorer view in this Region.
        /// </para>
        /// </summary>
        public ViewStatus View
        {
            get { return this._view; }
            set { this._view = value; }
        }

        // Check to see if View property is set
        internal bool IsSetView()
        {
            return this._view != null;
        }

    }
}