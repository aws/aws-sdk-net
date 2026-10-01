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
    /// The parameters for Amazon Redshift. The <c>ClusterId</c> field can be blank if <c>Host</c>
    /// and <c>Port</c> are both set. The <c>Host</c> and <c>Port</c> fields can be blank
    /// if the <c>ClusterId</c> field is set.
    /// </summary>
    public partial class RedshiftParameters
    {
        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// Cluster ID. This field can be blank if the <c>Host</c> and <c>Port</c> are provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// Database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property Host. 
        /// <para>
        /// Host. This field can be blank if <c>ClusterId</c> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Host { get; set; }

        /// <summary>
        /// Checks to see if the Host property is set.
        /// </summary>
        internal bool IsSetHost() => this.Host != null;

        /// <summary>
        /// Gets and sets the property IAMParameters. 
        /// <para>
        /// An optional parameter that uses IAM authentication to grant Quick Sight access to
        /// your cluster. This parameter can be used instead of <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DataSourceCredentials.html">DataSourceCredentials</a>.
        /// </para>
        /// </summary>
        public RedshiftIAMParameters IAMParameters { get; set; }

        /// <summary>
        /// Checks to see if the IAMParameters property is set.
        /// </summary>
        internal bool IsSetIAMParameters() => this.IAMParameters != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        /// An optional parameter that configures IAM Identity Center authentication to grant
        /// Quick Sight access to your cluster.
        /// </para>
        ///  
        /// <para>
        /// This parameter can only be specified if your Quick Sight account is configured with
        /// IAM Identity Center.
        /// </para>
        /// </summary>
        public IdentityCenterConfiguration IdentityCenterConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterConfiguration property is set.
        /// </summary>
        internal bool IsSetIdentityCenterConfiguration() => this.IdentityCenterConfiguration != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Port. This field can be blank if the <c>ClusterId</c> is provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 65535)]
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;
    }
}
