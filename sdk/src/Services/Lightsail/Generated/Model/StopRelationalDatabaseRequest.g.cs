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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the StopRelationalDatabase operation. Stops a specific
    /// database that is currently running in Amazon Lightsail. <note> <para> If you don't
    /// manually start your database instance after it has been stopped for seven consecutive
    /// days, Amazon Lightsail automatically starts it for you. This action helps ensure that
    /// your database instance doesn't fall behind on any required maintenance updates. </para>
    /// </note> <para> The <c>stop relational database</c> operation supports tag-based access
    /// control via resource tags applied to the resource identified by relationalDatabaseName.
    /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>. </para>
    /// </summary>
    public partial class StopRelationalDatabaseRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your database to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RelationalDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseName property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseName() => this.RelationalDatabaseName != null;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseSnapshotName. 
        /// <para>
        /// The name of your new database snapshot to be created before stopping your database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseSnapshotName { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseSnapshotName property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseSnapshotName() => this.RelationalDatabaseSnapshotName != null;
    }
}
