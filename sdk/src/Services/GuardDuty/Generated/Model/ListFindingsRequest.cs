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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the ListFindings operation.
    /// Lists GuardDuty findings for the specified detector ID.
    /// 
    ///  
    /// <para>
    /// There might be regional differences because some flags might not be available in all
    /// the Regions where GuardDuty is currently supported. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_regions.html">Regions
    /// and endpoints</a>.
    /// </para>
    /// </summary>
    public partial class ListFindingsRequest : AmazonGuardDutyRequest
    {
        private string _detectorId;
        private FindingCriteria _findingCriteria;
        private int? _maxResults;
        private string _nextToken;
        private SortCriteria _sortCriteria;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector that specifies the GuardDuty service whose findings you want
        /// to list.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
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
        /// Represents the criteria used for querying findings. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// JSON field name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// accountId
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// region
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// confidence
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
        /// service.action.dnsRequestAction.domainWithSuffix
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
        /// service.archived
        /// </para>
        ///  
        /// <para>
        /// When this attribute is set to 'true', only archived findings are listed. When it's
        /// set to 'false', only unarchived findings are listed. When this attribute is not set,
        /// all existing findings are listed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// service.ebsVolumeScanDetails.scanId
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
        /// Type: Timestamp in Unix Epoch millisecond format: 1486685375000
        /// </para>
        ///  </li> </ul>
        /// </summary>
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// You can use this parameter to indicate the maximum number of items you want in the
        /// response. The default value is 50. The maximum value is 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// You can use this parameter when paginating results. Set the value of this parameter
        /// to null on your first call to the list action. For subsequent calls to the action,
        /// fill nextToken in the request with the value of NextToken from the previous response
        /// to continue listing data.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortCriteria. 
        /// <para>
        /// Represents the criteria used for sorting findings.
        /// </para>
        /// </summary>
        public SortCriteria SortCriteria
        {
            get { return this._sortCriteria; }
            set { this._sortCriteria = value; }
        }

        // Check to see if SortCriteria property is set
        internal bool IsSetSortCriteria()
        {
            return this._sortCriteria != null;
        }

    }
}