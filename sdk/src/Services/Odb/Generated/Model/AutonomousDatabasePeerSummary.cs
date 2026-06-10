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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
        private string _autonomousDatabaseArn;
        private string _autonomousDatabaseId;
        private string _ocid;
        private string _region;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string AutonomousDatabaseArn
        {
            get { return this._autonomousDatabaseArn; }
            set { this._autonomousDatabaseArn = value; }
        }

        // Check to see if AutonomousDatabaseArn property is set
        internal bool IsSetAutonomousDatabaseArn()
        {
            return this._autonomousDatabaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the peer Autonomous Database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=6, Max=64)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property Ocid. 
        /// <para>
        /// The Oracle Cloud Identifier (OCID) of the peer Autonomous Database.
        /// </para>
        /// </summary>
        public string Ocid
        {
            get { return this._ocid; }
            set { this._ocid = value; }
        }

        // Check to see if Ocid property is set
        internal bool IsSetOcid()
        {
            return this._ocid != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region where the peer Autonomous Database is located.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}