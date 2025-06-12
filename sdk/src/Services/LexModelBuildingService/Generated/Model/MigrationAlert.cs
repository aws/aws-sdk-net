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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Provides information about alerts and warnings that Amazon Lex sends during a migration.
    /// The alerts include information about how to resolve the issue.
    /// </summary>
    public partial class MigrationAlert
    {
        private List<string> _details = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _message;
        private List<string> _referenceurLs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MigrationAlertType _type;

        /// <summary>
        /// Gets and sets the property Details. 
        /// <para>
        /// Additional details about the alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Details
        {
            get { return this._details; }
            set { this._details = value; }
        }

        // Check to see if Details property is set
        internal bool IsSetDetails()
        {
            return this._details != null && (this._details.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message that describes why the alert was issued.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceURLs. 
        /// <para>
        /// A link to the Amazon Lex documentation that describes how to resolve the alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ReferenceURLs
        {
            get { return this._referenceurLs; }
            set { this._referenceurLs = value; }
        }

        // Check to see if ReferenceURLs property is set
        internal bool IsSetReferenceURLs()
        {
            return this._referenceurLs != null && (this._referenceurLs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of alert. There are two kinds of alerts:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ERROR</c> - There was an issue with the migration that can't be resolved. The
        /// migration stops.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>WARN</c> - There was an issue with the migration that requires manual changes
        /// to the new Amazon Lex V2 bot. The migration continues.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MigrationAlertType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}