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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
    /// Container for the parameters to the UpdateLakehouseConfiguration operation.
    /// Modifies the lakehouse configuration for a namespace. This operation allows you to
    /// manage Amazon Redshift federated permissions and Amazon Web Services IAM Identity
    /// Center trusted identity propagation.
    /// </summary>
    public partial class UpdateLakehouseConfigurationRequest : AmazonRedshiftServerlessRequest
    {
        private string _catalogName;
        private bool? _dryRun;
        private string _lakehouseIdcApplicationArn;
        private LakehouseIdcRegistration _lakehouseIdcRegistration;
        private LakehouseRegistration _lakehouseRegistration;
        private string _namespaceName;

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
        [AWSProperty(Min=1, Max=64)]
        public string CatalogName
        {
            get { return this._catalogName; }
            set { this._catalogName = value; }
        }

        // Check to see if CatalogName property is set
        internal bool IsSetCatalogName()
        {
            return this._catalogName != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// A boolean value that, if <c>true</c>, validates the request without actually updating
        /// the lakehouse configuration. Use this to check for errors before making changes.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LakehouseIdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application used for enabling
        /// Amazon Web Services IAM Identity Center trusted identity propagation on a namespace
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        public string LakehouseIdcApplicationArn
        {
            get { return this._lakehouseIdcApplicationArn; }
            set { this._lakehouseIdcApplicationArn = value; }
        }

        // Check to see if LakehouseIdcApplicationArn property is set
        internal bool IsSetLakehouseIdcApplicationArn()
        {
            return this._lakehouseIdcApplicationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LakehouseIdcRegistration. 
        /// <para>
        /// Modifies the Amazon Web Services IAM Identity Center trusted identity propagation
        /// on a namespace enabled with Amazon Redshift federated permissions. Valid values are
        /// <c>Associate</c> or <c>Disassociate</c>.
        /// </para>
        /// </summary>
        public LakehouseIdcRegistration LakehouseIdcRegistration
        {
            get { return this._lakehouseIdcRegistration; }
            set { this._lakehouseIdcRegistration = value; }
        }

        // Check to see if LakehouseIdcRegistration property is set
        internal bool IsSetLakehouseIdcRegistration()
        {
            return this._lakehouseIdcRegistration != null;
        }

        /// <summary>
        /// Gets and sets the property LakehouseRegistration. 
        /// <para>
        /// Specifies whether to register or deregister the namespace with Amazon Redshift federated
        /// permissions. Valid values are <c>Register</c> or <c>Deregister</c>.
        /// </para>
        /// </summary>
        public LakehouseRegistration LakehouseRegistration
        {
            get { return this._lakehouseRegistration; }
            set { this._lakehouseRegistration = value; }
        }

        // Check to see if LakehouseRegistration property is set
        internal bool IsSetLakehouseRegistration()
        {
            return this._lakehouseRegistration != null;
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace whose lakehouse configuration you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

    }
}