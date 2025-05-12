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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
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
namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Configuration settings for horizontal or vertical scaling operations on Memcached
    /// clusters.
    /// </summary>
    public partial class ScaleConfig
    {
        private int? _scaleIntervalMinutes;
        private int? _scalePercentage;

        /// <summary>
        /// Gets and sets the property ScaleIntervalMinutes. 
        /// <para>
        /// The time interval in seconds between scaling operations when performing gradual scaling
        /// for a Memcached cluster.
        /// </para>
        /// </summary>
        public int? ScaleIntervalMinutes
        {
            get { return this._scaleIntervalMinutes; }
            set { this._scaleIntervalMinutes = value; }
        }

        // Check to see if ScaleIntervalMinutes property is set
        internal bool IsSetScaleIntervalMinutes()
        {
            return this._scaleIntervalMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalePercentage. 
        /// <para>
        /// The percentage by which to scale the Memcached cluster, either horizontally by adding
        /// nodes or vertically by increasing resources.
        /// </para>
        /// </summary>
        public int? ScalePercentage
        {
            get { return this._scalePercentage; }
            set { this._scalePercentage = value; }
        }

        // Check to see if ScalePercentage property is set
        internal bool IsSetScalePercentage()
        {
            return this._scalePercentage.HasValue; 
        }

    }
}