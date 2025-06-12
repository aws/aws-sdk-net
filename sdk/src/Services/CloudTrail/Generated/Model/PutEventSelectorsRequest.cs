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
    /// Container for the parameters to the PutEventSelectors operation.
    /// Configures event selectors (also referred to as <i>basic event selectors</i>) or advanced
    /// event selectors for your trail. You can use either <c>AdvancedEventSelectors</c> or
    /// <c>EventSelectors</c>, but not both. If you apply <c>AdvancedEventSelectors</c> to
    /// a trail, any existing <c>EventSelectors</c> are overwritten.
    /// 
    ///  
    /// <para>
    /// You can use <c>AdvancedEventSelectors</c> to log management events, data events for
    /// all resource types, and network activity events.
    /// </para>
    ///  
    /// <para>
    /// You can use <c>EventSelectors</c> to log management events and data events for the
    /// following resource types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>AWS::DynamoDB::Table</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AWS::Lambda::Function</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>AWS::S3::Object</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can't use <c>EventSelectors</c> to log network activity events.
    /// </para>
    ///  
    /// <para>
    /// If you want your trail to log Insights events, be sure the event selector or advanced
    /// event selector enables logging of the Insights event types you want configured for
    /// your trail. For more information about logging Insights events, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-insights-events-with-cloudtrail.html">Working
    /// with CloudTrail Insights</a> in the <i>CloudTrail User Guide</i>. By default, trails
    /// created without specific event selectors are configured to log all read and write
    /// management events, and no data events or network activity events.
    /// </para>
    ///  
    /// <para>
    /// When an event occurs in your account, CloudTrail evaluates the event selectors or
    /// advanced event selectors in all trails. For each trail, if the event matches any event
    /// selector, the trail processes and logs the event. If the event doesn't match any event
    /// selector, the trail doesn't log the event.
    /// </para>
    ///  
    /// <para>
    /// Example
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// You create an event selector for a trail and specify that you want to log write-only
    /// events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The EC2 <c>GetConsoleOutput</c> and <c>RunInstances</c> API operations occur in your
    /// account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudTrail evaluates whether the events match your event selectors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>RunInstances</c> is a write-only event and it matches your event selector.
    /// The trail logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <c>GetConsoleOutput</c> is a read-only event that doesn't match your event selector.
    /// The trail doesn't log the event. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The <c>PutEventSelectors</c> operation must be called from the Region in which the
    /// trail was created; otherwise, an <c>InvalidHomeRegionException</c> exception is thrown.
    /// </para>
    ///  
    /// <para>
    /// You can configure up to five event selectors for each trail.
    /// </para>
    ///  
    /// <para>
    /// You can add advanced event selectors, and conditions for your advanced event selectors,
    /// up to a maximum of 500 values for all conditions and selectors on a trail. For more
    /// information, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
    /// management events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
    /// data events</a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
    /// network activity events</a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
    /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutEventSelectorsRequest : AmazonCloudTrailRequest
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = AWSConfigs.InitializeCollections ? new List<AdvancedEventSelector>() : null;
        private List<EventSelector> _eventSelectors = AWSConfigs.InitializeCollections ? new List<EventSelector>() : null;
        private string _trailName;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        ///  Specifies the settings for advanced event selectors. You can use advanced event selectors
        /// to log management events, data events for all resource types, and network activity
        /// events.
        /// </para>
        ///  
        /// <para>
        /// You can add advanced event selectors, and conditions for your advanced event selectors,
        /// up to a maximum of 500 values for all conditions and selectors on a trail. You can
        /// use either <c>AdvancedEventSelectors</c> or <c>EventSelectors</c>, but not both. If
        /// you apply <c>AdvancedEventSelectors</c> to a trail, any existing <c>EventSelectors</c>
        /// are overwritten. For more information about advanced event selectors, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events</a> and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
        /// network activity events</a> in the <i>CloudTrail User Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && (this._advancedEventSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EventSelectors. 
        /// <para>
        /// Specifies the settings for your event selectors. You can use event selectors to log
        /// management events and data events for the following resource types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS::DynamoDB::Table</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::Lambda::Function</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AWS::S3::Object</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can't use event selectors to log network activity events.
        /// </para>
        ///  
        /// <para>
        /// You can configure up to five event selectors for a trail. You can use either <c>EventSelectors</c>
        /// or <c>AdvancedEventSelectors</c> in a <c>PutEventSelectors</c> request, but not both.
        /// If you apply <c>EventSelectors</c> to a trail, any existing <c>AdvancedEventSelectors</c>
        /// are overwritten.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EventSelector> EventSelectors
        {
            get { return this._eventSelectors; }
            set { this._eventSelectors = value; }
        }

        // Check to see if EventSelectors property is set
        internal bool IsSetEventSelectors()
        {
            return this._eventSelectors != null && (this._eventSelectors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrailName. 
        /// <para>
        /// Specifies the name of the trail or trail ARN. If you specify a trail name, the string
        /// must meet the following requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Contain only ASCII letters (a-z, A-Z), numbers (0-9), periods (.), underscores (_),
        /// or dashes (-)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Start with a letter or number, and end with a letter or number
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Be between 3 and 128 characters
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Have no adjacent periods, underscores or dashes. Names like <c>my-_namespace</c> and
        /// <c>my--namespace</c> are not valid.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not be in IP address format (for example, 192.168.5.4)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify a trail ARN, it must be in the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrailName
        {
            get { return this._trailName; }
            set { this._trailName = value; }
        }

        // Check to see if TrailName property is set
        internal bool IsSetTrailName()
        {
            return this._trailName != null;
        }

    }
}