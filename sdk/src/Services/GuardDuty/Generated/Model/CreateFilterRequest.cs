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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFilter operation.
    /// Creates a filter using the specified finding criteria. The maximum number of saved
    /// filters per Amazon Web Services account per Region is 100. For more information, see
    /// <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_limits.html">Quotas
    /// for GuardDuty</a>.
    /// </summary>
    public partial class CreateFilterRequest : AmazonGuardDutyRequest
    {
        private FilterAction _action;
        private string _clientToken;
        private string _description;
        private string _detectorId;
        private FindingCriteria _findingCriteria;
        private string _name;
        private int? _rank;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action that is to be applied to the findings that match the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public FilterAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token for the create request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the filter. Valid characters include alphanumeric characters, and
        /// special characters such as hyphen, period, colon, underscore, parentheses (<code>{
        /// }</code>, <code>[ ]</code>, and <code>( )</code>), forward slash, horizontal tab,
        /// vertical tab, newline, form feed, return, and whitespace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector belonging to the GuardDuty account that you want to create
        /// a filter for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingCriteria. 
        /// <para>
        /// Represents the criteria to be used in the filter for querying findings.
        /// </para>
        ///  
        /// <para>
        /// You can only use the following attributes to query findings:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// accountId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.accessKeyDetails.accessKeyId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.accessKeyDetails.principalId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.accessKeyDetails.userName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.accessKeyDetails.userType
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.iamInstanceProfile.id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.imageId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.instanceId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.outpostArn
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.ipv6Addresses
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.privateIpAddresses.privateIpAddress
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.publicDnsName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.publicIp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.securityGroups.groupId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.securityGroups.groupName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.subnetId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.networkInterfaces.vpcId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.tags.key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.instanceDetails.tags.value
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.resourceType
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.actionType
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.api
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.callerType
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.errorCode
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.userAgent
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.remoteIpDetails.city.cityName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.remoteIpDetails.country.countryName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.remoteIpDetails.ipAddressV4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.remoteIpDetails.organization.asn
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.remoteIpDetails.organization.asnOrg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.awsApiCallAction.serviceName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.dnsRequestAction.domain
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.blocked
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.connectionDirection
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.localPortDetails.port
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.protocol
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.localIpDetails.ipAddressV4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remoteIpDetails.city.cityName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remoteIpDetails.country.countryName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remoteIpDetails.ipAddressV4
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remoteIpDetails.organization.asn
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remoteIpDetails.organization.asnOrg
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.action.networkConnectionAction.remotePortDetails.port
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.additionalInfo.threatListName
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.s3BucketDetails.publicAccess.effectivePermissions
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.s3BucketDetails.name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.s3BucketDetails.tags.key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.s3BucketDetails.tags.value
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// resource.s3BucketDetails.type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.resourceRole
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// severity
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// type
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// updatedAt
        /// </para>
        ///  
        /// <para>
        /// Type: ISO 8601 string format: YYYY-MM-DDTHH:MM:SS.SSSZ or YYYY-MM-DDTHH:MM:SSZ depending
        /// on whether the value contains milliseconds.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FindingCriteria FindingCriteria
        {
            get { return this._findingCriteria; }
            set { this._findingCriteria = value; }
        }

        // Check to see if FindingCriteria property is set
        internal bool IsSetFindingCriteria()
        {
            return this._findingCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the filter. Valid characters include period (.), underscore (_), dash
        /// (-), and alphanumeric characters. A whitespace is considered to be an invalid character.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// Specifies the position of the filter in the list of current filters. Also specifies
        /// the order in which this filter is applied to the findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int Rank
        {
            get { return this._rank.GetValueOrDefault(); }
            set { this._rank = value; }
        }

        // Check to see if Rank property is set
        internal bool IsSetRank()
        {
            return this._rank.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be added to a new filter resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}