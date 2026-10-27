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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Describes a schema object in a Fleet Advisor collector inventory.
    /// </summary>
    public partial class FleetAdvisorSchemaObjectResponse
    {
        /// <summary>
        /// Gets and sets the property CodeLineCount. 
        /// <para>
        /// The number of lines of code in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeLineCount { get; set; }

        /// <summary>
        /// Checks to see if the CodeLineCount property is set.
        /// </summary>
        internal bool IsSetCodeLineCount() => this.CodeLineCount.HasValue;

        /// <summary>
        /// Gets and sets the property CodeSize. 
        /// <para>
        /// The size level of the code in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? CodeSize { get; set; }

        /// <summary>
        /// Checks to see if the CodeSize property is set.
        /// </summary>
        internal bool IsSetCodeSize() => this.CodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property NumberOfObjects. 
        /// <para>
        /// The number of objects in a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public long? NumberOfObjects { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfObjects property is set.
        /// </summary>
        internal bool IsSetNumberOfObjects() => this.NumberOfObjects.HasValue;

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
        public string ObjectType { get; set; }

        /// <summary>
        /// Checks to see if the ObjectType property is set.
        /// </summary>
        internal bool IsSetObjectType() => this.ObjectType != null;

        /// <summary>
        /// Gets and sets the property SchemaId. 
        /// <para>
        /// The ID of a schema object in a Fleet Advisor collector inventory.
        /// </para>
        /// </summary>
        public string SchemaId { get; set; }

        /// <summary>
        /// Checks to see if the SchemaId property is set.
        /// </summary>
        internal bool IsSetSchemaId() => this.SchemaId != null;
    }
}
