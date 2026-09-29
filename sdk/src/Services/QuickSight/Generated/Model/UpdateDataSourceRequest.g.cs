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
    /// Container for the parameters to the UpdateDataSource operation. Updates a data source.
    /// </summary>
    public partial class UpdateDataSourceRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials that Amazon Quick Sight that uses to connect to your underlying source.
        /// Currently, only credentials based on user name and password are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public DataSourceCredentials Credentials { get; set; }

        /// <summary>
        /// Checks to see if the Credentials property is set.
        /// </summary>
        internal bool IsSetCredentials() => this.Credentials != null;

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// The ID of the data source. This ID is unique per Amazon Web Services Region for each
        /// Amazon Web Services account. 
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
        /// <para>
        /// The parameters that Amazon Quick Sight uses to connect to your underlying source.
        /// </para>
        /// </summary>
        public DataSourceParameters DataSourceParameters { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceParameters property is set.
        /// </summary>
        internal bool IsSetDataSourceParameters() => this.DataSourceParameters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SslProperties. 
        /// <para>
        /// Secure Socket Layer (SSL) properties that apply when Amazon Quick Sight connects to
        /// your underlying source.
        /// </para>
        /// </summary>
        public SslProperties SslProperties { get; set; }

        /// <summary>
        /// Checks to see if the SslProperties property is set.
        /// </summary>
        internal bool IsSetSslProperties() => this.SslProperties != null;

        /// <summary>
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// Use this parameter only when you want Amazon Quick Sight to use a VPC connection when
        /// connecting to your underlying source.
        /// </para>
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the VpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetVpcConnectionProperties() => this.VpcConnectionProperties != null;
    }
}
