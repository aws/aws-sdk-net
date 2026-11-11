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

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The description of the Time to Live (TTL) status on the specified table.
    /// </summary>
    public partial class TimeToLiveDescription
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        ///  The name of the TTL attribute for items in the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property TimeToLiveStatus. 
        /// <para>
        ///  The TTL status for the table.
        /// </para>
        /// </summary>
        public TimeToLiveStatus TimeToLiveStatus { get; set; }

        /// <summary>
        /// Checks to see if the TimeToLiveStatus property is set.
        /// </summary>
        internal bool IsSetTimeToLiveStatus() => this.TimeToLiveStatus != null;
    }
}
