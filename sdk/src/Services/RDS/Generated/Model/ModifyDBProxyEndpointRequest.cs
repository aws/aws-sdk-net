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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBProxyEndpoint operation.
    /// Changes the settings for an existing DB proxy endpoint.
    /// </summary>
    public partial class ModifyDBProxyEndpointRequest : AmazonRDSRequest
    {
        private string _dbProxyEndpointName;
        private string _newDBProxyEndpointName;
        private List<string> _vpcSecurityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DBProxyEndpointName. 
        /// <para>
        /// The name of the DB proxy sociated with the DB proxy endpoint that you want to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DBProxyEndpointName
        {
            get { return this._dbProxyEndpointName; }
            set { this._dbProxyEndpointName = value; }
        }

        // Check to see if DBProxyEndpointName property is set
        internal bool IsSetDBProxyEndpointName()
        {
            return this._dbProxyEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property NewDBProxyEndpointName. 
        /// <para>
        /// The new identifier for the <c>DBProxyEndpoint</c>. An identifier must begin with a
        /// letter and must contain only ASCII letters, digits, and hyphens; it can't end with
        /// a hyphen or contain two consecutive hyphens.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string NewDBProxyEndpointName
        {
            get { return this._newDBProxyEndpointName; }
            set { this._newDBProxyEndpointName = value; }
        }

        // Check to see if NewDBProxyEndpointName property is set
        internal bool IsSetNewDBProxyEndpointName()
        {
            return this._newDBProxyEndpointName != null;
        }

        /// <summary>
        /// Gets and sets the property VpcSecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs for the DB proxy endpoint. When the DB proxy endpoint uses
        /// a different VPC than the original proxy, you also specify a different set of security
        /// group IDs than for the original proxy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroupIds
        {
            get { return this._vpcSecurityGroupIds; }
            set { this._vpcSecurityGroupIds = value; }
        }

        // Check to see if VpcSecurityGroupIds property is set
        internal bool IsSetVpcSecurityGroupIds()
        {
            return this._vpcSecurityGroupIds != null && (this._vpcSecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}