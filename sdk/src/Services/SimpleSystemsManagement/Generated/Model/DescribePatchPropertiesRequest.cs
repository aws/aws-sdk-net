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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePatchProperties operation.
    /// Lists the properties of available patches organized by product, product family, classification,
    /// severity, and other properties of available patches. You can use the reported properties
    /// in the filters you specify in requests for operations such as <a>CreatePatchBaseline</a>,
    /// <a>UpdatePatchBaseline</a>, <a>DescribeAvailablePatches</a>, and <a>DescribePatchBaselines</a>.
    /// 
    ///  
    /// <para>
    /// The following section lists the properties that can be used in filters for each major
    /// operating system type:
    /// </para>
    ///  <dl> <dt>AMAZON_LINUX</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>AMAZON_LINUX_2</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>AMAZON_LINUX_2023</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>CENTOS</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>DEBIAN</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
    /// </para>
    ///  </dd> <dt>MACOS</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> 
    /// </para>
    ///  </dd> <dt>ORACLE_LINUX</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>REDHAT_ENTERPRISE_LINUX</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>SUSE</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>CLASSIFICATION</c> | <c>SEVERITY</c> 
    /// </para>
    ///  </dd> <dt>UBUNTU</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>PRIORITY</c> 
    /// </para>
    ///  </dd> <dt>WINDOWS</dt> <dd> 
    /// <para>
    /// Valid properties: <c>PRODUCT</c> | <c>PRODUCT_FAMILY</c> | <c>CLASSIFICATION</c> |
    /// <c>MSRC_SEVERITY</c> 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class DescribePatchPropertiesRequest : AmazonSimpleSystemsManagementRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private OperatingSystem _operatingSystem;
        private PatchSet _patchSet;
        private PatchProperty _property;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system type for which to list patches.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property PatchSet. 
        /// <para>
        /// Indicates whether to list patches for the Windows operating system or for applications
        /// released by Microsoft. Not applicable for the Linux or macOS operating systems.
        /// </para>
        /// </summary>
        public PatchSet PatchSet
        {
            get { return this._patchSet; }
            set { this._patchSet = value; }
        }

        // Check to see if PatchSet property is set
        internal bool IsSetPatchSet()
        {
            return this._patchSet != null;
        }

        /// <summary>
        /// Gets and sets the property Property. 
        /// <para>
        /// The patch property for which you want to view patch details. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PatchProperty Property
        {
            get { return this._property; }
            set { this._property = value; }
        }

        // Check to see if Property property is set
        internal bool IsSetProperty()
        {
            return this._property != null;
        }

    }
}