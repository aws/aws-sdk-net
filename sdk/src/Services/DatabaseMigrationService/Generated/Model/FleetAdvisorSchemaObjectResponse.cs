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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a schema object in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class FleetAdvisorSchemaObjectResponse
    {
        private long? _codeLineCount;
        private long? _codeSize;
        private long? _numberOfObjects;
        private string _objectType;
        private string _schemaId;

        /// <summary>
        /// Gets and sets the property CodeLineCount. 
        /// <para>
        /// The number of lines of code in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeLineCount
        {
            get { return this._codeLineCount; }
            set { this._codeLineCount = value; }
        }

        // Check to see if CodeLineCount property is set
        internal bool IsSetCodeLineCount()
        {
            return this._codeLineCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size level of the code in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeSize
        {
            get { return this._codeSize; }
            set { this._codeSize = value; }
        }

        // Check to see if CodeSize property is set
        internal bool IsSetCodeSize()
        {
            return this._codeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfObjects. 
        /// <para>
        /// The number of objects in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? NumberOfObjects
        {
            get { return this._numberOfObjects; }
            set { this._numberOfObjects = value; }
        }

        // Check to see if NumberOfObjects property is set
        internal bool IsSetNumberOfObjects()
        {
            return this._numberOfObjects.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectType. 
        /// <para>
        /// The type of the schema object, as reported by the database engine. Examples include
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>trigger</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SYSTEM_TABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>QUEUE</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ObjectType
        {
            get { return this._objectType; }
            set { this._objectType = value; }
        }

        // Check to see if ObjectType property is set
        internal bool IsSetObjectType()
        {
            return this._objectType != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The ID of a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaId
        {
            get { return this._schemaId; }
            set { this._schemaId = value; }
        }

        // Check to see if SchemaId property is set
        internal bool IsSetSchemaId()
        {
            return this._schemaId != null;
        }

    }
}