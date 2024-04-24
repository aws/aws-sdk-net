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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// Specifies the configuration that Amazon AppFlow uses when it catalogs your data with
    /// the Glue Data Catalog. When Amazon AppFlow catalogs your data, it stores metadata
    /// in Data Catalog tables. This metadata represents the data that's transferred by the
    /// flow that you configure with these settings.
    /// 
    ///  <note> 
    /// <para>
    /// You can configure a flow with these settings only when the flow destination is Amazon
    /// S3.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GlueDataCatalogConfig
    {
        private string _databaseName;
        private string _roleArn;
        private string _tablePrefix;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Data Catalog database that stores the metadata tables that Amazon
        /// AppFlow creates in your Amazon Web Services account. These tables contain metadata
        /// for the data that's transferred by the flow that you configure with this parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you configure a new flow with this parameter, you must specify an existing database.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that grants Amazon AppFlow the permissions
        /// it needs to create Data Catalog tables, databases, and partitions.
        /// </para>
        ///  
        /// <para>
        /// For an example IAM policy that has the required permissions, see <a href="https://docs.aws.amazon.com/appflow/latest/userguide/security_iam_id-based-policy-examples.html">Identity-based
        /// policy examples for Amazon AppFlow</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=512)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TablePrefix. 
        /// <para>
        /// A naming prefix for each Data Catalog table that Amazon AppFlow creates for the flow
        /// that you configure with this setting. Amazon AppFlow adds the prefix to the beginning
        /// of the each table name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string TablePrefix
        {
            get { return this._tablePrefix; }
            set { this._tablePrefix = value; }
        }

        // Check to see if TablePrefix property is set
        internal bool IsSetTablePrefix()
        {
            return this._tablePrefix != null;
        }

    }
}