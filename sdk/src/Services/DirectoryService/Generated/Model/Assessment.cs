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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains detailed information about a directory assessment, including configuration
    /// parameters, status, and validation results.
    /// </summary>
    public partial class Assessment
    {
        private string _assessmentId;
        private List<string> _customerDnsIps = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _directoryId;
        private string _dnsName;
        private DateTime? _lastUpdateDateTime;
        private string _reportType;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _selfManagedInstanceIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _startTime;
        private string _status;
        private string _statusCode;
        private string _statusReason;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _version;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        /// The unique identifier of the directory assessment.
        /// </para>
        /// </summary>
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerDnsIps. 
        /// <para>
        /// The IP addresses of the DNS servers or domain controllers in your self-managed AD
        /// environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<string> CustomerDnsIps
        {
            get { return this._customerDnsIps; }
            set { this._customerDnsIps = value; }
        }

        // Check to see if CustomerDnsIps property is set
        internal bool IsSetCustomerDnsIps()
        {
            return this._customerDnsIps != null && (this._customerDnsIps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory associated with this assessment.
        /// </para>
        /// </summary>
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The fully qualified domain name (FQDN) of the Active Directory domain being assessed.
        /// </para>
        /// </summary>
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDateTime. 
        /// <para>
        /// The date and time when the assessment status was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateDateTime
        {
            get { return this._lastUpdateDateTime; }
            set { this._lastUpdateDateTime = value; }
        }

        // Check to see if LastUpdateDateTime property is set
        internal bool IsSetLastUpdateDateTime()
        {
            return this._lastUpdateDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReportType. 
        /// <para>
        /// The type of assessment report generated. Valid values are <c>CUSTOMER</c> and <c>SYSTEM</c>.
        /// </para>
        /// </summary>
        public string ReportType
        {
            get { return this._reportType; }
            set { this._reportType = value; }
        }

        // Check to see if ReportType property is set
        internal bool IsSetReportType()
        {
            return this._reportType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security groups identifiers attached to the network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SelfManagedInstanceIds. 
        /// <para>
        /// The identifiers of the self-managed AD instances used to perform the assessment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public List<string> SelfManagedInstanceIds
        {
            get { return this._selfManagedInstanceIds; }
            set { this._selfManagedInstanceIds = value; }
        }

        // Check to see if SelfManagedInstanceIds property is set
        internal bool IsSetSelfManagedInstanceIds()
        {
            return this._selfManagedInstanceIds != null && (this._selfManagedInstanceIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The date and time when the assessment was initiated.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the assessment. Valid values include <c>SUCCESS</c>, <c>FAILED</c>,
        /// <c>PENDING</c>, and <c>IN_PROGRESS</c>.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// A detailed status code providing additional information about the assessment state.
        /// </para>
        /// </summary>
        public string StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A human-readable description of the current assessment status, including any error
        /// details or progress information.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// A list of subnet identifiers in the Amazon VPC in which the hybrid directory is created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the assessment framework used to evaluate your self-managed AD environment.
        /// </para>
        /// </summary>
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Contains Amazon VPC information for the <c>StartADAssessment</c> operation. 
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}