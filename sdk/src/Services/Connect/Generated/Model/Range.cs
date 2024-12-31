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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// An Object to define the minimum and maximum proficiency levels.
    /// </summary>
    public partial class Range
    {
        private float? _maxProficiencyLevel;
        private float? _minProficiencyLevel;

        /// <summary>
        /// Gets and sets the property MaxProficiencyLevel. 
        /// <para>
        /// The maximum proficiency level of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public float? MaxProficiencyLevel
        {
            get { return this._maxProficiencyLevel; }
            set { this._maxProficiencyLevel = value; }
        }

        // Check to see if MaxProficiencyLevel property is set
        internal bool IsSetMaxProficiencyLevel()
        {
            return this._maxProficiencyLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinProficiencyLevel. 
        /// <para>
        /// The minimum proficiency level of the range.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public float? MinProficiencyLevel
        {
            get { return this._minProficiencyLevel; }
            set { this._minProficiencyLevel = value; }
        }

        // Check to see if MinProficiencyLevel property is set
        internal bool IsSetMinProficiencyLevel()
        {
            return this._minProficiencyLevel.HasValue; 
        }

    }
}