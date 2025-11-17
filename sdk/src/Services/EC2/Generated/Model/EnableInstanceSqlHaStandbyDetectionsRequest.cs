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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableInstanceSqlHaStandbyDetections operation.
    /// Enable Amazon EC2 instances running in an SQL Server High Availability cluster for
    /// SQL Server High Availability instance standby detection monitoring. Once enabled,
    /// Amazon Web Services monitors the metadata for the instances to determine whether they
    /// are active or standby nodes in the SQL Server High Availability cluster. If the instances
    /// are determined to be standby failover nodes, Amazon Web Services automatically applies
    /// SQL Server licensing fee waiver for those instances.
    /// 
    ///  
    /// <para>
    /// To register an instance, it must be running a Windows SQL Server license-included
    /// AMI and have the Amazon Web Services Systems Manager agent installed and running.
    /// Only Windows Server 2019 and later and SQL Server (Standard and Enterprise editions)
    /// 2017 and later are supported. For more information, see <a href="https://docs.aws.amazon.com/sql-server-ec2/latest/userguide/prerequisites-and-requirements.html">
    /// Prerequisites for using SQL Server High Availability instance standby detection</a>.
    /// </para>
    /// </summary>
    public partial class EnableInstanceSqlHaStandbyDetectionsRequest : AmazonEC2Request
    {
        private List<string> _instanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sqlServerCredentials;

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// The IDs of the instances to enable for SQL Server High Availability standby detection
        /// monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && (this._instanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SqlServerCredentials. 
        /// <para>
        /// The ARN of the Secrets Manager secret containing the SQL Server access credentials.
        /// The specified secret must contain valid SQL Server credentials for the specified instances.
        /// If not specified, deafult local user credentials will be used by the Amazon Web Services
        /// Systems Manager agent. To enable instances with different credentials, you must make
        /// separate requests.
        /// </para>
        /// </summary>
        public string SqlServerCredentials
        {
            get { return this._sqlServerCredentials; }
            set { this._sqlServerCredentials = value; }
        }

        // Check to see if SqlServerCredentials property is set
        internal bool IsSetSqlServerCredentials()
        {
            return this._sqlServerCredentials != null;
        }

    }
}