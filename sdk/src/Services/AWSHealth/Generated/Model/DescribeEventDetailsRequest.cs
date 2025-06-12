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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeEventDetails operation.
    /// Returns detailed information about one or more specified events. Information includes
    /// standard event data (Amazon Web Services Region, service, and so on, as returned by
    /// <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeEvents.html">DescribeEvents</a>),
    /// a detailed event description, and possible additional metadata that depends upon the
    /// nature of the event. Affected entities are not included. To retrieve the entities,
    /// use the <a href="https://docs.aws.amazon.com/health/latest/APIReference/API_DescribeAffectedEntities.html">DescribeAffectedEntities</a>
    /// operation.
    /// 
    ///  
    /// <para>
    /// If a specified event can't be retrieved, an error message is returned for that event.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation supports resource-level permissions. You can use this operation to
    /// allow or deny access to specific Health events. For more information, see <a href="https://docs.aws.amazon.com/health/latest/ug/security_iam_id-based-policy-examples.html#resource-action-based-conditions">Resource-
    /// and action-based conditions</a> in the <i>Health User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeEventDetailsRequest : AmazonAWSHealthRequest
    {
        private List<string> _eventArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _locale;

        /// <summary>
        /// Gets and sets the property EventArns. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <c>"arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-CDE456",
        /// "arn:aws:health:us-west-1::event/EBS/AWS_EBS_LOST_VOLUME/AWS_EBS_LOST_VOLUME_CHI789_JKL101"</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<string> EventArns
        {
            get { return this._eventArns; }
            set { this._eventArns = value; }
        }

        // Check to see if EventArns property is set
        internal bool IsSetEventArns()
        {
            return this._eventArns != null && (this._eventArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Locale. 
        /// <para>
        /// The locale (language) to return information in. English (en) is the default and the
        /// only supported value at this time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=256)]
        public string Locale
        {
            get { return this._locale; }
            set { this._locale = value; }
        }

        // Check to see if Locale property is set
        internal bool IsSetLocale()
        {
            return this._locale != null;
        }

    }
}