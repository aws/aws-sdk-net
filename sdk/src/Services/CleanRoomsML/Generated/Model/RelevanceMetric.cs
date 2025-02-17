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
    /// The relevance score of a generated audience.
    /// </summary>
    public partial class RelevanceMetric
    {
        private AudienceSize _audienceSize;
        private double? _score;

        /// <summary>
        /// Gets and sets the property AudienceSize.
        /// </summary>
        [AWSProperty(Required=true)]
        public AudienceSize AudienceSize
        {
            get { return this._audienceSize; }
            set { this._audienceSize = value; }
        }

        // Check to see if AudienceSize property is set
        internal bool IsSetAudienceSize()
        {
            return this._audienceSize != null;
        }

        /// <summary>
        /// Gets and sets the property Score. 
        /// <para>
        /// The relevance score of the generated audience.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public double Score
        {
            get { return this._score.GetValueOrDefault(); }
            set { this._score = value; }
        }

        // Check to see if Score property is set
        internal bool IsSetScore()
        {
            return this._score.HasValue; 
        }

    }
}