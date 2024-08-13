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
 * Do not modify this file. This file is generated from the iotanalytics-2017-11-27.normal.json service model.
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
namespace Amazon.IoTAnalytics.Model
{
    /// <summary>
    /// The estimated size of the resource.
    /// </summary>
    public partial class EstimatedResourceSize
    {
        private DateTime? _estimatedOn;
        private double? _estimatedSizeInBytes;

        /// <summary>
        /// Gets and sets the property EstimatedOn. 
        /// <para>
        /// The time when the estimate of the size of the resource was made.
        /// </para>
        /// </summary>
        public DateTime? EstimatedOn
        {
            get { return this._estimatedOn; }
            set { this._estimatedOn = value; }
        }

        // Check to see if EstimatedOn property is set
        internal bool IsSetEstimatedOn()
        {
            return this._estimatedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedSizeInBytes. 
        /// <para>
        /// The estimated size of the resource, in bytes.
        /// </para>
        /// </summary>
        public double? EstimatedSizeInBytes
        {
            get { return this._estimatedSizeInBytes; }
            set { this._estimatedSizeInBytes = value; }
        }

        // Check to see if EstimatedSizeInBytes property is set
        internal bool IsSetEstimatedSizeInBytes()
        {
            return this._estimatedSizeInBytes.HasValue; 
        }

    }
}