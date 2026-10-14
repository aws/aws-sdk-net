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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies an Amazon Redshift data store.
    /// </summary>
    public partial class RedshiftSource
    {
        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the Amazon Redshift data store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RedshiftTmpDir. 
        /// <para>
        /// The Amazon S3 path where temporary data can be staged when copying out of the database.
        /// </para>
        /// </summary>
        public string RedshiftTmpDir { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftTmpDir property is set.
        /// </summary>
        internal bool IsSetRedshiftTmpDir() => this.RedshiftTmpDir != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The database table to read from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property TmpDirIAMRole. 
        /// <para>
        /// The IAM role with permissions.
        /// </para>
        /// </summary>
        public string TmpDirIAMRole { get; set; }

        /// <summary>
        /// Checks to see if the TmpDirIAMRole property is set.
        /// </summary>
        internal bool IsSetTmpDirIAMRole() => this.TmpDirIAMRole != null;
    }
}
