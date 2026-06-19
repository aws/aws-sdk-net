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
    /// Information about the points configuration for a question.
    /// </summary>
    public partial class QuestionPointsConfiguration
    {
        private bool? _isBonus;
        private int? _maxPointValue;
        private int? _minPointValue;

        /// <summary>
        /// Gets and sets the property IsBonus. 
        /// <para>
        /// The flag to mark the question as a bonus question.
        /// </para>
        /// </summary>
        public bool? IsBonus
        {
            get { return this._isBonus; }
            set { this._isBonus = value; }
        }

        // Check to see if IsBonus property is set
        internal bool IsSetIsBonus()
        {
            return this._isBonus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxPointValue. 
        /// <para>
        /// The maximum point value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MaxPointValue
        {
            get { return this._maxPointValue; }
            set { this._maxPointValue = value; }
        }

        // Check to see if MaxPointValue property is set
        internal bool IsSetMaxPointValue()
        {
            return this._maxPointValue.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinPointValue. 
        /// <para>
        /// The minimum point value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? MinPointValue
        {
            get { return this._minPointValue; }
            set { this._minPointValue = value; }
        }

        // Check to see if MinPointValue property is set
        internal bool IsSetMinPointValue()
        {
            return this._minPointValue.HasValue; 
        }

    }
}