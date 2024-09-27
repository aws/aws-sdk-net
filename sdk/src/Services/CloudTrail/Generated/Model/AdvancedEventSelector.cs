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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Advanced event selectors let you create fine-grained selectors for CloudTrail management,
    /// data, and network activity events. They help you control costs by logging only those
    /// events that are important to you. For more information about configuring advanced
    /// event selectors, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
    /// data events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
    /// network activity events</a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
    /// management events</a> topics in the <i>CloudTrail User Guide</i>.
    /// 
    ///  
    /// <para>
    /// You cannot apply both event selectors and advanced event selectors to a trail.
    /// </para>
    ///  
    /// <para>
    ///  <b>Supported CloudTrail event record fields for management events</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>eventCategory</c> (required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>eventSource</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>readOnly</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Supported CloudTrail event record fields for data events</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>eventCategory</c> (required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>resources.type</c> (required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>readOnly</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>eventName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>resources.ARN</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Supported CloudTrail event record fields for network activity events</b> 
    /// </para>
    ///  <note> 
    /// <para>
    /// Network activity events is in preview release for CloudTrail and is subject to change.
    /// </para>
    ///  </note> <ul> <li> 
    /// <para>
    ///  <c>eventCategory</c> (required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>eventSource</c> (required)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>eventName</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>errorCode</c> - The only valid value for <c>errorCode</c> is <c>VpceAccessDenied</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>vpcEndpointId</c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// For event data stores for CloudTrail Insights events, Config configuration items,
    /// Audit Manager evidence, or events outside of Amazon Web Services, the only supported
    /// field is <c>eventCategory</c>. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AdvancedEventSelector
    {
        private List<AdvancedFieldSelector> _fieldSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedFieldSelector>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property FieldSelectors. 
        /// <para>
        /// Contains all selector statements in an advanced event selector.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<AdvancedFieldSelector> FieldSelectors
        {
            get { return this._fieldSelectors; }
            set { this._fieldSelectors = value; }
        }

        // Check to see if FieldSelectors property is set
        internal bool IsSetFieldSelectors()
        {
            return this._fieldSelectors != null && (this._fieldSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// An optional, descriptive name for an advanced event selector, such as "Log data events
        /// for only two S3 buckets".
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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

    }
}