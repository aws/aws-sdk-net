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
    /// The configuration of the data source.
    /// </summary>
    public partial class DataSourceConfigurationInput
    {
        private GlueRunConfigurationInput _glueRunConfiguration;
        private RedshiftRunConfigurationInput _redshiftRunConfiguration;
        private SageMakerRunConfigurationInput _sageMakerRunConfiguration;

        /// <summary>
        /// Gets and sets the property GlueRunConfiguration. 
        /// <para>
        /// The configuration of the Amazon Web Services Glue data source.
        /// </para>
        /// </summary>
        public GlueRunConfigurationInput GlueRunConfiguration
        {
            get { return this._glueRunConfiguration; }
            set { this._glueRunConfiguration = value; }
        }

        // Check to see if GlueRunConfiguration property is set
        internal bool IsSetGlueRunConfiguration()
        {
            return this._glueRunConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RedshiftRunConfiguration. 
        /// <para>
        /// The configuration of the Amazon Redshift data source.
        /// </para>
        /// </summary>
        public RedshiftRunConfigurationInput RedshiftRunConfiguration
        {
            get { return this._redshiftRunConfiguration; }
            set { this._redshiftRunConfiguration = value; }
        }

        // Check to see if RedshiftRunConfiguration property is set
        internal bool IsSetRedshiftRunConfiguration()
        {
            return this._redshiftRunConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerRunConfiguration. 
        /// <para>
        /// The Amazon SageMaker run configuration.
        /// </para>
        /// </summary>
        public SageMakerRunConfigurationInput SageMakerRunConfiguration
        {
            get { return this._sageMakerRunConfiguration; }
            set { this._sageMakerRunConfiguration = value; }
        }

        // Check to see if SageMakerRunConfiguration property is set
        internal bool IsSetSageMakerRunConfiguration()
        {
            return this._sageMakerRunConfiguration != null;
        }

    }
}