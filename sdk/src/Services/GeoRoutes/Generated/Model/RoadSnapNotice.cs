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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
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
namespace Amazon.GeoRoutes.Model
{
    /// <summary>
    /// Notices provide information around factors that may have influenced snapping in a
    /// manner atypical to the standard use cases.
    /// </summary>
    public partial class RoadSnapNotice
    {
        private RoadSnapNoticeCode _code;
        private string _title;
        private List<int> _tracePointIndexes = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Code corresponding to the issue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public RoadSnapNoticeCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The notice title.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

        /// <summary>
        /// Gets and sets the property TracePointIndexes. 
        /// <para>
        /// TracePoint indices for which the provided notice code corresponds to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1000)]
        public List<int> TracePointIndexes
        {
            get { return this._tracePointIndexes; }
            set { this._tracePointIndexes = value; }
        }

        // Check to see if TracePointIndexes property is set
        internal bool IsSetTracePointIndexes()
        {
            return this._tracePointIndexes != null && (this._tracePointIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}