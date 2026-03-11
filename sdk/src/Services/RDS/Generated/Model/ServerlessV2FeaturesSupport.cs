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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Specifies any Aurora Serverless v2 properties or limits that differ between Aurora
    /// engine versions and platform versions. You can test the values of this attribute when
    /// deciding which Aurora version to use in a new or upgraded DB cluster. You can also
    /// retrieve the version of an existing DB cluster and check whether that version supports
    /// certain Aurora Serverless v2 features before you attempt to use those features.
    /// </summary>
    public partial class ServerlessV2FeaturesSupport
    {
        private double? _maxCapacity;
        private double? _minCapacity;

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        ///  Specifies the upper Aurora Serverless v2 capacity limit for a particular engine version
        /// or platform version. Depending on the engine version, the maximum capacity for an
        /// Aurora Serverless v2 cluster might be <c>256</c> or <c>128</c>. 
        /// </para>
        /// </summary>
        public double? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCapacity. 
        /// <para>
        /// If the minimum capacity is 0 ACUs, the engine version or platform version supports
        /// the automatic pause/resume feature of Aurora Serverless v2.
        /// </para>
        /// </summary>
        public double? MinCapacity
        {
            get { return this._minCapacity; }
            set { this._minCapacity = value; }
        }

        // Check to see if MinCapacity property is set
        internal bool IsSetMinCapacity()
        {
            return this._minCapacity.HasValue; 
        }

    }
}