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
    /// The configuration of the data source.
    /// </summary>
    public partial class DataSourceConfigurationInput
    {
        /// <summary>
        /// Gets and sets the property GlueRunConfiguration. 
        /// <para>
        /// The configuration of the Amazon Web Services Glue data source.
        /// </para>
        /// </summary>
        public GlueRunConfigurationInput GlueRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the GlueRunConfiguration property is set.
        /// </summary>
        internal bool IsSetGlueRunConfiguration() => this.GlueRunConfiguration != null;

        /// <summary>
        /// Gets and sets the property RedshiftRunConfiguration. 
        /// <para>
        /// The configuration of the Amazon Redshift data source.
        /// </para>
        /// </summary>
        public RedshiftRunConfigurationInput RedshiftRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RedshiftRunConfiguration property is set.
        /// </summary>
        internal bool IsSetRedshiftRunConfiguration() => this.RedshiftRunConfiguration != null;

        /// <summary>
        /// Gets and sets the property SageMakerRunConfiguration. 
        /// <para>
        /// The Amazon SageMaker run configuration.
        /// </para>
        /// </summary>
        public SageMakerRunConfigurationInput SageMakerRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerRunConfiguration property is set.
        /// </summary>
        internal bool IsSetSageMakerRunConfiguration() => this.SageMakerRunConfiguration != null;
    }
}
