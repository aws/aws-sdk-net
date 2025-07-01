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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// The managed services configuration for the ODB network.
    /// </summary>
    public partial class ManagedServices
    {
        private ManagedS3BackupAccess _manageds3BackupAccess;
        private List<string> _managedServicesIpv4Cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _resourceGatewayArn;
        private S3Access _s3Access;
        private string _serviceNetworkArn;
        private ServiceNetworkEndpoint _serviceNetworkEndpoint;
        private ZeroEtlAccess _zeroEtlAccess;

        /// <summary>
        /// Gets and sets the property ManagedS3BackupAccess. 
        /// <para>
        /// The managed Amazon S3 backup access configuration.
        /// </para>
        /// </summary>
        public ManagedS3BackupAccess ManagedS3BackupAccess
        {
            get { return this._manageds3BackupAccess; }
            set { this._manageds3BackupAccess = value; }
        }

        // Check to see if ManagedS3BackupAccess property is set
        internal bool IsSetManagedS3BackupAccess()
        {
            return this._manageds3BackupAccess != null;
        }

        /// <summary>
        /// Gets and sets the property ManagedServicesIpv4Cidrs. 
        /// <para>
        /// The IPv4 CIDR blocks for the managed services.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public List<string> ManagedServicesIpv4Cidrs
        {
            get { return this._managedServicesIpv4Cidrs; }
            set { this._managedServicesIpv4Cidrs = value; }
        }

        // Check to see if ManagedServicesIpv4Cidrs property is set
        internal bool IsSetManagedServicesIpv4Cidrs()
        {
            return this._managedServicesIpv4Cidrs != null && (this._managedServicesIpv4Cidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceGatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceGatewayArn
        {
            get { return this._resourceGatewayArn; }
            set { this._resourceGatewayArn = value; }
        }

        // Check to see if ResourceGatewayArn property is set
        internal bool IsSetResourceGatewayArn()
        {
            return this._resourceGatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property S3Access. 
        /// <para>
        /// The Amazon S3 access configuration.
        /// </para>
        /// </summary>
        public S3Access S3Access
        {
            get { return this._s3Access; }
            set { this._s3Access = value; }
        }

        // Check to see if S3Access property is set
        internal bool IsSetS3Access()
        {
            return this._s3Access != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ServiceNetworkArn
        {
            get { return this._serviceNetworkArn; }
            set { this._serviceNetworkArn = value; }
        }

        // Check to see if ServiceNetworkArn property is set
        internal bool IsSetServiceNetworkArn()
        {
            return this._serviceNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkEndpoint. 
        /// <para>
        /// The service network endpoint configuration.
        /// </para>
        /// </summary>
        public ServiceNetworkEndpoint ServiceNetworkEndpoint
        {
            get { return this._serviceNetworkEndpoint; }
            set { this._serviceNetworkEndpoint = value; }
        }

        // Check to see if ServiceNetworkEndpoint property is set
        internal bool IsSetServiceNetworkEndpoint()
        {
            return this._serviceNetworkEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ZeroEtlAccess. 
        /// <para>
        /// The Zero-ETL access configuration.
        /// </para>
        /// </summary>
        public ZeroEtlAccess ZeroEtlAccess
        {
            get { return this._zeroEtlAccess; }
            set { this._zeroEtlAccess = value; }
        }

        // Check to see if ZeroEtlAccess property is set
        internal bool IsSetZeroEtlAccess()
        {
            return this._zeroEtlAccess != null;
        }

    }
}