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

namespace Amazon.Odb.Model
{
    /// <summary>
    /// A summary of a peer database of an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabasePeerSummary
    {
        /// <summary>
        /// Gets and sets the property AutonomousDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string AutonomousDatabaseArn { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseArn property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseArn() => this.AutonomousDatabaseArn != null;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 6, Max = 64)]
        public string AutonomousDatabaseId { get; set; }

        /// <summary>
        /// Checks to see if the AutonomousDatabaseId property is set.
        /// </summary>
        internal bool IsSetAutonomousDatabaseId() => this.AutonomousDatabaseId != null;

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the peer Autonomous Database.
        /// </para>
        /// </summary>
        public string Ocid { get; set; }

        /// <summary>
        /// Checks to see if the Ocid property is set.
        /// </summary>
        internal bool IsSetOcid() => this.Ocid != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the peer Autonomous Database is located.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;
    }
}
