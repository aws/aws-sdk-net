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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// The object used for specifying the data range that the customer wants Amazon Lex to
    /// read through in the input transcripts.
    /// </summary>
    public partial class DateRangeFilter
    {
        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// A timestamp indicating the end date for the date range filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndDateTime { get; set; }

        /// <summary>
        /// Checks to see if the EndDateTime property is set.
        /// </summary>
        internal bool IsSetEndDateTime() => this.EndDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// A timestamp indicating the start date for the date range filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartDateTime { get; set; }

        /// <summary>
        /// Checks to see if the StartDateTime property is set.
        /// </summary>
        internal bool IsSetStartDateTime() => this.StartDateTime.HasValue;
    }
}
