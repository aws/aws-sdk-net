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
    /// Represents the continuous backups and point in time recovery settings on the table.
    /// </summary>
    public partial class ContinuousBackupsDescription
    {
        /// <summary>
        /// Gets and sets the property ContinuousBackupsStatus. 
        /// <para>
        ///  <c>ContinuousBackupsStatus</c> can be one of the following states: ENABLED, DISABLED
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContinuousBackupsStatus ContinuousBackupsStatus { get; set; }

        /// <summary>
        /// Checks to see if the ContinuousBackupsStatus property is set.
        /// </summary>
        internal bool IsSetContinuousBackupsStatus() => this.ContinuousBackupsStatus != null;

        /// <summary>
        /// Gets and sets the property PointInTimeRecoveryDescription. 
        /// <para>
        /// The description of the point in time recovery settings applied to the table.
        /// </para>
        /// </summary>
        public PointInTimeRecoveryDescription PointInTimeRecoveryDescription { get; set; }

        /// <summary>
        /// Checks to see if the PointInTimeRecoveryDescription property is set.
        /// </summary>
        internal bool IsSetPointInTimeRecoveryDescription() => this.PointInTimeRecoveryDescription != null;
    }
}
