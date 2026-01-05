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
 * Do not modify this file. This file is generated from the cleanroomsml-2023-09-06.normal.json service model.
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
namespace Amazon.CleanRoomsML.Model
{
    /// <summary>
    /// The configuration properties for the worker compute environment. These properties
    /// allow you to customize the compute settings for your Clean Rooms workloads.
    /// </summary>
    public partial class WorkerComputeConfigurationProperties
    {
        private Dictionary<string, string> _spark = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Spark. 
        /// <para>
        /// The Spark configuration properties for SQL workloads. This map contains key-value
        /// pairs that configure Apache Spark settings to optimize performance for your data processing
        /// jobs. You can specify up to 50 Spark properties, with each key being 1-200 characters
        /// and each value being 0-500 characters. These properties allow you to adjust compute
        /// capacity for large datasets and complex workloads.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Spark
        {
            get { return this._spark; }
            set { this._spark = value; }
        }

        // Check to see if Spark property is set
        internal bool IsSetSpark()
        {
            return this._spark != null && (this._spark.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}