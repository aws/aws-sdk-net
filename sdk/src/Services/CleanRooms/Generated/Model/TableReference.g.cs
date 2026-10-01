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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A pointer to the dataset that underlies this table.
    /// </summary>
    public partial class TableReference
    {
        /// <summary>
        /// Gets and sets the property Athena. 
        /// <para>
        ///  If present, a reference to the Athena table referred to by this table reference.
        /// </para>
        /// </summary>
        public AthenaTableReference Athena { get; set; }

        /// <summary>
        /// Checks to see if the Athena property is set.
        /// </summary>
        internal bool IsSetAthena() => this.Athena != null;

        /// <summary>
        /// Gets and sets the property Glue. 
        /// <para>
        /// If present, a reference to the Glue table referred to by this table reference.
        /// </para>
        /// </summary>
        public GlueTableReference Glue { get; set; }

        /// <summary>
        /// Checks to see if the Glue property is set.
        /// </summary>
        internal bool IsSetGlue() => this.Glue != null;

        /// <summary>
        /// Gets and sets the property Snowflake. 
        /// <para>
        ///  If present, a reference to the Snowflake table referred to by this table reference.
        /// </para>
        /// </summary>
        public SnowflakeTableReference Snowflake { get; set; }

        /// <summary>
        /// Checks to see if the Snowflake property is set.
        /// </summary>
        internal bool IsSetSnowflake() => this.Snowflake != null;
    }
}
