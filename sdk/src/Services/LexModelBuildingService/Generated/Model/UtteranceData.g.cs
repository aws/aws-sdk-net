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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides information about a single utterance that was made to your bot.
    /// </summary>
    public partial class UtteranceData
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of times that the utterance was processed.
        /// </para>
        /// </summary>
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property DistinctUsers. 
        /// <para>
        /// The total number of individuals that used the utterance.
        /// </para>
        /// </summary>
        public int? DistinctUsers { get; set; }

        /// <summary>
        /// Checks to see if the DistinctUsers property is set.
        /// </summary>
        internal bool IsSetDistinctUsers() => this.DistinctUsers.HasValue;

        /// <summary>
        /// Gets and sets the property FirstUtteredDate. 
        /// <para>
        /// The date that the utterance was first recorded.
        /// </para>
        /// </summary>
        public DateTime? FirstUtteredDate { get; set; }

        /// <summary>
        /// Checks to see if the FirstUtteredDate property is set.
        /// </summary>
        internal bool IsSetFirstUtteredDate() => this.FirstUtteredDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastUtteredDate. 
        /// <para>
        /// The date that the utterance was last recorded.
        /// </para>
        /// </summary>
        public DateTime? LastUtteredDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUtteredDate property is set.
        /// </summary>
        internal bool IsSetLastUtteredDate() => this.LastUtteredDate.HasValue;

        /// <summary>
        /// Gets and sets the property UtteranceString. 
        /// <para>
        /// The text that was entered by the user or the text representation of an audio clip.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string UtteranceString { get; set; }

        /// <summary>
        /// Checks to see if the UtteranceString property is set.
        /// </summary>
        internal bool IsSetUtteranceString() => this.UtteranceString != null;
    }
}
