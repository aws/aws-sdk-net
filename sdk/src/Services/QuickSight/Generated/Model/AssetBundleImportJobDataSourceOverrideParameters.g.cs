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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The override parameters for a single data source that is being imported.
    /// </summary>
    public partial class AssetBundleImportJobDataSourceOverrideParameters
    {
        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// An optional structure that provides the credentials to be used to create the imported
        /// data source.
        /// </para>
        /// </summary>
        public AssetBundleImportJobDataSourceCredentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source to apply overrides to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DataSourceId { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceId property is set.
        /// </summary>
        internal bool IsSetDataSourceId() => this.DataSourceId != null;

        /// <summary>
        /// Gets and sets the property DataSourceParameters.
        /// </summary>
        public DataSourceParameters DataSourceParameters { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceParameters property is set.
        /// </summary>
        internal bool IsSetDataSourceParameters() => this.DataSourceParameters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A new name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SslProperties.
        /// </summary>
        public SslProperties SslProperties { get; set; }

        /// <summary>
        /// Checks to see if the SslProperties property is set.
        /// </summary>
        internal bool IsSetSslProperties() => this.SslProperties != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetVpcConnectionProperties() => this.VpcConnectionProperties != null;
    }
}
