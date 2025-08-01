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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
    /// The properties of a connection.
    /// </summary>
    public partial class ConnectionPropertiesOutput
    {
        private AthenaPropertiesOutput _athenaProperties;
        private GluePropertiesOutput _glueProperties;
        private HyperPodPropertiesOutput _hyperPodProperties;
        private IamPropertiesOutput _iamProperties;
        private RedshiftPropertiesOutput _redshiftProperties;
        private S3PropertiesOutput _s3Properties;
        private SparkEmrPropertiesOutput _sparkEmrProperties;
        private SparkGluePropertiesOutput _sparkGlueProperties;

        /// <summary>
        /// Gets and sets the property AthenaProperties. 
        /// <para>
        /// The Amazon Athena properties of a connection.
        /// </para>
        /// </summary>
        public AthenaPropertiesOutput AthenaProperties
        {
            get { return this._athenaProperties; }
            set { this._athenaProperties = value; }
        }

        // Check to see if AthenaProperties property is set
        internal bool IsSetAthenaProperties()
        {
            return this._athenaProperties != null;
        }

        /// <summary>
        /// Gets and sets the property GlueProperties. 
        /// <para>
        /// The Amazon Web Services Glue properties of a connection.
        /// </para>
        /// </summary>
        public GluePropertiesOutput GlueProperties
        {
            get { return this._glueProperties; }
            set { this._glueProperties = value; }
        }

        // Check to see if GlueProperties property is set
        internal bool IsSetGlueProperties()
        {
            return this._glueProperties != null;
        }

        /// <summary>
        /// Gets and sets the property HyperPodProperties. 
        /// <para>
        /// The hyper pod properties of a connection.
        /// </para>
        /// </summary>
        public HyperPodPropertiesOutput HyperPodProperties
        {
            get { return this._hyperPodProperties; }
            set { this._hyperPodProperties = value; }
        }

        // Check to see if HyperPodProperties property is set
        internal bool IsSetHyperPodProperties()
        {
            return this._hyperPodProperties != null;
        }

        /// <summary>
        /// Gets and sets the property IamProperties. 
        /// <para>
        /// The IAM properties of a connection.
        /// </para>
        /// </summary>
        public IamPropertiesOutput IamProperties
        {
            get { return this._iamProperties; }
            set { this._iamProperties = value; }
        }

        // Check to see if IamProperties property is set
        internal bool IsSetIamProperties()
        {
            return this._iamProperties != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftProperties. 
        /// <para>
        /// The Amazon Redshift properties of a connection.
        /// </para>
        /// </summary>
        public RedshiftPropertiesOutput RedshiftProperties
        {
            get { return this._redshiftProperties; }
            set { this._redshiftProperties = value; }
        }

        // Check to see if RedshiftProperties property is set
        internal bool IsSetRedshiftProperties()
        {
            return this._redshiftProperties != null;
        }

        /// <summary>
        /// Gets and sets the property S3Properties. 
        /// <para>
        /// The Amazon S3 properties of a connection.
        /// </para>
        /// </summary>
        public S3PropertiesOutput S3Properties
        {
            get { return this._s3Properties; }
            set { this._s3Properties = value; }
        }

        // Check to see if S3Properties property is set
        internal bool IsSetS3Properties()
        {
            return this._s3Properties != null;
        }

        /// <summary>
        /// Gets and sets the property SparkEmrProperties. 
        /// <para>
        /// The Spark EMR properties of a connection.
        /// </para>
        /// </summary>
        public SparkEmrPropertiesOutput SparkEmrProperties
        {
            get { return this._sparkEmrProperties; }
            set { this._sparkEmrProperties = value; }
        }

        // Check to see if SparkEmrProperties property is set
        internal bool IsSetSparkEmrProperties()
        {
            return this._sparkEmrProperties != null;
        }

        /// <summary>
        /// Gets and sets the property SparkGlueProperties. 
        /// <para>
        /// The Spark Amazon Web Services Glue properties of a connection.
        /// </para>
        /// </summary>
        public SparkGluePropertiesOutput SparkGlueProperties
        {
            get { return this._sparkGlueProperties; }
            set { this._sparkGlueProperties = value; }
        }

        // Check to see if SparkGlueProperties property is set
        internal bool IsSetSparkGlueProperties()
        {
            return this._sparkGlueProperties != null;
        }

    }
}