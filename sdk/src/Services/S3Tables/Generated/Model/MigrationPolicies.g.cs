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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The policies for source data that doesn't fit the destination schema.
    /// </summary>
    public partial class MigrationPolicies
    {
        /// <summary>
        /// Gets and sets the property IncompatibleValuesPolicy. 
        /// <para>
        /// The migration policy for a source value that the destination column's type can't hold.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>fail</c> - Fails the migration. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>setNull</c> - Writes null for a value that the destination column's type can't
        /// hold. If a column's type in a source object is incompatible with the destination column's
        /// type, the column is null for that whole object.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A required column, or a type that migration doesn't support, fails the migration under
        /// either value.
        /// </para>
        /// </summary>
        public IncompatibleValuesPolicy IncompatibleValuesPolicy { get; set; }

        /// <summary>
        /// Checks to see if the IncompatibleValuesPolicy property is set.
        /// </summary>
        internal bool IsSetIncompatibleValuesPolicy() => this.IncompatibleValuesPolicy != null;

        /// <summary>
        /// Gets and sets the property UnmatchedSourceFieldsPolicy. 
        /// <para>
        /// The migration policy for a source field that has no matching column in the destination
        /// schema. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>fail</c> - Fails the migration. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>drop</c> - Leaves source columns that the destination schema doesn't have out
        /// of the destination table, and doesn't migrate source objects outside the Amazon Web
        /// Services Glue table's partition locations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// A destination schema that leaves out a partition column or a field of a struct column
        /// fails the migration under either value.
        /// </para>
        /// </summary>
        public UnmatchedSourceFieldsPolicy UnmatchedSourceFieldsPolicy { get; set; }

        /// <summary>
        /// Checks to see if the UnmatchedSourceFieldsPolicy property is set.
        /// </summary>
        internal bool IsSetUnmatchedSourceFieldsPolicy() => this.UnmatchedSourceFieldsPolicy != null;
    }
}
