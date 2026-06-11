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
    /// A summary of an available Oracle Database software version for Autonomous Databases.
    /// </summary>
    public partial class AutonomousDatabaseVersionSummary
    {
        private DbWorkload _dbWorkload;
        private string _details;
        private string _version;

        /// <summary>
        /// Gets and sets the property DbWorkload. 
        /// <para>
        /// The intended use of the Autonomous Database that the version supports, such as transaction
        /// processing, data warehouse, JSON database, or APEX.
        /// </para>
        /// </summary>
        public DbWorkload DbWorkload
        {
            get { return this._dbWorkload; }
            set { this._dbWorkload = value; }
        }

        // Check to see if DbWorkload property is set
        internal bool IsSetDbWorkload()
        {
            return this._dbWorkload != null;
        }

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details about the Autonomous Database software version.
        /// </para>
        /// </summary>
        public string Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The Oracle Database software version.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

    }
}