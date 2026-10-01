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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The connection properties patch.
    /// </summary>
    public partial class ConnectionPropertiesPatch
    {
        /// <summary>
        /// Gets and sets the property AmazonQProperties. 
        /// <para>
        /// The Amazon Q properties of the connection.
        /// </para>
        /// </summary>
        public AmazonQPropertiesPatch AmazonQProperties { get; set; }

        /// <summary>
        /// Checks to see if the AmazonQProperties property is set.
        /// </summary>
        internal bool IsSetAmazonQProperties() => this.AmazonQProperties != null;

        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// The Amazon Athena properties of a connection properties patch.
        /// </para>
        /// </summary>
        public AthenaPropertiesPatch AthenaProperties { get; set; }

        /// <summary>
        /// Checks to see if the AthenaProperties property is set.
        /// </summary>
        internal bool IsSetAthenaProperties() => this.AthenaProperties != null;

        /// <summary>
        /// Gets and sets the property GitProperties. 
        /// <para>
        /// The Git properties of a connection properties patch.
        /// </para>
        /// </summary>
        public GitPropertiesPatch GitProperties { get; set; }

        /// <summary>
        /// Checks to see if the GitProperties property is set.
        /// </summary>
        internal bool IsSetGitProperties() => this.GitProperties != null;

        /// <summary>
        /// Gets and sets the property GlueProperties. 
        /// <para>
        /// The Amazon Web Services Glue properties of a connection properties patch.
        /// </para>
        /// </summary>
        public GluePropertiesPatch GlueProperties { get; set; }

        /// <summary>
        /// Checks to see if the GlueProperties property is set.
        /// </summary>
        internal bool IsSetGlueProperties() => this.GlueProperties != null;

        /// <summary>
        /// Gets and sets the property IamProperties. 
        /// <para>
        /// The IAM properties of a connection properties patch.
        /// </para>
        /// </summary>
        public IamPropertiesPatch IamProperties { get; set; }

        /// <summary>
        /// Checks to see if the IamProperties property is set.
        /// </summary>
        internal bool IsSetIamProperties() => this.IamProperties != null;

        /// <summary>
        /// Gets and sets the property LakehouseProperties. 
        /// <para>
        /// The lakehouse properties of a connection properties patch.
        /// </para>
        /// </summary>
        public LakehousePropertiesPatch LakehouseProperties { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseProperties property is set.
        /// </summary>
        internal bool IsSetLakehouseProperties() => this.LakehouseProperties != null;

        /// <summary>
        /// Gets and sets the property MlflowProperties. 
        /// <para>
        /// The MLflow properties of a connection.
        /// </para>
        /// </summary>
        public MlflowPropertiesPatch MlflowProperties { get; set; }

        /// <summary>
        /// Checks to see if the MlflowProperties property is set.
        /// </summary>
        internal bool IsSetMlflowProperties() => this.MlflowProperties != null;

        /// <summary>
        /// Gets and sets the property RedshiftProperties. 
        /// <para>
        /// The Amazon Redshift properties of a connection properties patch.
        /// </para>
        /// </summary>
        public RedshiftPropertiesPatch RedshiftProperties { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftProperties property is set.
        /// </summary>
        internal bool IsSetRedshiftProperties() => this.RedshiftProperties != null;

        /// <summary>
        /// Gets and sets the property S3Properties. 
        /// <para>
        /// The Amazon S3 properties of a connection properties patch.
        /// </para>
        /// </summary>
        public S3PropertiesPatch S3Properties { get; set; }

        /// <summary>
        /// Checks to see if the S3Properties property is set.
        /// </summary>
        internal bool IsSetS3Properties() => this.S3Properties != null;

        /// <summary>
        /// Gets and sets the property SnowflakeProperties. 
        /// <para>
        /// The Snowflake-specific connection properties to update.
        /// </para>
        /// </summary>
        public SnowflakePropertiesPatch SnowflakeProperties { get; set; }

        /// <summary>
        /// Checks to see if the SnowflakeProperties property is set.
        /// </summary>
        internal bool IsSetSnowflakeProperties() => this.SnowflakeProperties != null;

        /// <summary>
        /// Gets and sets the property SparkEmrProperties. 
        /// <para>
        /// The Spark EMR properties of a connection properties patch.
        /// </para>
        /// </summary>
        public SparkEmrPropertiesPatch SparkEmrProperties { get; set; }

        /// <summary>
        /// Checks to see if the SparkEmrProperties property is set.
        /// </summary>
        internal bool IsSetSparkEmrProperties() => this.SparkEmrProperties != null;

        /// <summary>
        /// Gets and sets the property VpcProperties. 
        /// <para>
        /// The VPC properties of a connection properties patch.
        /// </para>
        /// </summary>
        public VpcPropertiesPatch VpcProperties { get; set; }

        /// <summary>
        /// Checks to see if the VpcProperties property is set.
        /// </summary>
        internal bool IsSetVpcProperties() => this.VpcProperties != null;
    }
}
