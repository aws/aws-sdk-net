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
    /// This is the response object from the UpdateLakehouseConfiguration operation.
    /// </summary>
    public partial class UpdateLakehouseConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Glue Data Catalog associated with the lakehouse
        /// configuration.
        /// </para>
        /// </summary>
        public string CatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the CatalogArn property is set.
        /// </summary>
        internal bool IsSetCatalogArn() => this.CatalogArn != null;

        /// <summary>
        /// Gets and sets the property LakehouseIdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application used for enabling
        /// Amazon Web Services IAM Identity Center trusted identity propagation.
        /// </para>
        /// </summary>
        public string LakehouseIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetLakehouseIdcApplicationArn() => this.LakehouseIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property LakehouseRegistrationStatus. 
        /// <para>
        /// The current status of the lakehouse registration. Indicates whether the namespace
        /// is successfully registered with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        public string LakehouseRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetLakehouseRegistrationStatus() => this.LakehouseRegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 64)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// Checks to see if the NamespaceName property is set.
        /// </summary>
        internal bool IsSetNamespaceName() => this.NamespaceName != null;
    }
}
