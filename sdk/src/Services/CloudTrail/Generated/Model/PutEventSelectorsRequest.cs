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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the PutEventSelectors operation.
    /// Configures an event selector or advanced event selectors for your trail. Use event
    /// selectors or advanced event selectors to specify management and data event settings
    /// for your trail. By default, trails created without specific event selectors are configured
    /// to log all read and write management events, and no data events.
    /// 
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
    /// You create an event selector for a trail and specify that you want write-only events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The EC2 <code>GetConsoleOutput</code> and <code>RunInstances</code> API operations
    /// occur in your account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudTrail evaluates whether the events match your event selectors.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>RunInstances</code> is a write-only event and it matches your event selector.
    /// The trail logs the event.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The <code>GetConsoleOutput</code> is a read-only event that doesn't match your event
    /// selector. The trail doesn't log the event. 
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// The <code>PutEventSelectors</code> operation must be called from the region in which
    /// the trail was created; otherwise, an <code>InvalidHomeRegionException</code> exception
    /// is thrown.
    /// </para>
    ///  
    /// <para>
    /// You can configure up to five event selectors for each trail. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
    /// management events for trails </a>, <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
    /// data events for trails </a>, and <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/WhatIsCloudTrail-Limits.html">Quotas
    /// in CloudTrail</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// You can add advanced event selectors, and conditions for your advanced event selectors,
    /// up to a maximum of 500 values for all conditions and selectors on a trail. You can
    /// use either <code>AdvancedEventSelectors</code> or <code>EventSelectors</code>, but
    /// not both. If you apply <code>AdvancedEventSelectors</code> to a trail, any existing
    /// <code>EventSelectors</code> are overwritten. For more information about advanced event
    /// selectors, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
    /// data events for trails</a> in the <i>CloudTrail User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutEventSelectorsRequest : AmazonCloudTrailRequest
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = new List<AdvancedEventSelector>();
        private List<EventSelector> _eventSelectors = new List<EventSelector>();
        private string _trailName;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        ///  Specifies the settings for advanced event selectors. You can add advanced event selectors,
        /// and conditions for your advanced event selectors, up to a maximum of 500 values for
        /// all conditions and selectors on a trail. You can use either <code>AdvancedEventSelectors</code>
        /// or <code>EventSelectors</code>, but not both. If you apply <code>AdvancedEventSelectors</code>
        /// to a trail, any existing <code>EventSelectors</code> are overwritten. For more information
        /// about advanced event selectors, see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
        /// data events for trails</a> in the <i>CloudTrail User Guide</i>. 
        /// </para>
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && this._advancedEventSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventSelectors. 
        /// <para>
        /// Specifies the settings for your event selectors. You can configure up to five event
        /// selectors for a trail. You can use either <code>EventSelectors</code> or <code>AdvancedEventSelectors</code>
        /// in a <code>PutEventSelectors</code> request, but not both. If you apply <code>EventSelectors</code>
        /// to a trail, any existing <code>AdvancedEventSelectors</code> are overwritten.
        /// </para>
        /// </summary>
        public List<EventSelector> EventSelectors
        {
            get { return this._eventSelectors; }
            set { this._eventSelectors = value; }
        }

        // Check to see if EventSelectors property is set
        internal bool IsSetEventSelectors()
        {
            return this._eventSelectors != null && this._eventSelectors.Count > 0; 
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
        /// Have no adjacent periods, underscores or dashes. Names like <code>my-_namespace</code>
        /// and <code>my--namespace</code> are not valid.
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
        ///  <code>arn:aws:cloudtrail:us-east-2:123456789012:trail/MyTrail</code> 
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