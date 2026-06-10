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
    /// The Oracle Application Express (APEX) details for an Autonomous Database.
    /// </summary>
    public partial class AutonomousDatabaseApex
    {
        private string _apexVersion;
        private string _ordsVersion;

        /// <summary>
        /// Gets and sets the property ApexVersion. 
        /// <para>
        /// The Oracle Application Express (APEX) version of the Autonomous Database.
        /// </para>
        /// </summary>
        public string ApexVersion
        {
            get { return this._apexVersion; }
            set { this._apexVersion = value; }
        }

        // Check to see if ApexVersion property is set
        internal bool IsSetApexVersion()
        {
            return this._apexVersion != null;
        }

        /// <summary>
        /// Gets and sets the property OrdsVersion. 
        /// <para>
        /// The Oracle REST Data Services (ORDS) version of the Autonomous Database.
        /// </para>
        /// </summary>
        public string OrdsVersion
        {
            get { return this._ordsVersion; }
            set { this._ordsVersion = value; }
        }

        // Check to see if OrdsVersion property is set
        internal bool IsSetOrdsVersion()
        {
            return this._ordsVersion != null;
        }

    }
}