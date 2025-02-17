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
    /// Container for the parameters to the GetEventSelectors operation.
    /// Describes the settings for the event selectors that you configured for your trail.
    /// The information returned for your event selectors includes the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If your event selector includes read-only events, write-only events, or all events.
    /// This applies to management events, data events, and network activity events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your event selector includes management events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your event selector includes network activity events, the event sources for which
    /// you are logging network activity events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your event selector includes data events, the resources on which you are logging
    /// data events.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about logging management, data, and network activity events,
    /// see the following topics in the <i>CloudTrail User Guide</i>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-management-events-with-cloudtrail.html">Logging
    /// management events</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-data-events-with-cloudtrail.html">Logging
    /// data events</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/logging-network-events-with-cloudtrail.html">Logging
    /// network activity events</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetEventSelectorsRequest : AmazonCloudTrailRequest
    {
        private string _trailName;

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
        /// If you specify a trail ARN, it must be in the format:
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