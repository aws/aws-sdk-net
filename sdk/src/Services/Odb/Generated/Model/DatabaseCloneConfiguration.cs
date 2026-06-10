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
    /// The configuration for creating an Autonomous Database as a clone of an existing database.
    /// </summary>
    public partial class DatabaseCloneConfiguration
    {
        private CloneType _cloneType;
        private string _sourceAutonomousDatabaseId;

        /// <summary>
        /// Gets and sets the property CloneType. 
        /// <para>
        /// The type of clone to create, either a full clone, a metadata clone, or a partial clone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CloneType CloneType
        {
            get { return this._cloneType; }
            set { this._cloneType = value; }
        }

        // Check to see if CloneType property is set
        internal bool IsSetCloneType()
        {
            return this._cloneType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the source Autonomous Database to clone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string SourceAutonomousDatabaseId
        {
            get { return this._sourceAutonomousDatabaseId; }
            set { this._sourceAutonomousDatabaseId = value; }
        }

        // Check to see if SourceAutonomousDatabaseId property is set
        internal bool IsSetSourceAutonomousDatabaseId()
        {
            return this._sourceAutonomousDatabaseId != null;
        }

    }
}