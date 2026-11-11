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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// This is the response object from the ModifyLakehouseConfiguration operation.
    /// </summary>
    public partial class ModifyLakehouseConfigurationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Glue data catalog associated with the lakehouse
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string CatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the CatalogArn property is set.
        /// </summary>
        internal bool IsSetCatalogArn() => this.CatalogArn != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster associated with this lakehouse configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property LakehouseIdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application used for enabling
        /// Amazon Web Services IAM Identity Center trusted identity propagation on a cluster
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string LakehouseIdcApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseIdcApplicationArn property is set.
        /// </summary>
        internal bool IsSetLakehouseIdcApplicationArn() => this.LakehouseIdcApplicationArn != null;

        /// <summary>
        /// Gets and sets the property LakehouseRegistrationStatus. 
        /// <para>
        /// The current status of the lakehouse registration. Indicates whether the cluster is
        /// successfully registered with the lakehouse.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string LakehouseRegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the LakehouseRegistrationStatus property is set.
        /// </summary>
        internal bool IsSetLakehouseRegistrationStatus() => this.LakehouseRegistrationStatus != null;
    }
}
