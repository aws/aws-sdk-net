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
    /// Describes an Amazon EC2 instance that is enabled for SQL Server High Availability
    /// standby detection monitoring.
    /// </summary>
    public partial class RegisteredInstance
    {
        private HaStatus _haStatus;
        private string _instanceId;
        private DateTime? _lastUpdatedTime;
        private string _processingStatus;
        private string _sqlServerCredentials;
        private SqlServerLicenseUsage _sqlServerLicenseUsage;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property HaStatus. 
        /// <para>
        /// The SQL Server High Availability status of the instance. Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>processing</c> - The SQL Server High Availability status for the SQL Server High
        /// Availability instance is being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>active</c> - The SQL Server High Availability instance is an active node in an
        /// SQL Server High Availability cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standby</c> - The SQL Server High Availability instance is a standby failover
        /// node in an SQL Server High Availability cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>invalid</c> - An error occurred due to misconfigured permissions, or unable to
        /// dertemine SQL Server High Availability status for the SQL Server High Availability
        /// instance.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HaStatus HaStatus
        {
            get { return this._haStatus; }
            set { this._haStatus = value; }
        }

        // Check to see if HaStatus property is set
        internal bool IsSetHaStatus()
        {
            return this._haStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the SQL Server High Availability instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The date and time when the instance's SQL Server High Availability status was last
        /// updated, in the ISO 8601 format in the UTC time zone (<c>YYYY-MM-DDThh:mm:ss.sssZ</c>).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProcessingStatus. 
        /// <para>
        /// A brief description of the SQL Server High Availability status. If the instance is
        /// in the <c>invalid</c> High Availability status, this parameter includes the error
        /// message.
        /// </para>
        /// </summary>
        public string ProcessingStatus
        {
            get { return this._processingStatus; }
            set { this._processingStatus = value; }
        }

        // Check to see if ProcessingStatus property is set
        internal bool IsSetProcessingStatus()
        {
            return this._processingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property SqlServerCredentials. 
        /// <para>
        /// The ARN of the Secrets Manager secret containing the SQL Server access credentials
        /// for the SQL Server High Availability instance. If not specified, deafult local user
        /// credentials will be used by the Amazon Web Services Systems Manager agent.
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

        /// <summary>
        /// Gets and sets the property SqlServerLicenseUsage. 
        /// <para>
        /// The license type for the SQL Server license. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>full</c> - The SQL Server High Availability instance is using a full SQL Server
        /// license.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>waived</c> - The SQL Server High Availability instance is waived from the SQL
        /// Server license.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SqlServerLicenseUsage SqlServerLicenseUsage
        {
            get { return this._sqlServerLicenseUsage; }
            set { this._sqlServerLicenseUsage = value; }
        }

        // Check to see if SqlServerLicenseUsage property is set
        internal bool IsSetSqlServerLicenseUsage()
        {
            return this._sqlServerLicenseUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the SQL Server High Availability instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}