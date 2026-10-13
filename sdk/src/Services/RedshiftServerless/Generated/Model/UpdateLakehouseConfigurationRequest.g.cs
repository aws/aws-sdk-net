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

namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateLakehouseConfiguration operation. Modifies
    /// the lakehouse configuration for a namespace. This operation allows you to manage Amazon
    /// Redshift federated permissions and Amazon Web Services IAM Identity Center trusted
    /// identity propagation.
    /// </summary>
    public partial class UpdateLakehouseConfigurationRequest : AmazonRedshiftServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogName. 
        /// <para>
        /// The name of the Glue Data Catalog that will be associated with the namespace enabled
        /// with Amazon Redshift federated permissions.
        /// </para>
        ///  
        /// <para>
        /// Pattern: <c>^[a-z0-9_-]*[a-z]+[a-z0-9_-]*$</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string CatalogName { get; set; }

        /// <summary>
        /// Checks to see if the CatalogName property is set.
        /// </summary>
        internal bool IsSetCatalogName() => this.CatalogName != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A boolean value that, if <c>true</c>, validates the request without actually updating
        /// the lakehouse configuration. Use this to check for errors before making changes.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property LakehouseIdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application used for enabling
        /// Amazon Web Services IAM Identity Center trusted identity propagation on a namespace
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        public string LakehouseIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetLakehouseIdcApplicationArn() => this.LakehouseIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property LakehouseIdcRegistration. 
        /// <para>
        /// Modifies the Amazon Web Services IAM Identity Center trusted identity propagation
        /// on a namespace enabled with Amazon Redshift federated permissions. Valid values are
        /// <c>Associate</c> or <c>Disassociate</c>.
        /// </para>
        /// </summary>
        public LakehouseIdcRegistration LakehouseIdcRegistration { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseIdcRegistration property is set.
        /// </summary>
        internal bool IsSetLakehouseIdcRegistration() => this.LakehouseIdcRegistration != null;

        /// <summary>
        /// Gets and sets the property LakehouseRegistration. 
        /// <para>
        /// Specifies whether to register or deregister the namespace with Amazon Redshift federated
        /// permissions. Valid values are <c>Register</c> or <c>Deregister</c>.
        /// </para>
        /// </summary>
        public LakehouseRegistration LakehouseRegistration { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseRegistration property is set.
        /// </summary>
        internal bool IsSetLakehouseRegistration() => this.LakehouseRegistration != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace whose lakehouse configuration you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;
    }
}
