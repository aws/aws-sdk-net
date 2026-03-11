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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Contains configuration information for lakehouse integration, including the cluster
    /// identifier, catalog ARN, and registration status.
    /// </summary>
    public partial class ModifyLakehouseConfigurationResponse : AmazonWebServiceResponse
    {
        private string _catalogArn;
        private string _clusterIdentifier;
        private string _lakehouseIdcApplicationArn;
        private string _lakehouseRegistrationStatus;

        /// <summary>
        /// Gets and sets the property CatalogArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Glue data catalog associated with the lakehouse
        /// configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string CatalogArn
        {
            get { return this._catalogArn; }
            set { this._catalogArn = value; }
        }

        // Check to see if CatalogArn property is set
        internal bool IsSetCatalogArn()
        {
            return this._catalogArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The unique identifier of the cluster associated with this lakehouse configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property LakehouseIdcApplicationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center application used for enabling
        /// Amazon Web Services IAM Identity Center trusted identity propagation on a cluster
        /// enabled with Amazon Redshift federated permissions.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
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
        /// Gets and sets the property LakehouseRegistrationStatus. 
        /// <para>
        /// The current status of the lakehouse registration. Indicates whether the cluster is
        /// successfully registered with the lakehouse.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string LakehouseRegistrationStatus
        {
            get { return this._lakehouseRegistrationStatus; }
            set { this._lakehouseRegistrationStatus = value; }
        }

        // Check to see if LakehouseRegistrationStatus property is set
        internal bool IsSetLakehouseRegistrationStatus()
        {
            return this._lakehouseRegistrationStatus != null;
        }

    }
}