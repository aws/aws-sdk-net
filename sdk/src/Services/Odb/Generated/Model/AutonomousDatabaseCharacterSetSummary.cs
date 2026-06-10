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
    /// A summary of an available character set for Autonomous Databases.
    /// </summary>
    public partial class AutonomousDatabaseCharacterSetSummary
    {
        private string _characterSet;

        /// <summary>
        /// Gets and sets the property CharacterSet. 
        /// <para>
        /// The name of the character set.
        /// </para>
        /// </summary>
        public string CharacterSet
        {
            get { return this._characterSet; }
            set { this._characterSet = value; }
        }

        // Check to see if CharacterSet property is set
        internal bool IsSetCharacterSet()
        {
            return this._characterSet != null;
        }

    }
}